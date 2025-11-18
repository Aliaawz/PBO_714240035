namespace P6_1_714240035
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.vbButton = new System.Windows.Forms.Button();
            this.csButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(459, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which do you think is better, Visual Basic or C#";
            // 
            // button1
            // 
            this.vbButton.BackColor = System.Drawing.Color.White;
            this.vbButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.vbButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.vbButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vbButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.vbButton.Location = new System.Drawing.Point(134, 169);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(97, 36);
            this.vbButton.TabIndex = 1;
            this.vbButton.Text = "vbButton";
            this.vbButton.UseMnemonic = false;
            this.vbButton.UseVisualStyleBackColor = false;
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // csButton
            // 
            this.csButton.BackColor = System.Drawing.Color.White;
            this.csButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.csButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.csButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csButton.ForeColor = System.Drawing.Color.Red;
            this.csButton.Location = new System.Drawing.Point(362, 169);
            this.csButton.Name = "csButton";
            this.csButton.Size = new System.Drawing.Size(97, 36);
            this.csButton.TabIndex = 2;
            this.csButton.Text = "C#";
            this.csButton.UseMnemonic = false;
            this.csButton.UseVisualStyleBackColor = false;
            this.csButton.Click += new System.EventHandler(this.csButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.White;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.Black;
            this.closeButton.Location = new System.Drawing.Point(21, 314);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(97, 36);
            this.closeButton.TabIndex = 3;
            this.closeButton.Text = "Close";
            this.closeButton.UseMnemonic = false;
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(617, 362);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.csButton);
            this.Controls.Add(this.vbButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button csButton;
        private System.Windows.Forms.Button closeButton;
    }
}