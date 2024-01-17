namespace Architecture11ClinicDesctopWinForms
{
    partial class DataClients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonSaveData = new Button();
            textBoxDocument = new TextBox();
            textBoxSurname = new TextBox();
            textBoxFirstName = new TextBox();
            textBoxPatronymic = new TextBox();
            listViewDocument = new ListView();
            columnHeaderDocument = new ColumnHeader();
            listViewSurName = new ListView();
            columnHeaderSurName = new ColumnHeader();
            listViewFirstName = new ListView();
            columnHeaderFirstName = new ColumnHeader();
            listViewPatronymic = new ListView();
            columnHeaderPatronymic = new ColumnHeader();
            listViewBrithDay = new ListView();
            columnHeaderBrithDay = new ColumnHeader();
            dateTimePickerBrithDay = new DateTimePicker();
            SuspendLayout();
            // 
            // buttonSaveData
            // 
            buttonSaveData.Location = new Point(42, 198);
            buttonSaveData.Name = "buttonSaveData";
            buttonSaveData.Size = new Size(542, 43);
            buttonSaveData.TabIndex = 0;
            buttonSaveData.Text = "Сохранить";
            buttonSaveData.UseVisualStyleBackColor = true;
            buttonSaveData.Click += buttonSaveData_Click;
            // 
            // textBoxDocument
            // 
            textBoxDocument.Location = new Point(12, 116);
            textBoxDocument.Name = "textBoxDocument";
            textBoxDocument.Size = new Size(104, 27);
            textBoxDocument.TabIndex = 1;
            // 
            // textBoxSurname
            // 
            textBoxSurname.Location = new Point(122, 116);
            textBoxSurname.Name = "textBoxSurname";
            textBoxSurname.Size = new Size(112, 27);
            textBoxSurname.TabIndex = 2;
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(240, 116);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(113, 27);
            textBoxFirstName.TabIndex = 3;
            // 
            // textBoxPatronymic
            // 
            textBoxPatronymic.Location = new Point(359, 116);
            textBoxPatronymic.Name = "textBoxPatronymic";
            textBoxPatronymic.Size = new Size(111, 27);
            textBoxPatronymic.TabIndex = 4;
            // 
            // listViewDocument
            // 
            listViewDocument.Columns.AddRange(new ColumnHeader[] { columnHeaderDocument });
            listViewDocument.Location = new Point(12, 57);
            listViewDocument.Name = "listViewDocument";
            listViewDocument.Size = new Size(104, 36);
            listViewDocument.TabIndex = 5;
            listViewDocument.UseCompatibleStateImageBehavior = false;
            listViewDocument.View = View.Details;
            // 
            // columnHeaderDocument
            // 
            columnHeaderDocument.Text = "Документ";
            columnHeaderDocument.Width = 100;
            // 
            // listViewSurName
            // 
            listViewSurName.Columns.AddRange(new ColumnHeader[] { columnHeaderSurName });
            listViewSurName.Location = new Point(122, 57);
            listViewSurName.Name = "listViewSurName";
            listViewSurName.Size = new Size(112, 36);
            listViewSurName.TabIndex = 6;
            listViewSurName.UseCompatibleStateImageBehavior = false;
            listViewSurName.View = View.Details;
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "Фамилия";
            columnHeaderSurName.Width = 100;
            // 
            // listViewFirstName
            // 
            listViewFirstName.Columns.AddRange(new ColumnHeader[] { columnHeaderFirstName });
            listViewFirstName.Location = new Point(240, 57);
            listViewFirstName.Name = "listViewFirstName";
            listViewFirstName.Size = new Size(113, 36);
            listViewFirstName.TabIndex = 7;
            listViewFirstName.UseCompatibleStateImageBehavior = false;
            listViewFirstName.View = View.Details;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Имя";
            columnHeaderFirstName.Width = 100;
            // 
            // listViewPatronymic
            // 
            listViewPatronymic.Columns.AddRange(new ColumnHeader[] { columnHeaderPatronymic });
            listViewPatronymic.Location = new Point(359, 57);
            listViewPatronymic.Name = "listViewPatronymic";
            listViewPatronymic.Size = new Size(111, 36);
            listViewPatronymic.TabIndex = 8;
            listViewPatronymic.UseCompatibleStateImageBehavior = false;
            listViewPatronymic.View = View.Details;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Отчество";
            columnHeaderPatronymic.Width = 100;
            // 
            // listViewBrithDay
            // 
            listViewBrithDay.Columns.AddRange(new ColumnHeader[] { columnHeaderBrithDay });
            listViewBrithDay.Location = new Point(476, 57);
            listViewBrithDay.Name = "listViewBrithDay";
            listViewBrithDay.Size = new Size(144, 36);
            listViewBrithDay.TabIndex = 9;
            listViewBrithDay.UseCompatibleStateImageBehavior = false;
            listViewBrithDay.View = View.Details;
            // 
            // columnHeaderBrithDay
            // 
            columnHeaderBrithDay.Text = "День рождения";
            columnHeaderBrithDay.Width = 130;
            // 
            // dateTimePickerBrithDay
            // 
            dateTimePickerBrithDay.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBrithDay.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePickerBrithDay.Format = DateTimePickerFormat.Short;
            dateTimePickerBrithDay.Location = new Point(476, 114);
            dateTimePickerBrithDay.Name = "dateTimePickerBrithDay";
            dateTimePickerBrithDay.Size = new Size(144, 30);
            dateTimePickerBrithDay.TabIndex = 11;
            // 
            // DataClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(632, 253);
            Controls.Add(dateTimePickerBrithDay);
            Controls.Add(listViewBrithDay);
            Controls.Add(listViewPatronymic);
            Controls.Add(listViewFirstName);
            Controls.Add(listViewSurName);
            Controls.Add(listViewDocument);
            Controls.Add(textBoxPatronymic);
            Controls.Add(textBoxFirstName);
            Controls.Add(textBoxSurname);
            Controls.Add(textBoxDocument);
            Controls.Add(buttonSaveData);
            Name = "DataClients";
            Text = "Данные о клиенте";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSaveData;
        private TextBox textBoxDocument;
        private TextBox textBoxSurname;
        private TextBox textBoxFirstName;
        private TextBox textBoxPatronymic;
        private ListView listViewDocument;
        private ListView listViewSurName;
        private ListView listViewFirstName;
        private ListView listViewPatronymic;
        private ListView listViewBrithDay;
        private ColumnHeader columnHeaderDocument;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private ColumnHeader columnHeaderBrithDay;
        private DateTimePicker dateTimePickerBrithDay;
    }
}