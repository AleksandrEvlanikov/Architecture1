namespace Architecture11ClinicDesctopWinForms
{
    partial class DeleteOneClients
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
            buttonDeletOneIdClient = new Button();
            textBoxDeleteId = new TextBox();
            listViewIdOneDelete = new ListView();
            columnHeaderDeleteId = new ColumnHeader();
            SuspendLayout();
            // 
            // buttonDeletOneIdClient
            // 
            buttonDeletOneIdClient.BackColor = Color.Red;
            buttonDeletOneIdClient.ForeColor = SystemColors.ControlText;
            buttonDeletOneIdClient.Location = new Point(22, 142);
            buttonDeletOneIdClient.Name = "buttonDeletOneIdClient";
            buttonDeletOneIdClient.Size = new Size(288, 39);
            buttonDeletOneIdClient.TabIndex = 0;
            buttonDeletOneIdClient.Text = "Удалить";
            buttonDeletOneIdClient.UseVisualStyleBackColor = false;
            buttonDeletOneIdClient.Click += buttonDeletOneIdClient_Click;
            // 
            // textBoxDeleteId
            // 
            textBoxDeleteId.Location = new Point(96, 78);
            textBoxDeleteId.Multiline = true;
            textBoxDeleteId.Name = "textBoxDeleteId";
            textBoxDeleteId.Size = new Size(134, 33);
            textBoxDeleteId.TabIndex = 1;
            // 
            // listViewIdOneDelete
            // 
            listViewIdOneDelete.Columns.AddRange(new ColumnHeader[] { columnHeaderDeleteId });
            listViewIdOneDelete.Location = new Point(96, 30);
            listViewIdOneDelete.Name = "listViewIdOneDelete";
            listViewIdOneDelete.Size = new Size(134, 32);
            listViewIdOneDelete.TabIndex = 2;
            listViewIdOneDelete.UseCompatibleStateImageBehavior = false;
            listViewIdOneDelete.View = View.Details;
            // 
            // columnHeaderDeleteId
            // 
            columnHeaderDeleteId.Text = "ID для удаление";
            columnHeaderDeleteId.Width = 130;
            // 
            // DeleteOneClients
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 193);
            Controls.Add(listViewIdOneDelete);
            Controls.Add(textBoxDeleteId);
            Controls.Add(buttonDeletOneIdClient);
            Name = "DeleteOneClients";
            Text = "Удаление клиента";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonDeletOneIdClient;
        private TextBox textBoxDeleteId;
        private ListView listViewIdOneDelete;
        private ColumnHeader columnHeaderDeleteId;
    }
}