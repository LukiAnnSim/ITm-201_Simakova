using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.AnalysisServices;
using Microsoft.AnalysisServices.AdomdClient;

namespace WindowsFormsAppLab7_8
{
    public partial class FormClient : Form
    {
        public Server TransportServer = new Server();
        public Microsoft.AnalysisServices.DimensionCollection dims;
        public Microsoft.AnalysisServices.CubeCollection cubes;
        public string DataBaseName7, DataBaseName8, serverName;
        public int Idbase;
        public string rows, columns, from, where;
        String[] FilterEmp = {"Старший диспетчер", "Диспетчер"};
        String[] FilterProd = {"Тахограф", "Касса", "Считыватель карт", "Датчик уровня жидкости"};



        public FormClient()
        {
            InitializeComponent();
        }

        //7
        public void ConnectToDB7()
        {
            Database db = TransportServer.Databases[Idbase];
            dims = db.Dimensions;
            cubes = db.Cubes;
            foreach (var temp in dims)
                listBoxDim.Items.Add(temp.ToString());
             for (int i = 0; i < cubes.Count; i++)
                listBoxCube.Items.Add(cubes[i].ToString());
        }


        private void buttonConnect7_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseName7 = textBoxServer7.Text.ToString();
                TransportServer.Connect("provider= msolap; Data Source=" + DataBaseName7);

                foreach (Database db in TransportServer.Databases)
                {
                    comboBoxBase.Items.Add(db.Name);
                }
                
                MessageBox.Show("Подключение успешно)");
            }
           
            catch (Microsoft.AnalysisServices.ConnectionException incorrect)
            {
                MessageBox.Show("Неверно указано имя сервера базы данных: " + incorrect.Message);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Исключение в процессе соединения с базой данных: " + ex.Message);
            }
        }

        private void buttonBaseConnect7_Click(object sender, EventArgs e)
        {
            listBoxDim.Items.Clear();
            listBoxCube.Items.Clear();
            Idbase = comboBoxBase.SelectedIndex;
            ConnectToDB7();
            buttonProcessing.Enabled = true;
        }

        private void comboBoxBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBaseConnect7.Enabled = true;
        }

        private void buttonProcessing_Click(object sender, EventArgs e)
        {
            try
            {
                if (listBoxDim.SelectedItem != null)
                    dims[listBoxDim.SelectedIndex].Process(ProcessType.ProcessFull);//обработка
                else
                    cubes[listBoxCube.SelectedIndex].Process(ProcessType.ProcessFull);
                MessageBox.Show("Процессинг выполнен успешно");
            }
            catch (Exception ex)
            {
                MessageBox.Show("При выполнении процессинга возникло исключение: " + ex.Message); 
            }
        }

        private void listBoxCube_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxDim.SelectedIndexChanged -= new EventHandler(this.listBoxDim_SelectedIndexChanged);
            listBoxDim.ClearSelected();
            listBoxDim.SelectedIndexChanged += new EventHandler(this.listBoxDim_SelectedIndexChanged);
            CubeUpdate.Text = "Последний процессинг куба: " + cubes[listBoxCube.SelectedIndex].LastProcessed;
        }

        private void listBoxDim_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxCube.SelectedIndexChanged -= new EventHandler(this.listBoxCube_SelectedIndexChanged);
            listBoxCube.ClearSelected();
            listBoxCube.SelectedIndexChanged += new EventHandler(this.listBoxCube_SelectedIndexChanged);
        }

        //8
        public void ConnectToDB8()
        {
            AdomdConnection connection = new AdomdConnection(@"DataSource=" + serverName);
            try
            {
                connection.Open();
                connection.ChangeDatabase(DataBaseName8);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Исключение в процессе соединения с базой данных: " + ex.Message);
            }

            try
            {
                AdomdDataAdapter adapter = new AdomdDataAdapter(@"select " + columns + " on columns, "
            + rows + " on rows FROM " + from + where, connection);
                DataSet set = new DataSet();
                adapter.Fill(set);
                dataGridViewReport.DataSource = set.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Исключение при формировании отчёта: " + ex.Message);
            }
        }

        private void comboBoxSelectReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectReport.SelectedIndex==0)
            {
                comboBoxSelectFilter.Items.Clear();
                labelFilter.Text = "Должность";
                foreach(String str in FilterEmp)
                {
                    comboBoxSelectFilter.Items.Add(str);
                }
            }
            if (comboBoxSelectReport.SelectedIndex == 1)
            {
                comboBoxSelectFilter.Items.Clear();
                labelFilter.Text = "Товар";
                foreach (String str in FilterProd)
                {
                    comboBoxSelectFilter.Items.Add(str);
                }
            }
            buttonReportConn8.Enabled = true;
        }
        private void buttonReportConn8_Click(object sender, EventArgs e)
        {
            serverName = textBoxServer8.Text.ToString();
            DataBaseName8 = textBoxBase8.Text.ToString();
            string datefrom = dateTimePickerBegin.Value.ToString("yyyy-MM-dd");
            string dateto = dateTimePickerEnd.Value.ToString("yyyy-MM-dd");
            dataGridViewReport.Columns.Clear();

            try
            {
                if (comboBoxSelectReport.SelectedIndex == 0)
                {
                    string Filter = comboBoxSelectFilter.SelectedItem.ToString();
                    columns = "([Measures].[Количество])";
                    rows = "non empty([Даты].[Год-День].Members, [Сотрудники].[Сотрудник].[ФИО])";
                    from = "[ПроверкаТранспорта]";
                    where = "where ([Даты].[Date].&[" + datefrom + "T00:00:00]:[Даты].[Date].&[" + dateto + "T00:00:00],[Сотрудники].[Должность].&[" + Filter + "])";
                    ConnectToDB8();

                    dataGridViewReport.Columns[0].HeaderText = "Год";
                    dataGridViewReport.Columns[1].HeaderText = "Месяц";
                    dataGridViewReport.Columns[2].HeaderText = "Число";
                    dataGridViewReport.Columns[3].HeaderText = "Должность";
                    dataGridViewReport.Columns[4].HeaderText = "ФИО";
                    dataGridViewReport.Columns[5].HeaderText = "Количество";
                
            }
                if (comboBoxSelectReport.SelectedIndex == 1)
                {
                    string Filter = comboBoxSelectFilter.SelectedItem.ToString();
                    columns = "([Measures].[Количество])";
                    rows = "non empty ([Даты].[Год-День].Members, [Сотрудники].[Сотрудник].[ФИО])";
                    from = "[ПродажаТоваров]";
                    where = "where ([Даты].[Date].&[" + datefrom + "T00:00:00]:[Даты].[Date].&[" + dateto + "T00:00:00],[Продукты].[Товар].[Название].&[" + Filter + "])";
                    ConnectToDB8();

                    dataGridViewReport.Columns[0].HeaderText = "Год";
                    dataGridViewReport.Columns[1].HeaderText = "Месяц";
                    dataGridViewReport.Columns[2].HeaderText = "Число";
                    dataGridViewReport.Columns[3].HeaderText = "Должность";
                    dataGridViewReport.Columns[4].HeaderText = "ФИО";
                    dataGridViewReport.Columns[5].HeaderText = "Количество";
                }
            }
            catch
            {}
        }
    }
}
