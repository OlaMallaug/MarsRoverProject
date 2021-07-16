
namespace MarsRoverProject
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
            this.labInput = new System.Windows.Forms.Label();
            this.labOutput = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.butCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labInput
            // 
            this.labInput.AutoSize = true;
            this.labInput.Location = new System.Drawing.Point(15, 9);
            this.labInput.Name = "labInput";
            this.labInput.Size = new System.Drawing.Size(31, 13);
            this.labInput.TabIndex = 0;
            this.labInput.Text = "Input";
            // 
            // labOutput
            // 
            this.labOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labOutput.AutoSize = true;
            this.labOutput.Location = new System.Drawing.Point(15, 148);
            this.labOutput.Name = "labOutput";
            this.labOutput.Size = new System.Drawing.Size(39, 13);
            this.labOutput.TabIndex = 1;
            this.labOutput.Text = "Output";
            // 
            // txtInput
            // 
            this.txtInput.AcceptsReturn = true;
            this.txtInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInput.Location = new System.Drawing.Point(12, 25);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(265, 108);
            this.txtInput.TabIndex = 1;
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.Location = new System.Drawing.Point(12, 165);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(265, 82);
            this.txtOutput.TabIndex = 2;
            // 
            // butCalculate
            // 
            this.butCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCalculate.Location = new System.Drawing.Point(202, 264);
            this.butCalculate.Name = "butCalculate";
            this.butCalculate.Size = new System.Drawing.Size(75, 21);
            this.butCalculate.TabIndex = 0;
            this.butCalculate.Text = "Calculate";
            this.butCalculate.UseVisualStyleBackColor = true;
            this.butCalculate.Click += new System.EventHandler(this.butCalculate_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.butCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 297);
            this.Controls.Add(this.butCalculate);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labOutput);
            this.Controls.Add(this.labInput);
            this.MinimumSize = new System.Drawing.Size(305, 336);
            this.Name = "MainForm";
            this.Text = "Mars Rovers";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labInput;
        private System.Windows.Forms.Label labOutput;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button butCalculate;
    }
}

