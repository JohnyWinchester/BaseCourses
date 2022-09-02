namespace DZ0801MatveewAndrey
{
    partial class DoublerForm
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
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.AmountCommandsOutput = new System.Windows.Forms.Label();
            this.CommandsCounter = new System.Windows.Forms.Label();
            this.HiddenNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.Location = new System.Drawing.Point(379, 96);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+1";
            this.btnCommand1.UseVisualStyleBackColor = true;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(378, 190);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 1;
            this.btnCommand2.Text = "x2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(378, 303);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 2;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNumber.Location = new System.Drawing.Point(221, 63);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(26, 29);
            this.lblNumber.TabIndex = 3;
            this.lblNumber.Text = "0";
            this.lblNumber.Click += new System.EventHandler(this.lblNumber_Click);
            // 
            // AmountCommandsOutput
            // 
            this.AmountCommandsOutput.AutoSize = true;
            this.AmountCommandsOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.163636F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountCommandsOutput.Location = new System.Drawing.Point(73, 200);
            this.AmountCommandsOutput.Name = "AmountCommandsOutput";
            this.AmountCommandsOutput.Size = new System.Drawing.Size(16, 17);
            this.AmountCommandsOutput.TabIndex = 4;
            this.AmountCommandsOutput.Text = "0";
            this.AmountCommandsOutput.Click += new System.EventHandler(this.AmountCommandsOutput_Click);
            // 
            // CommandsCounter
            // 
            this.CommandsCounter.AutoSize = true;
            this.CommandsCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CommandsCounter.Location = new System.Drawing.Point(12, 166);
            this.CommandsCounter.Name = "CommandsCounter";
            this.CommandsCounter.Size = new System.Drawing.Size(174, 24);
            this.CommandsCounter.TabIndex = 5;
            this.CommandsCounter.Text = "CommandsCounter";
            // 
            // HiddenNumber
            // 
            this.HiddenNumber.AutoSize = true;
            this.HiddenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HiddenNumber.Location = new System.Drawing.Point(70, 348);
            this.HiddenNumber.Name = "HiddenNumber";
            this.HiddenNumber.Size = new System.Drawing.Size(97, 35);
            this.HiddenNumber.TabIndex = 6;
            this.HiddenNumber.Text = "label1";
            this.HiddenNumber.Click += new System.EventHandler(this.HiddenNumber_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-2, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Угадайте число:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(378, 405);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 484);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.HiddenNumber);
            this.Controls.Add(this.CommandsCounter);
            this.Controls.Add(this.AmountCommandsOutput);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label AmountCommandsOutput;
        private System.Windows.Forms.Label CommandsCounter;
        private System.Windows.Forms.Label HiddenNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
    }
}

