namespace Architecture11ClinicDesctopWinForms
{
    partial class DeleteAllClients
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
            listViewDeleteAll = new ListView();
            columnHeaderDeleteAll = new ColumnHeader();
            buttonDeleteYes = new Button();
            buttonDeleteNo = new Button();
            SuspendLayout();
            // 
            // listViewDeleteAll
            // 
            listViewDeleteAll.Columns.AddRange(new ColumnHeader[] { columnHeaderDeleteAll });
            listViewDeleteAll.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDeleteAll.Location = new Point(26, 27);
            listViewDeleteAll.Name = "listViewDeleteAll";
            listViewDeleteAll.Size = new Size(277, 37);
            listViewDeleteAll.TabIndex = 0;
            listViewDeleteAll.UseCompatibleStateImageBehavior = false;
            listViewDeleteAll.View = View.Details;
            // 
            // columnHeaderDeleteAll
            // 
            columnHeaderDeleteAll.Text = "Вы точно хотите удалить все?";
            columnHeaderDeleteAll.Width = 260;
            // 
            // buttonDeleteYes
            // 
            buttonDeleteYes.BackColor = Color.Red;
            buttonDeleteYes.Location = new Point(26, 85);
            buttonDeleteYes.Name = "buttonDeleteYes";
            buttonDeleteYes.Size = new Size(78, 43);
            buttonDeleteYes.TabIndex = 1;
            buttonDeleteYes.Text = "Да!";
            buttonDeleteYes.UseVisualStyleBackColor = false;
            buttonDeleteYes.Click += buttonDeleteYes_Click;
            // 
            // buttonDeleteNo
            // 
            buttonDeleteNo.BackColor = Color.Lime;
            buttonDeleteNo.Location = new Point(225, 85);
            buttonDeleteNo.Name = "buttonDeleteNo";
            buttonDeleteNo.Size = new Size(78, 43);
            buttonDeleteNo.TabIndex = 2;
            buttonDeleteNo.Text = "Нет!";
            buttonDeleteNo.UseVisualStyleBackColor = false;
            buttonDeleteNo.Click += buttonDeleteNo_Click;
            // 
            // DeleteAllClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 153);
            Controls.Add(buttonDeleteNo);
            Controls.Add(buttonDeleteYes);
            Controls.Add(listViewDeleteAll);
            Name = "DeleteAllClients";
            Text = "Удаление всех данных";
            ResumeLayout(false);
        }

        #endregion

        private ListView listViewDeleteAll;
        private ColumnHeader columnHeaderDeleteAll;
        private Button buttonDeleteYes;
        private Button buttonDeleteNo;
    }
}