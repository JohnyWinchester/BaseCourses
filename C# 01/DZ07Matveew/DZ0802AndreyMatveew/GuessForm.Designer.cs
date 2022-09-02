namespace DZ0802AndreyMatveew
{
    partial class GuessForm
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
            this.guessLabel = new System.Windows.Forms.Label();
            this.helpLabel = new System.Windows.Forms.Label();
            this.tryTextLabel = new System.Windows.Forms.Label();
            this.tryLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guessLabel
            // 
            this.guessLabel.AutoSize = true;
            this.guessLabel.Font = new System.Drawing.Font("MS UI Gothic", 26.18182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessLabel.Location = new System.Drawing.Point(120, 76);
            this.guessLabel.Name = "guessLabel";
            this.guessLabel.Size = new System.Drawing.Size(602, 41);
            this.guessLabel.TabIndex = 0;
            this.guessLabel.Text = "Угадайте число !!!";
            this.guessLabel.Click += new System.EventHandler(this.guessLabel_Click);
            // 
            // helpLabel
            // 
            this.helpLabel.AutoSize = true;
            this.helpLabel.Font = new System.Drawing.Font("Microsoft YaHei", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.helpLabel.Location = new System.Drawing.Point(270, 313);
            this.helpLabel.Name = "helpLabel";
            this.helpLabel.Size = new System.Drawing.Size(0, 31);
            this.helpLabel.TabIndex = 1;
            this.helpLabel.Click += new System.EventHandler(this.helpLabel_Click);
            // 
            // tryTextLabel
            // 
            this.tryTextLabel.AutoSize = true;
            this.tryTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryTextLabel.Location = new System.Drawing.Point(26, 176);
            this.tryTextLabel.Name = "tryTextLabel";
            this.tryTextLabel.Size = new System.Drawing.Size(232, 25);
            this.tryTextLabel.TabIndex = 2;
            this.tryTextLabel.Text = "Число ваших попыток";
            // 
            // tryLabel
            // 
            this.tryLabel.AutoSize = true;
            this.tryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.74545F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tryLabel.Location = new System.Drawing.Point(123, 231);
            this.tryLabel.Name = "tryLabel";
            this.tryLabel.Size = new System.Drawing.Size(24, 25);
            this.tryLabel.TabIndex = 3;
            this.tryLabel.Text = "5";
            this.tryLabel.Click += new System.EventHandler(this.tryLabel_Click);
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tryLabel);
            this.Controls.Add(this.tryTextLabel);
            this.Controls.Add(this.helpLabel);
            this.Controls.Add(this.guessLabel);
            this.Name = "GuessForm";
            this.Text = "Угадайка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label guessLabel;
        private System.Windows.Forms.Label tryTextLabel;
        public System.Windows.Forms.Label tryLabel;
        public System.Windows.Forms.Label helpLabel;
    }
}

