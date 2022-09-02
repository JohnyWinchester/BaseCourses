namespace DZ0802AndreyMatveew
{
    partial class InputTextForm
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25455F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputTextBox.Location = new System.Drawing.Point(94, 82);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(179, 46);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textLabel.Location = new System.Drawing.Point(27, 24);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(302, 37);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Введите ваше число";
            // 
            // inputButton
            // 
            this.inputButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputButton.Location = new System.Drawing.Point(116, 155);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(136, 48);
            this.inputButton.TabIndex = 2;
            this.inputButton.Text = "Тыкай сюда";
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButton_Click);
            // 
            // InputTextForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 228);
            this.Controls.Add(this.inputButton);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.inputTextBox);
            this.Name = "InputTextForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Введи число !!!";
            this.Load += new System.EventHandler(this.InputTextForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Button inputButton;
    }
}