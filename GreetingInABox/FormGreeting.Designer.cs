namespace GreetingInABox
{
    partial class FormGreeting
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
            this.BtnDisplay = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnDisplay
            // 
            this.BtnDisplay.Location = new System.Drawing.Point(40, 53);
            this.BtnDisplay.Name = "BtnDisplay";
            this.BtnDisplay.Size = new System.Drawing.Size(197, 68);
            this.BtnDisplay.TabIndex = 0;
            this.BtnDisplay.Text = "Display Greeting";
            this.BtnDisplay.UseVisualStyleBackColor = true;
            this.BtnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TxtResult.Location = new System.Drawing.Point(277, 53);
            this.TxtResult.Margin = new System.Windows.Forms.Padding(4);
            this.TxtResult.Multiline = true;
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(775, 432);
            this.TxtResult.TabIndex = 1;
            // 
            // FormGreeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 545);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnDisplay);
            this.Name = "FormGreeting";
            this.Text = "Greeting In A Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDisplay;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

