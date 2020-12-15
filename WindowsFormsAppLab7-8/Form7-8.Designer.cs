namespace WindowsFormsAppLab7_8
{
    partial class FormClient
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelFilter = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControlL78 = new System.Windows.Forms.TabControl();
            this.tabPageL7 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxServer7 = new System.Windows.Forms.TextBox();
            this.buttonConnect7 = new System.Windows.Forms.Button();
            this.comboBoxBase = new System.Windows.Forms.ComboBox();
            this.buttonBaseConnect7 = new System.Windows.Forms.Button();
            this.CubeUpdate = new System.Windows.Forms.Label();
            this.listBoxDim = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonProcessing = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.listBoxCube = new System.Windows.Forms.ListBox();
            this.tabPageL8 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxBase8 = new System.Windows.Forms.TextBox();
            this.textBoxServer8 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridViewReport = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonReportConn8 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.comboBoxSelectReport = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectFilter = new System.Windows.Forms.ComboBox();
            this.errorConfiguration1 = new Microsoft.AnalysisServices.ErrorConfiguration();
            this.tabControlL78.SuspendLayout();
            this.tabPageL7.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageL8.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "База данных";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Сервер";
            // 
            // labelFilter
            // 
            this.labelFilter.AutoSize = true;
            this.labelFilter.Location = new System.Drawing.Point(229, 54);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(47, 13);
            this.labelFilter.TabIndex = 3;
            this.labelFilter.Text = "Фильтр";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Отчет";
            // 
            // tabControlL78
            // 
            this.tabControlL78.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlL78.Controls.Add(this.tabPageL7);
            this.tabControlL78.Controls.Add(this.tabPageL8);
            this.tabControlL78.Location = new System.Drawing.Point(12, 12);
            this.tabControlL78.MinimumSize = new System.Drawing.Size(779, 484);
            this.tabControlL78.Name = "tabControlL78";
            this.tabControlL78.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControlL78.SelectedIndex = 0;
            this.tabControlL78.Size = new System.Drawing.Size(779, 484);
            this.tabControlL78.TabIndex = 5;
            // 
            // tabPageL7
            // 
            this.tabPageL7.Controls.Add(this.groupBox2);
            this.tabPageL7.Controls.Add(this.CubeUpdate);
            this.tabPageL7.Controls.Add(this.listBoxDim);
            this.tabPageL7.Controls.Add(this.label7);
            this.tabPageL7.Controls.Add(this.buttonProcessing);
            this.tabPageL7.Controls.Add(this.label6);
            this.tabPageL7.Controls.Add(this.listBoxCube);
            this.tabPageL7.Location = new System.Drawing.Point(4, 22);
            this.tabPageL7.Name = "tabPageL7";
            this.tabPageL7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageL7.Size = new System.Drawing.Size(771, 458);
            this.tabPageL7.TabIndex = 0;
            this.tabPageL7.Text = "Лаба 7";
            this.tabPageL7.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBoxServer7);
            this.groupBox2.Controls.Add(this.buttonBaseConnect7);
            this.groupBox2.Controls.Add(this.comboBoxBase);
            this.groupBox2.Controls.Add(this.buttonConnect7);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(9, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 149);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Настройки подключения";
            // 
            // textBoxServer7
            // 
            this.textBoxServer7.Location = new System.Drawing.Point(92, 19);
            this.textBoxServer7.Name = "textBoxServer7";
            this.textBoxServer7.Size = new System.Drawing.Size(133, 20);
            this.textBoxServer7.TabIndex = 11;
            this.textBoxServer7.Text = "localhost";
            // 
            // buttonConnect7
            // 
            this.buttonConnect7.Location = new System.Drawing.Point(140, 45);
            this.buttonConnect7.Name = "buttonConnect7";
            this.buttonConnect7.Size = new System.Drawing.Size(85, 23);
            this.buttonConnect7.TabIndex = 18;
            this.buttonConnect7.Text = "Подключение";
            this.buttonConnect7.UseVisualStyleBackColor = true;
            this.buttonConnect7.Click += new System.EventHandler(this.buttonConnect7_Click);
            // 
            // comboBoxBase
            // 
            this.comboBoxBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxBase.FormattingEnabled = true;
            this.comboBoxBase.Location = new System.Drawing.Point(92, 90);
            this.comboBoxBase.Name = "comboBoxBase";
            this.comboBoxBase.Size = new System.Drawing.Size(133, 21);
            this.comboBoxBase.TabIndex = 10;
            this.comboBoxBase.SelectedIndexChanged += new System.EventHandler(this.comboBoxBase_SelectedIndexChanged);
            // 
            // buttonBaseConnect7
            // 
            this.buttonBaseConnect7.Enabled = false;
            this.buttonBaseConnect7.Location = new System.Drawing.Point(140, 117);
            this.buttonBaseConnect7.Name = "buttonBaseConnect7";
            this.buttonBaseConnect7.Size = new System.Drawing.Size(85, 23);
            this.buttonBaseConnect7.TabIndex = 7;
            this.buttonBaseConnect7.Text = "Подключение";
            this.buttonBaseConnect7.UseVisualStyleBackColor = true;
            this.buttonBaseConnect7.Click += new System.EventHandler(this.buttonBaseConnect7_Click);
            // 
            // CubeUpdate
            // 
            this.CubeUpdate.AutoSize = true;
            this.CubeUpdate.Location = new System.Drawing.Point(15, 197);
            this.CubeUpdate.Name = "CubeUpdate";
            this.CubeUpdate.Size = new System.Drawing.Size(154, 13);
            this.CubeUpdate.TabIndex = 17;
            this.CubeUpdate.Text = "Последний процессинг куба:";
            // 
            // listBoxDim
            // 
            this.listBoxDim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxDim.FormattingEnabled = true;
            this.listBoxDim.Location = new System.Drawing.Point(511, 43);
            this.listBoxDim.Name = "listBoxDim";
            this.listBoxDim.Size = new System.Drawing.Size(216, 355);
            this.listBoxDim.TabIndex = 14;
            this.listBoxDim.SelectedIndexChanged += new System.EventHandler(this.listBoxDim_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Кубы";
            // 
            // buttonProcessing
            // 
            this.buttonProcessing.Enabled = false;
            this.buttonProcessing.Location = new System.Drawing.Point(149, 238);
            this.buttonProcessing.Name = "buttonProcessing";
            this.buttonProcessing.Size = new System.Drawing.Size(85, 23);
            this.buttonProcessing.TabIndex = 8;
            this.buttonProcessing.Text = "Процессинг";
            this.buttonProcessing.UseVisualStyleBackColor = true;
            this.buttonProcessing.Click += new System.EventHandler(this.buttonProcessing_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Измерения";
            // 
            // listBoxCube
            // 
            this.listBoxCube.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.listBoxCube.FormattingEnabled = true;
            this.listBoxCube.Location = new System.Drawing.Point(282, 43);
            this.listBoxCube.Name = "listBoxCube";
            this.listBoxCube.Size = new System.Drawing.Size(214, 355);
            this.listBoxCube.TabIndex = 13;
            this.listBoxCube.SelectedIndexChanged += new System.EventHandler(this.listBoxCube_SelectedIndexChanged);
            // 
            // tabPageL8
            // 
            this.tabPageL8.Controls.Add(this.groupBox1);
            this.tabPageL8.Controls.Add(this.dataGridViewReport);
            this.tabPageL8.Controls.Add(this.label11);
            this.tabPageL8.Controls.Add(this.label10);
            this.tabPageL8.Controls.Add(this.buttonReportConn8);
            this.tabPageL8.Controls.Add(this.label9);
            this.tabPageL8.Controls.Add(this.dateTimePickerEnd);
            this.tabPageL8.Controls.Add(this.label5);
            this.tabPageL8.Controls.Add(this.dateTimePickerBegin);
            this.tabPageL8.Controls.Add(this.comboBoxSelectReport);
            this.tabPageL8.Controls.Add(this.comboBoxSelectFilter);
            this.tabPageL8.Controls.Add(this.labelFilter);
            this.tabPageL8.Location = new System.Drawing.Point(4, 22);
            this.tabPageL8.Name = "tabPageL8";
            this.tabPageL8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageL8.Size = new System.Drawing.Size(771, 458);
            this.tabPageL8.TabIndex = 1;
            this.tabPageL8.Text = "Лаба 8";
            this.tabPageL8.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBase8);
            this.groupBox1.Controls.Add(this.textBoxServer8);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(6, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 82);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройки подключения";
            // 
            // textBoxBase8
            // 
            this.textBoxBase8.Location = new System.Drawing.Point(84, 50);
            this.textBoxBase8.Name = "textBoxBase8";
            this.textBoxBase8.Size = new System.Drawing.Size(127, 20);
            this.textBoxBase8.TabIndex = 27;
            this.textBoxBase8.Text = "NavigTr5";
            // 
            // textBoxServer8
            // 
            this.textBoxServer8.Location = new System.Drawing.Point(84, 19);
            this.textBoxServer8.Name = "textBoxServer8";
            this.textBoxServer8.Size = new System.Drawing.Size(127, 20);
            this.textBoxServer8.TabIndex = 26;
            this.textBoxServer8.Text = "localhost";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Сервер";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 53);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "База данных";
            // 
            // dataGridViewReport
            // 
            this.dataGridViewReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReport.Location = new System.Drawing.Point(10, 123);
            this.dataGridViewReport.Name = "dataGridViewReport";
            this.dataGridViewReport.Size = new System.Drawing.Size(755, 329);
            this.dataGridViewReport.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Отчет";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Дата конца";
            // 
            // buttonReportConn8
            // 
            this.buttonReportConn8.Enabled = false;
            this.buttonReportConn8.Location = new System.Drawing.Point(647, 94);
            this.buttonReportConn8.Name = "buttonReportConn8";
            this.buttonReportConn8.Size = new System.Drawing.Size(118, 23);
            this.buttonReportConn8.TabIndex = 9;
            this.buttonReportConn8.Text = "Сформирвать отчет";
            this.buttonReportConn8.UseVisualStyleBackColor = true;
            this.buttonReportConn8.Click += new System.EventHandler(this.buttonReportConn8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(488, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Дата начала";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(565, 54);
            this.dateTimePickerEnd.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEnd.TabIndex = 20;
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Location = new System.Drawing.Point(565, 23);
            this.dateTimePickerBegin.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBegin.TabIndex = 19;
            // 
            // comboBoxSelectReport
            // 
            this.comboBoxSelectReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectReport.FormattingEnabled = true;
            this.comboBoxSelectReport.Items.AddRange(new object[] {
            "Количество проверенного транспорта",
            "Количество проданного товара"});
            this.comboBoxSelectReport.Location = new System.Drawing.Point(293, 19);
            this.comboBoxSelectReport.Name = "comboBoxSelectReport";
            this.comboBoxSelectReport.Size = new System.Drawing.Size(189, 21);
            this.comboBoxSelectReport.TabIndex = 11;
            this.comboBoxSelectReport.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectReport_SelectedIndexChanged);
            // 
            // comboBoxSelectFilter
            // 
            this.comboBoxSelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectFilter.FormattingEnabled = true;
            this.comboBoxSelectFilter.Location = new System.Drawing.Point(293, 51);
            this.comboBoxSelectFilter.Name = "comboBoxSelectFilter";
            this.comboBoxSelectFilter.Size = new System.Drawing.Size(189, 21);
            this.comboBoxSelectFilter.TabIndex = 12;
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 499);
            this.Controls.Add(this.tabControlL78);
            this.MinimumSize = new System.Drawing.Size(814, 538);
            this.Name = "FormClient";
            this.Text = "Клиент";
            this.tabControlL78.ResumeLayout(false);
            this.tabPageL7.ResumeLayout(false);
            this.tabPageL7.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageL8.ResumeLayout(false);
            this.tabPageL8.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelFilter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControlL78;
        private System.Windows.Forms.TabPage tabPageL7;
        private System.Windows.Forms.Button buttonConnect7;
        private System.Windows.Forms.TextBox textBoxServer7;
        private System.Windows.Forms.ComboBox comboBoxBase;
        private System.Windows.Forms.Button buttonBaseConnect7;
        private System.Windows.Forms.Label CubeUpdate;
        private System.Windows.Forms.ListBox listBoxDim;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonProcessing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listBoxCube;
        private System.Windows.Forms.TabPage tabPageL8;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxServer8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonReportConn8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.ComboBox comboBoxSelectReport;
        private System.Windows.Forms.ComboBox comboBoxSelectFilter;
        private System.Windows.Forms.TextBox textBoxBase8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.AnalysisServices.ErrorConfiguration errorConfiguration1;
    }
}

