namespace Architecture11ClinicDesctopWinForms
{
    partial class DeleteAllClientsConfirmation
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
            components = new System.ComponentModel.Container();
            buttonDeleteNoConfirmation = new Button();
            buttonDeleteYesConfirmation = new Button();
            listViewDeleteAllСonfirmation = new ListView();
            columnHeaderDeleteAll = new ColumnHeader();
            timer10sec = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // buttonDeleteNoConfirmation
            // 
            buttonDeleteNoConfirmation.BackColor = Color.Lime;
            buttonDeleteNoConfirmation.Location = new Point(196, 84);
            buttonDeleteNoConfirmation.Name = "buttonDeleteNoConfirmation";
            buttonDeleteNoConfirmation.Size = new Size(124, 43);
            buttonDeleteNoConfirmation.TabIndex = 5;
            buttonDeleteNoConfirmation.Text = "Нет, я не хотел!";
            buttonDeleteNoConfirmation.UseVisualStyleBackColor = false;
            buttonDeleteNoConfirmation.Click += buttonDeleteNo_Click;
            // 
            // buttonDeleteYesConfirmation
            // 
            buttonDeleteYesConfirmation.BackColor = Color.Red;
            buttonDeleteYesConfirmation.Location = new Point(12, 84);
            buttonDeleteYesConfirmation.Name = "buttonDeleteYesConfirmation";
            buttonDeleteYesConfirmation.Size = new Size(124, 43);
            buttonDeleteYesConfirmation.TabIndex = 4;
            buttonDeleteYesConfirmation.Text = "Да, я уверен!";
            buttonDeleteYesConfirmation.UseVisualStyleBackColor = false;
            buttonDeleteYesConfirmation.Click += buttonDeleteYes_Click;
            // 
            // listViewDeleteAllСonfirmation
            // 
            listViewDeleteAllСonfirmation.Columns.AddRange(new ColumnHeader[] { columnHeaderDeleteAll });
            listViewDeleteAllСonfirmation.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            listViewDeleteAllСonfirmation.Location = new Point(12, 25);
            listViewDeleteAllСonfirmation.Name = "listViewDeleteAllСonfirmation";
            listViewDeleteAllСonfirmation.Size = new Size(308, 37);
            listViewDeleteAllСonfirmation.TabIndex = 3;
            listViewDeleteAllСonfirmation.UseCompatibleStateImageBehavior = false;
            listViewDeleteAllСonfirmation.View = View.Details;
            // 
            // columnHeaderDeleteAll
            // 
            columnHeaderDeleteAll.Text = "Вы уверены, что хотите удалить?";
            columnHeaderDeleteAll.Width = 300;
            // 
            // timer10sec
            // 
            timer10sec.Interval = 10000;
            timer10sec.Tick += timer10sec_Tick;
            // 
            // DeleteAllClientsConfirmation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 153);
            Controls.Add(buttonDeleteNoConfirmation);
            Controls.Add(buttonDeleteYesConfirmation);
            Controls.Add(listViewDeleteAllСonfirmation);
            Name = "DeleteAllClientsConfirmation";
            Text = "Подтверждение удаление";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDeleteNoConfirmation;
        private Button buttonDeleteYesConfirmation;
        private ListView listViewDeleteAllСonfirmation;
        private ColumnHeader columnHeaderDeleteAll;
        private System.Windows.Forms.Timer timer10sec;
    }
}