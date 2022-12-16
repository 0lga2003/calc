namespace Calk
{
    partial class CalcForm
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
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.digit1Button = new System.Windows.Forms.Button();
            this.digit2Button = new System.Windows.Forms.Button();
            this.digit3Button = new System.Windows.Forms.Button();
            this.digit4Button = new System.Windows.Forms.Button();
            this.digit5Button = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.digit9Button = new System.Windows.Forms.Button();
            this.digit0Button = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.digit6Button = new System.Windows.Forms.Button();
            this.digit7Button = new System.Windows.Forms.Button();
            this.digit8Button = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.dotButton = new System.Windows.Forms.Button();
            this.accumulatorLabel = new System.Windows.Forms.Label();
            this.tgButton = new System.Windows.Forms.Button();
            this.ctButton = new System.Windows.Forms.Button();
            this.cosButton = new System.Windows.Forms.Button();
            this.sinButton = new System.Windows.Forms.Button();
            this.PiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeComboBox
            // 
            this.modeComboBox.BackColor = System.Drawing.SystemColors.Menu;
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "обычный",
            "инженерный"});
            this.modeComboBox.Location = new System.Drawing.Point(18, 12);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(115, 21);
            this.modeComboBox.TabIndex = 0;
            this.modeComboBox.Text = "обычный";
            // 
            // digit1Button
            // 
            this.digit1Button.BackColor = System.Drawing.Color.White;
            this.digit1Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit1Button.Location = new System.Drawing.Point(96, 130);
            this.digit1Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit1Button.Name = "digit1Button";
            this.digit1Button.Size = new System.Drawing.Size(37, 37);
            this.digit1Button.TabIndex = 1;
            this.digit1Button.Text = "1";
            this.digit1Button.UseVisualStyleBackColor = false;
            this.digit1Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit2Button
            // 
            this.digit2Button.BackColor = System.Drawing.Color.White;
            this.digit2Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit2Button.Location = new System.Drawing.Point(149, 130);
            this.digit2Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit2Button.Name = "digit2Button";
            this.digit2Button.Size = new System.Drawing.Size(37, 37);
            this.digit2Button.TabIndex = 2;
            this.digit2Button.Text = "2";
            this.digit2Button.UseVisualStyleBackColor = false;
            this.digit2Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit3Button
            // 
            this.digit3Button.BackColor = System.Drawing.Color.White;
            this.digit3Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit3Button.Location = new System.Drawing.Point(202, 130);
            this.digit3Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit3Button.Name = "digit3Button";
            this.digit3Button.Size = new System.Drawing.Size(37, 37);
            this.digit3Button.TabIndex = 3;
            this.digit3Button.Text = "3";
            this.digit3Button.UseVisualStyleBackColor = false;
            this.digit3Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit4Button
            // 
            this.digit4Button.BackColor = System.Drawing.Color.White;
            this.digit4Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit4Button.Location = new System.Drawing.Point(96, 173);
            this.digit4Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit4Button.Name = "digit4Button";
            this.digit4Button.Size = new System.Drawing.Size(37, 37);
            this.digit4Button.TabIndex = 4;
            this.digit4Button.Text = "4";
            this.digit4Button.UseVisualStyleBackColor = false;
            this.digit4Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit5Button
            // 
            this.digit5Button.BackColor = System.Drawing.Color.White;
            this.digit5Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit5Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit5Button.Location = new System.Drawing.Point(149, 173);
            this.digit5Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit5Button.Name = "digit5Button";
            this.digit5Button.Size = new System.Drawing.Size(37, 37);
            this.digit5Button.TabIndex = 5;
            this.digit5Button.Text = "5";
            this.digit5Button.UseVisualStyleBackColor = false;
            this.digit5Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.BackColor = System.Drawing.Color.White;
            this.multiplyButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.multiplyButton.Location = new System.Drawing.Point(18, 131);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(37, 37);
            this.multiplyButton.TabIndex = 6;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = false;
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.White;
            this.minusButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.minusButton.Location = new System.Drawing.Point(18, 217);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(37, 37);
            this.minusButton.TabIndex = 7;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            // 
            // delButton
            // 
            this.delButton.BackColor = System.Drawing.Color.White;
            this.delButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delButton.Location = new System.Drawing.Point(202, 301);
            this.delButton.Margin = new System.Windows.Forms.Padding(2);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(37, 37);
            this.delButton.TabIndex = 8;
            this.delButton.Text = "del";
            this.delButton.UseVisualStyleBackColor = false;
            // 
            // digit9Button
            // 
            this.digit9Button.BackColor = System.Drawing.Color.White;
            this.digit9Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit9Button.Location = new System.Drawing.Point(202, 215);
            this.digit9Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit9Button.Name = "digit9Button";
            this.digit9Button.Size = new System.Drawing.Size(37, 37);
            this.digit9Button.TabIndex = 9;
            this.digit9Button.Text = "9";
            this.digit9Button.UseVisualStyleBackColor = false;
            this.digit9Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit0Button
            // 
            this.digit0Button.BackColor = System.Drawing.Color.White;
            this.digit0Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit0Button.Location = new System.Drawing.Point(149, 259);
            this.digit0Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit0Button.Name = "digit0Button";
            this.digit0Button.Size = new System.Drawing.Size(37, 37);
            this.digit0Button.TabIndex = 10;
            this.digit0Button.Text = "0";
            this.digit0Button.UseVisualStyleBackColor = false;
            this.digit0Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.White;
            this.plusButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.plusButton.Location = new System.Drawing.Point(18, 260);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(37, 37);
            this.plusButton.TabIndex = 12;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.White;
            this.calculateButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.calculateButton.Location = new System.Drawing.Point(96, 259);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(2);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(37, 37);
            this.calculateButton.TabIndex = 13;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // digit6Button
            // 
            this.digit6Button.BackColor = System.Drawing.Color.White;
            this.digit6Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit6Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit6Button.Location = new System.Drawing.Point(202, 173);
            this.digit6Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit6Button.Name = "digit6Button";
            this.digit6Button.Size = new System.Drawing.Size(37, 37);
            this.digit6Button.TabIndex = 16;
            this.digit6Button.Text = "6";
            this.digit6Button.UseVisualStyleBackColor = false;
            this.digit6Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit7Button
            // 
            this.digit7Button.BackColor = System.Drawing.Color.White;
            this.digit7Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit7Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit7Button.Location = new System.Drawing.Point(96, 216);
            this.digit7Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit7Button.Name = "digit7Button";
            this.digit7Button.Size = new System.Drawing.Size(37, 37);
            this.digit7Button.TabIndex = 17;
            this.digit7Button.Text = "7";
            this.digit7Button.UseVisualStyleBackColor = false;
            this.digit7Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // digit8Button
            // 
            this.digit8Button.BackColor = System.Drawing.Color.White;
            this.digit8Button.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8Button.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.digit8Button.Location = new System.Drawing.Point(149, 216);
            this.digit8Button.Margin = new System.Windows.Forms.Padding(2);
            this.digit8Button.Name = "digit8Button";
            this.digit8Button.Size = new System.Drawing.Size(37, 37);
            this.digit8Button.TabIndex = 18;
            this.digit8Button.Text = "8";
            this.digit8Button.UseVisualStyleBackColor = false;
            this.digit8Button.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.White;
            this.divideButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.divideButton.Location = new System.Drawing.Point(18, 174);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(37, 37);
            this.divideButton.TabIndex = 19;
            this.divideButton.Text = "/";
            this.divideButton.UseVisualStyleBackColor = false;
            // 
            // outTextBox
            // 
            this.outTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.outTextBox.Location = new System.Drawing.Point(18, 54);
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.ReadOnly = true;
            this.outTextBox.Size = new System.Drawing.Size(221, 20);
            this.outTextBox.TabIndex = 20;
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.Color.White;
            this.dotButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotButton.Location = new System.Drawing.Point(202, 258);
            this.dotButton.Margin = new System.Windows.Forms.Padding(2);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(37, 37);
            this.dotButton.TabIndex = 22;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.digitsButton_Click);
            // 
            // accumulatorLabel
            // 
            this.accumulatorLabel.AutoSize = true;
            this.accumulatorLabel.Location = new System.Drawing.Point(15, 89);
            this.accumulatorLabel.Name = "accumulatorLabel";
            this.accumulatorLabel.Size = new System.Drawing.Size(0, 13);
            this.accumulatorLabel.TabIndex = 25;
            // 
            // tgButton
            // 
            this.tgButton.BackColor = System.Drawing.Color.White;
            this.tgButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tgButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tgButton.Location = new System.Drawing.Point(149, 343);
            this.tgButton.Margin = new System.Windows.Forms.Padding(2);
            this.tgButton.Name = "tgButton";
            this.tgButton.Size = new System.Drawing.Size(37, 37);
            this.tgButton.TabIndex = 29;
            this.tgButton.Text = "tg";
            this.tgButton.UseVisualStyleBackColor = false;
            // 
            // ctButton
            // 
            this.ctButton.BackColor = System.Drawing.Color.White;
            this.ctButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ctButton.Location = new System.Drawing.Point(96, 345);
            this.ctButton.Margin = new System.Windows.Forms.Padding(2);
            this.ctButton.Name = "ctButton";
            this.ctButton.Size = new System.Drawing.Size(37, 37);
            this.ctButton.TabIndex = 28;
            this.ctButton.Text = "ctg";
            this.ctButton.UseVisualStyleBackColor = false;
            // 
            // cosButton
            // 
            this.cosButton.BackColor = System.Drawing.Color.White;
            this.cosButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cosButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cosButton.Location = new System.Drawing.Point(96, 302);
            this.cosButton.Margin = new System.Windows.Forms.Padding(2);
            this.cosButton.Name = "cosButton";
            this.cosButton.Size = new System.Drawing.Size(37, 37);
            this.cosButton.TabIndex = 27;
            this.cosButton.Text = "cos";
            this.cosButton.UseVisualStyleBackColor = false;
            // 
            // sinButton
            // 
            this.sinButton.BackColor = System.Drawing.Color.White;
            this.sinButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sinButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.sinButton.Location = new System.Drawing.Point(149, 300);
            this.sinButton.Margin = new System.Windows.Forms.Padding(2);
            this.sinButton.Name = "sinButton";
            this.sinButton.Size = new System.Drawing.Size(37, 37);
            this.sinButton.TabIndex = 26;
            this.sinButton.Text = "sin";
            this.sinButton.UseVisualStyleBackColor = false;
            // 
            // PiButton
            // 
            this.PiButton.BackColor = System.Drawing.Color.White;
            this.PiButton.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PiButton.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.PiButton.Location = new System.Drawing.Point(202, 343);
            this.PiButton.Name = "PiButton";
            this.PiButton.Size = new System.Drawing.Size(37, 37);
            this.PiButton.TabIndex = 30;
            this.PiButton.Text = "Pi";
            this.PiButton.UseVisualStyleBackColor = false;
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(266, 402);
            this.Controls.Add(this.PiButton);
            this.Controls.Add(this.tgButton);
            this.Controls.Add(this.ctButton);
            this.Controls.Add(this.cosButton);
            this.Controls.Add(this.sinButton);
            this.Controls.Add(this.accumulatorLabel);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.outTextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.digit8Button);
            this.Controls.Add(this.digit7Button);
            this.Controls.Add(this.digit6Button);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.digit0Button);
            this.Controls.Add(this.digit9Button);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.digit5Button);
            this.Controls.Add(this.digit4Button);
            this.Controls.Add(this.digit3Button);
            this.Controls.Add(this.digit2Button);
            this.Controls.Add(this.digit1Button);
            this.Controls.Add(this.modeComboBox);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(282, 441);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(282, 441);
            this.Name = "CalcForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox outTextBox;
        public System.Windows.Forms.Button dotButton;
        public System.Windows.Forms.Button digit1Button;
        public System.Windows.Forms.Button digit2Button;
        public System.Windows.Forms.Button digit3Button;
        public System.Windows.Forms.Button digit4Button;
        public System.Windows.Forms.Button digit5Button;
        public System.Windows.Forms.Button delButton;
        public System.Windows.Forms.Button digit9Button;
        public System.Windows.Forms.Button digit0Button;
        public System.Windows.Forms.Button calculateButton;
        public System.Windows.Forms.Button digit6Button;
        public System.Windows.Forms.Button digit7Button;
        public System.Windows.Forms.Button digit8Button;
        private System.Windows.Forms.Label accumulatorLabel;
        public System.Windows.Forms.Button tgButton;
        public System.Windows.Forms.Button ctButton;
        public System.Windows.Forms.Button cosButton;
        public System.Windows.Forms.Button sinButton;
        private System.Windows.Forms.Button PiButton;
    }
}

