namespace MatrixMultiplierForm
{
    partial class MainForm
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblInputMessage = new System.Windows.Forms.Label();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.lblOutputMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(26, 76);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(652, 20);
            this.txtInput.TabIndex = 0;
            // 
            // lblInputMessage
            // 
            this.lblInputMessage.AutoSize = true;
            this.lblInputMessage.Location = new System.Drawing.Point(26, 57);
            this.lblInputMessage.Name = "lblInputMessage";
            this.lblInputMessage.Size = new System.Drawing.Size(203, 13);
            this.lblInputMessage.TabIndex = 1;
            this.lblInputMessage.Text = "Enter path of XML file containing matrices";
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(26, 130);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(115, 50);
            this.btnMultiply.TabIndex = 2;
            this.btnMultiply.Text = "Multiply";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(26, 275);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(457, 297);
            this.txtOutput.TabIndex = 3;
            // 
            // lblOutputMessage
            // 
            this.lblOutputMessage.AutoSize = true;
            this.lblOutputMessage.Location = new System.Drawing.Point(23, 248);
            this.lblOutputMessage.Name = "lblOutputMessage";
            this.lblOutputMessage.Size = new System.Drawing.Size(39, 13);
            this.lblOutputMessage.TabIndex = 4;
            this.lblOutputMessage.Text = "Output";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 644);
            this.Controls.Add(this.lblOutputMessage);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.lblInputMessage);
            this.Controls.Add(this.txtInput);
            this.Name = "MainForm";
            this.Text = "MatrixMultiplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblInputMessage;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label lblOutputMessage;
    }
}

