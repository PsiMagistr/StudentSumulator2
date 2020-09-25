namespace CityEditor
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
            this.btncreate = new System.Windows.Forms.Button();
            this.nwidth = new System.Windows.Forms.NumericUpDown();
            this.nheight = new System.Windows.Forms.NumericUpDown();
            this.nfactor = new System.Windows.Forms.NumericUpDown();
            this.scena = new System.Windows.Forms.PictureBox();
            this.lwidth = new System.Windows.Forms.Label();
            this.lheight = new System.Windows.Forms.Label();
            this.lfactor = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnForward = new System.Windows.Forms.Button();
            this.lblmessage = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ListColors = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(429, 35);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Создать";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // nwidth
            // 
            this.nwidth.Location = new System.Drawing.Point(21, 28);
            this.nwidth.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nwidth.Name = "nwidth";
            this.nwidth.Size = new System.Drawing.Size(120, 20);
            this.nwidth.TabIndex = 1;
            this.nwidth.Value = new decimal(new int[] {
            47,
            0,
            0,
            0});
            // 
            // nheight
            // 
            this.nheight.Location = new System.Drawing.Point(21, 54);
            this.nheight.Minimum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nheight.Name = "nheight";
            this.nheight.Size = new System.Drawing.Size(120, 20);
            this.nheight.TabIndex = 2;
            this.nheight.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // nfactor
            // 
            this.nfactor.Location = new System.Drawing.Point(21, 80);
            this.nfactor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nfactor.Name = "nfactor";
            this.nfactor.Size = new System.Drawing.Size(120, 20);
            this.nfactor.TabIndex = 3;
            this.nfactor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // scena
            // 
            this.scena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scena.Location = new System.Drawing.Point(21, 106);
            this.scena.Name = "scena";
            this.scena.Size = new System.Drawing.Size(950, 507);
            this.scena.TabIndex = 4;
            this.scena.TabStop = false;
            this.scena.Paint += new System.Windows.Forms.PaintEventHandler(this.scena_Paint);
            this.scena.MouseDown += new System.Windows.Forms.MouseEventHandler(this.scena_MouseDown);
            this.scena.MouseMove += new System.Windows.Forms.MouseEventHandler(this.scena_MouseMove);
            this.scena.MouseUp += new System.Windows.Forms.MouseEventHandler(this.scena_MouseUp);
            // 
            // lwidth
            // 
            this.lwidth.AutoSize = true;
            this.lwidth.Location = new System.Drawing.Point(159, 35);
            this.lwidth.Name = "lwidth";
            this.lwidth.Size = new System.Drawing.Size(46, 13);
            this.lwidth.TabIndex = 5;
            this.lwidth.Text = "Ширина";
            // 
            // lheight
            // 
            this.lheight.AutoSize = true;
            this.lheight.Location = new System.Drawing.Point(158, 61);
            this.lheight.Name = "lheight";
            this.lheight.Size = new System.Drawing.Size(45, 13);
            this.lheight.TabIndex = 6;
            this.lheight.Text = "Высота";
            // 
            // lfactor
            // 
            this.lfactor.AutoSize = true;
            this.lfactor.Location = new System.Drawing.Point(158, 87);
            this.lfactor.Name = "lfactor";
            this.lfactor.Size = new System.Drawing.Size(65, 13);
            this.lfactor.TabIndex = 7;
            this.lfactor.Text = "Множитель";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(631, 50);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(745, 49);
            this.btnForward.Name = "btnForward";
            this.btnForward.Size = new System.Drawing.Size(75, 23);
            this.btnForward.TabIndex = 9;
            this.btnForward.Text = ">>";
            this.btnForward.UseVisualStyleBackColor = true;
            this.btnForward.Click += new System.EventHandler(this.btnForward_Click);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Location = new System.Drawing.Point(857, 56);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(35, 13);
            this.lblmessage.TabIndex = 10;
            this.lblmessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 71);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListColors
            // 
            this.ListColors.FormattingEnabled = true;
            this.ListColors.Location = new System.Drawing.Point(1002, 106);
            this.ListColors.Name = "ListColors";
            this.ListColors.Size = new System.Drawing.Size(120, 95);
            this.ListColors.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 648);
            this.Controls.Add(this.ListColors);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.btnForward);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lfactor);
            this.Controls.Add(this.lheight);
            this.Controls.Add(this.lwidth);
            this.Controls.Add(this.scena);
            this.Controls.Add(this.nfactor);
            this.Controls.Add(this.nheight);
            this.Controls.Add(this.nwidth);
            this.Controls.Add(this.btncreate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nwidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nheight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.NumericUpDown nwidth;
        private System.Windows.Forms.NumericUpDown nheight;
        private System.Windows.Forms.NumericUpDown nfactor;
        private System.Windows.Forms.PictureBox scena;
        private System.Windows.Forms.Label lwidth;
        private System.Windows.Forms.Label lheight;
        private System.Windows.Forms.Label lfactor;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnForward;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox ListColors;
    }
}

