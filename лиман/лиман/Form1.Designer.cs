namespace лиман
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Линейный = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonCalculateClick = new System.Windows.Forms.Button();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.textBoxY2 = new System.Windows.Forms.TextBox();
            this.textBoxZ2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxResult2 = new System.Windows.Forms.TextBox();
            this.Разветвляющийся = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cRedColor = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonExp = new System.Windows.Forms.RadioButton();
            this.radioButtonSqr = new System.Windows.Forms.RadioButton();
            this.radioButtonCos = new System.Windows.Forms.RadioButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Линейный.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Разветвляющийся.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Линейный);
            this.tabControl1.Controls.Add(this.Разветвляющийся);
            this.tabControl1.Location = new System.Drawing.Point(310, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 426);
            this.tabControl1.TabIndex = 22;
            // 
            // Линейный
            // 
            this.Линейный.Controls.Add(this.pictureBox1);
            this.Линейный.Controls.Add(this.buttonCalculateClick);
            this.Линейный.Controls.Add(this.textBoxX2);
            this.Линейный.Controls.Add(this.textBoxY2);
            this.Линейный.Controls.Add(this.textBoxZ2);
            this.Линейный.Controls.Add(this.label1);
            this.Линейный.Controls.Add(this.label2);
            this.Линейный.Controls.Add(this.label3);
            this.Линейный.Controls.Add(this.textBoxResult2);
            this.Линейный.Location = new System.Drawing.Point(4, 22);
            this.Линейный.Name = "Линейный";
            this.Линейный.Padding = new System.Windows.Forms.Padding(3);
            this.Линейный.Size = new System.Drawing.Size(827, 400);
            this.Линейный.TabIndex = 0;
            this.Линейный.Text = "Линейный";
            this.Линейный.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 73);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // buttonCalculateClick
            // 
            this.buttonCalculateClick.Location = new System.Drawing.Point(290, 233);
            this.buttonCalculateClick.Name = "buttonCalculateClick";
            this.buttonCalculateClick.Size = new System.Drawing.Size(139, 31);
            this.buttonCalculateClick.TabIndex = 0;
            this.buttonCalculateClick.Text = "Вычислить";
            this.buttonCalculateClick.UseVisualStyleBackColor = true;
            this.buttonCalculateClick.Click += new System.EventHandler(this.buttonCalculateClick_Click);
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(170, 124);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(152, 20);
            this.textBoxX2.TabIndex = 2;
            // 
            // textBoxY2
            // 
            this.textBoxY2.Location = new System.Drawing.Point(170, 166);
            this.textBoxY2.Name = "textBoxY2";
            this.textBoxY2.Size = new System.Drawing.Size(152, 20);
            this.textBoxY2.TabIndex = 3;
            // 
            // textBoxZ2
            // 
            this.textBoxZ2.Location = new System.Drawing.Point(170, 203);
            this.textBoxZ2.Name = "textBoxZ2";
            this.textBoxZ2.Size = new System.Drawing.Size(152, 20);
            this.textBoxZ2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите значение X:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите значение Y:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите значение Z:";
            // 
            // textBoxResult2
            // 
            this.textBoxResult2.Location = new System.Drawing.Point(55, 233);
            this.textBoxResult2.Multiline = true;
            this.textBoxResult2.Name = "textBoxResult2";
            this.textBoxResult2.Size = new System.Drawing.Size(220, 121);
            this.textBoxResult2.TabIndex = 8;
            this.textBoxResult2.Text = "Результат:";
            // 
            // Разветвляющийся
            // 
            this.Разветвляющийся.Controls.Add(this.pictureBox2);
            this.Разветвляющийся.Controls.Add(this.cRedColor);
            this.Разветвляющийся.Controls.Add(this.button1);
            this.Разветвляющийся.Controls.Add(this.groupBox1);
            this.Разветвляющийся.Controls.Add(this.textBoxX);
            this.Разветвляющийся.Controls.Add(this.txtResult);
            this.Разветвляющийся.Controls.Add(this.textBoxY);
            this.Разветвляющийся.Controls.Add(this.label4);
            this.Разветвляющийся.Controls.Add(this.label6);
            this.Разветвляющийся.Controls.Add(this.label5);
            this.Разветвляющийся.Location = new System.Drawing.Point(4, 22);
            this.Разветвляющийся.Name = "Разветвляющийся";
            this.Разветвляющийся.Padding = new System.Windows.Forms.Padding(3);
            this.Разветвляющийся.Size = new System.Drawing.Size(827, 400);
            this.Разветвляющийся.TabIndex = 1;
            this.Разветвляющийся.Text = "Разветвляющийся";
            this.Разветвляющийся.UseVisualStyleBackColor = true;
            this.Разветвляющийся.Click += new System.EventHandler(this.Разветвляющийся_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(108, 69);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(295, 77);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // cRedColor
            // 
            this.cRedColor.AutoSize = true;
            this.cRedColor.Location = new System.Drawing.Point(108, 361);
            this.cRedColor.Name = "cRedColor";
            this.cRedColor.Size = new System.Drawing.Size(145, 17);
            this.cRedColor.TabIndex = 20;
            this.cRedColor.Text = "Ответ красным цветом";
            this.cRedColor.UseVisualStyleBackColor = true;
            this.cRedColor.CheckedChanged += new System.EventHandler(this.checkBoxRed_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(345, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 31);
            this.button1.TabIndex = 9;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonExp);
            this.groupBox1.Controls.Add(this.radioButtonSqr);
            this.groupBox1.Controls.Add(this.radioButtonCos);
            this.groupBox1.Location = new System.Drawing.Point(488, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 132);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор функции:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioButtonExp
            // 
            this.radioButtonExp.AutoSize = true;
            this.radioButtonExp.Location = new System.Drawing.Point(26, 75);
            this.radioButtonExp.Name = "radioButtonExp";
            this.radioButtonExp.Size = new System.Drawing.Size(53, 17);
            this.radioButtonExp.TabIndex = 20;
            this.radioButtonExp.TabStop = true;
            this.radioButtonExp.Text = "exp(x)";
            this.radioButtonExp.UseVisualStyleBackColor = true;
            // 
            // radioButtonSqr
            // 
            this.radioButtonSqr.AutoSize = true;
            this.radioButtonSqr.Location = new System.Drawing.Point(26, 52);
            this.radioButtonSqr.Name = "radioButtonSqr";
            this.radioButtonSqr.Size = new System.Drawing.Size(39, 17);
            this.radioButtonSqr.TabIndex = 19;
            this.radioButtonSqr.TabStop = true;
            this.radioButtonSqr.Text = "sqr";
            this.radioButtonSqr.UseVisualStyleBackColor = true;
            // 
            // radioButtonCos
            // 
            this.radioButtonCos.AutoSize = true;
            this.radioButtonCos.Location = new System.Drawing.Point(26, 29);
            this.radioButtonCos.Name = "radioButtonCos";
            this.radioButtonCos.Size = new System.Drawing.Size(53, 17);
            this.radioButtonCos.TabIndex = 18;
            this.radioButtonCos.TabStop = true;
            this.radioButtonCos.Text = "cos(x)";
            this.radioButtonCos.UseVisualStyleBackColor = true;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(223, 168);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(116, 20);
            this.textBoxX.TabIndex = 11;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(108, 247);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(231, 94);
            this.txtResult.TabIndex = 17;
            this.txtResult.Text = "Результат:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(223, 207);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(116, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 247);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Введите значение X:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Введите значение Y:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.Линейный.ResumeLayout(false);
            this.Линейный.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Разветвляющийся.ResumeLayout(false);
            this.Разветвляющийся.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Линейный;
        private System.Windows.Forms.Button buttonCalculateClick;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.TextBox textBoxY2;
        private System.Windows.Forms.TextBox textBoxZ2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxResult2;
        private System.Windows.Forms.TabPage Разветвляющийся;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox cRedColor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonExp;
        private System.Windows.Forms.RadioButton radioButtonSqr;
        private System.Windows.Forms.RadioButton radioButtonCos;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

