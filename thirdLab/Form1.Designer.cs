namespace thirdLab
{
    partial class Form1
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
            this.btnRefill = new System.Windows.Forms.Button();
            this.btnGet = new System.Windows.Forms.Button();
            this.txtOut = new System.Windows.Forms.RichTextBox();
            this.txtInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnRefill
            // 
            this.btnRefill.Location = new System.Drawing.Point(118, 25);
            this.btnRefill.Name = "btnRefill";
            this.btnRefill.Size = new System.Drawing.Size(103, 23);
            this.btnRefill.TabIndex = 0;
            this.btnRefill.Text = "Перезаполнить";
            this.btnRefill.UseVisualStyleBackColor = true;
            this.btnRefill.Click += new System.EventHandler(this.btnRefill_Click);
            // 
            // btnGet
            // 
            this.btnGet.Location = new System.Drawing.Point(287, 116);
            this.btnGet.Name = "btnGet";
            this.btnGet.Size = new System.Drawing.Size(75, 81);
            this.btnGet.TabIndex = 1;
            this.btnGet.Text = "Получить";
            this.btnGet.UseVisualStyleBackColor = true;
            this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
            // 
            // txtOut
            // 
            this.txtOut.Location = new System.Drawing.Point(48, 95);
            this.txtOut.Name = "txtOut";
            this.txtOut.Size = new System.Drawing.Size(233, 127);
            this.txtOut.TabIndex = 2;
            this.txtOut.Text = "";
            // 
            // txtInfo
            // 
            this.txtInfo.BackColor = System.Drawing.SystemColors.Control;
            this.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInfo.Location = new System.Drawing.Point(75, 54);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(188, 35);
            this.txtInfo.TabIndex = 3;
            this.txtInfo.Text = "";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(468, 264);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtOut);
            this.Controls.Add(this.btnGet);
            this.Controls.Add(this.btnRefill);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.Button btnRefill;
        private System.Windows.Forms.Button btnGet;
        private System.Windows.Forms.RichTextBox txtOut;
        private System.Windows.Forms.RichTextBox txtInfo;
    }
}

