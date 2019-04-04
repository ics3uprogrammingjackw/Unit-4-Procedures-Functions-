namespace TempConverterJackW
{
    partial class frmTempConverter
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
            this.lblStatement = new System.Windows.Forms.Label();
            this.txtCelsius = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStatement
            // 
            this.lblStatement.AutoSize = true;
            this.lblStatement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblStatement.Location = new System.Drawing.Point(12, 54);
            this.lblStatement.Name = "lblStatement";
            this.lblStatement.Size = new System.Drawing.Size(470, 20);
            this.lblStatement.TabIndex = 0;
            this.lblStatement.Text = "Enter a temperature in Celsius that you would like to be converted";
            // 
            // txtCelsius
            // 
            this.txtCelsius.Location = new System.Drawing.Point(488, 54);
            this.txtCelsius.Name = "txtCelsius";
            this.txtCelsius.Size = new System.Drawing.Size(100, 20);
            this.txtCelsius.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAnswer.Location = new System.Drawing.Point(251, 260);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(251, 20);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "The temperature in fahrenheit is: ?";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(273, 167);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmTempConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 423);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.txtCelsius);
            this.Controls.Add(this.lblStatement);
            this.Name = "frmTempConverter";
            this.Text = "Temp Converter by Jack W";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatement;
        private System.Windows.Forms.TextBox txtCelsius;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnCalculate;
    }
}

