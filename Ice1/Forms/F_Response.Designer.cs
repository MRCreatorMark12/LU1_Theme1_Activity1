namespace Ice1.Forms
{
    partial class F_Response
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
            this.tb_MyInput = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_MyInput
            // 
            this.tb_MyInput.Location = new System.Drawing.Point(249, 136);
            this.tb_MyInput.Name = "tb_MyInput";
            this.tb_MyInput.Size = new System.Drawing.Size(292, 22);
            this.tb_MyInput.TabIndex = 0;
            // 
            // btn_Submit
            // 
            this.btn_Submit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Submit.Location = new System.Drawing.Point(0, 394);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(800, 56);
            this.btn_Submit.TabIndex = 1;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // F_Response
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_MyInput);
            this.Name = "F_Response";
            this.Text = "F_Response";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_MyInput;
        private System.Windows.Forms.Button btn_Submit;
    }
}