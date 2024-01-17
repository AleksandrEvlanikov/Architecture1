namespace ClinicDesctop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listView1 = new ListView();
            ClientId = new ColumnHeader();
            SurName = new ColumnHeader();
            FirstName = new ColumnHeader();
            Patronymic = new ColumnHeader();
            NumberDocument = new ColumnHeader();
            BrithDay = new ColumnHeader();
            buttonLoadCl = new Button();
            buttonDeleteOneId = new Button();
            buttonAdd = new Button();
            buttonDeleteAll = new Button();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BackgroundImage = Architecture11ClinicDesctopWinForms.Properties.Resources.istockphoto_453100595_612x612;
            listView1.Columns.AddRange(new ColumnHeader[] { ClientId, SurName, FirstName, Patronymic, NumberDocument, BrithDay });
            listView1.Cursor = Cursors.Hand;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(-2, 3);
            listView1.MultiSelect = false;
            listView1.Name = "listView1";
            listView1.Size = new Size(801, 262);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ClientId
            // 
            ClientId.Text = "#";
            // 
            // SurName
            // 
            SurName.DisplayIndex = 2;
            SurName.Text = "Фамилия";
            SurName.Width = 150;
            // 
            // FirstName
            // 
            FirstName.DisplayIndex = 3;
            FirstName.Text = "Имя";
            FirstName.Width = 110;
            // 
            // Patronymic
            // 
            Patronymic.DisplayIndex = 4;
            Patronymic.Text = "Отчество";
            Patronymic.Width = 140;
            // 
            // NumberDocument
            // 
            NumberDocument.DisplayIndex = 1;
            NumberDocument.Text = "Документы";
            NumberDocument.Width = 100;
            // 
            // BrithDay
            // 
            BrithDay.Text = "Дата рождения";
            BrithDay.Width = 230;
            // 
            // buttonLoadCl
            // 
            buttonLoadCl.BackColor = Color.ForestGreen;
            buttonLoadCl.ForeColor = SystemColors.Desktop;
            buttonLoadCl.Location = new Point(657, 280);
            buttonLoadCl.Name = "buttonLoadCl";
            buttonLoadCl.Size = new Size(122, 38);
            buttonLoadCl.TabIndex = 1;
            buttonLoadCl.Text = "Загрузить";
            buttonLoadCl.UseVisualStyleBackColor = false;
            buttonLoadCl.Click += buttonLoadCl_Click;
            // 
            // buttonDeleteOneId
            // 
            buttonDeleteOneId.BackColor = Color.Red;
            buttonDeleteOneId.Location = new Point(12, 280);
            buttonDeleteOneId.Name = "buttonDeleteOneId";
            buttonDeleteOneId.Size = new Size(118, 38);
            buttonDeleteOneId.TabIndex = 2;
            buttonDeleteOneId.Text = "Удалить";
            buttonDeleteOneId.UseVisualStyleBackColor = false;
            buttonDeleteOneId.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(192, 0, 192);
            buttonAdd.Location = new Point(334, 280);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(111, 37);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.BackColor = Color.Red;
            buttonDeleteAll.Location = new Point(155, 393);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(465, 45);
            buttonDeleteAll.TabIndex = 4;
            buttonDeleteAll.Text = "Удалить все";
            buttonDeleteAll.UseVisualStyleBackColor = false;
            buttonDeleteAll.Click += buttonDeleteAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Architecture11ClinicDesctopWinForms.Properties.Resources.istockphoto_453100595_612x612;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonDeleteAll);
            Controls.Add(buttonAdd);
            Controls.Add(buttonDeleteOneId);
            Controls.Add(buttonLoadCl);
            Controls.Add(listView1);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Form1";
            Text = "Приложение клиника";
            ResumeLayout(false);
        }

        #endregion

        private ListView listView1;
        private Button buttonLoadCl;
        private Button buttonDelete;
        private Button buttonAdd;
        private ColumnHeader Id;
        private ColumnHeader Имя;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader ClientId;
        private ColumnHeader SurName;
        private ColumnHeader FirstName;
        private ColumnHeader Patronymic;
        private ColumnHeader NumberDocument;
        private ColumnHeader BrithDay;
        private Button buttonDeleteOneId;
        private Button buttonDeleteAll;
    }
}
