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
            this.button2 = new System.Windows.Forms.Button();
            this.txtParticalName = new System.Windows.Forms.TextBox();
            this.btnchangecata = new System.Windows.Forms.Button();
            this.chpassability = new System.Windows.Forms.CheckBox();
            this.chactivity = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nwidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nheight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nfactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scena)).BeginInit();
            this.SuspendLayout();
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(21, 135);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(120, 23);
            this.btncreate.TabIndex = 0;
            this.btncreate.Text = "Создать";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // nwidth
            // 
            this.nwidth.Location = new System.Drawing.Point(21, 57);
            this.nwidth.Maximum = new decimal(new int[] {
            47,
            0,
            0,
            0});
            this.nwidth.Minimum = new decimal(new int[] {
            1,
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
            this.nheight.Location = new System.Drawing.Point(21, 83);
            this.nheight.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nheight.Minimum = new decimal(new int[] {
            1,
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
            this.nfactor.Location = new System.Drawing.Point(21, 109);
            this.nfactor.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
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
            this.scena.Location = new System.Drawing.Point(21, 168);
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
            this.lwidth.Location = new System.Drawing.Point(159, 64);
            this.lwidth.Name = "lwidth";
            this.lwidth.Size = new System.Drawing.Size(46, 13);
            this.lwidth.TabIndex = 5;
            this.lwidth.Text = "Ширина";
            // 
            // lheight
            // 
            this.lheight.AutoSize = true;
            this.lheight.Location = new System.Drawing.Point(158, 90);
            this.lheight.Name = "lheight";
            this.lheight.Size = new System.Drawing.Size(45, 13);
            this.lheight.TabIndex = 6;
            this.lheight.Text = "Высота";
            // 
            // lfactor
            // 
            this.lfactor.AutoSize = true;
            this.lfactor.Location = new System.Drawing.Point(158, 116);
            this.lfactor.Name = "lfactor";
            this.lfactor.Size = new System.Drawing.Size(65, 13);
            this.lfactor.TabIndex = 7;
            this.lfactor.Text = "Множитель";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(253, 71);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnForward
            // 
            this.btnForward.Location = new System.Drawing.Point(360, 71);
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
            this.lblmessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblmessage.Location = new System.Drawing.Point(317, 12);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(51, 20);
            this.lblmessage.TabIndex = 10;
            this.lblmessage.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ListColors
            // 
            this.ListColors.FormattingEnabled = true;
            this.ListColors.Location = new System.Drawing.Point(993, 168);
            this.ListColors.Name = "ListColors";
            this.ListColors.Size = new System.Drawing.Size(169, 498);
            this.ListColors.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(906, 25);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtParticalName
            // 
            this.txtParticalName.Location = new System.Drawing.Point(21, 31);
            this.txtParticalName.Name = "txtParticalName";
            this.txtParticalName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParticalName.Size = new System.Drawing.Size(120, 20);
            this.txtParticalName.TabIndex = 14;
            // 
            // btnchangecata
            // 
            this.btnchangecata.Location = new System.Drawing.Point(253, 106);
            this.btnchangecata.Name = "btnchangecata";
            this.btnchangecata.Size = new System.Drawing.Size(182, 23);
            this.btnchangecata.TabIndex = 15;
            this.btnchangecata.Text = "Изменить значения";
            this.btnchangecata.UseVisualStyleBackColor = true;
            this.btnchangecata.Click += new System.EventHandler(this.btnchangecata_Click);
            // 
            // chpassability
            // 
            this.chpassability.AutoSize = true;
            this.chpassability.Location = new System.Drawing.Point(253, 48);
            this.chpassability.Name = "chpassability";
            this.chpassability.Size = new System.Drawing.Size(100, 17);
            this.chpassability.TabIndex = 16;
            this.chpassability.Text = "Проходимость";
            this.chpassability.UseVisualStyleBackColor = true;
            // 
            // chactivity
            // 
            this.chactivity.AutoSize = true;
            this.chactivity.Location = new System.Drawing.Point(360, 48);
            this.chactivity.Name = "chactivity";
            this.chactivity.Size = new System.Drawing.Size(85, 17);
            this.chactivity.TabIndex = 17;
            this.chactivity.Text = "Активность";
            this.chactivity.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Имя ячейки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 702);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chactivity);
            this.Controls.Add(this.chpassability);
            this.Controls.Add(this.btnchangecata);
            this.Controls.Add(this.txtParticalName);
            this.Controls.Add(this.button2);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtParticalName;
        private System.Windows.Forms.Button btnchangecata;
        private System.Windows.Forms.CheckBox chpassability;
        private System.Windows.Forms.CheckBox chactivity;
        private System.Windows.Forms.Label label1;
    }
}

