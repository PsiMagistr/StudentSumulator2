namespace StudentSim
{
    partial class frm_simulator
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
            this.scena = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).BeginInit();
            this.SuspendLayout();
            // 
            // scena
            // 
            this.scena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scena.Location = new System.Drawing.Point(22, 31);
            this.scena.Name = "scena";
            this.scena.Size = new System.Drawing.Size(950, 507);
            this.scena.TabIndex = 5;
            this.scena.TabStop = false;
            // 
            // frm_simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 569);
            this.Controls.Add(this.scena);
            this.Name = "frm_simulator";
            this.Text = "Симулятор студента";
            ((System.ComponentModel.ISupportInitialize)(this.scena)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox scena;
    }
}

