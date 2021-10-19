
namespace Hotel
{
    partial class Form2
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
            this.header1 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.TextBox();
            this.header2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // header1
            // 
            this.header1.AutoSize = true;
            this.header1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header1.Location = new System.Drawing.Point(12, 9);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(295, 51);
            this.header1.TabIndex = 1;
            this.header1.Text = "Hotel Barbosa";
            this.header1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // info
            // 
            this.info.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.info.Location = new System.Drawing.Point(12, 123);
            this.info.Multiline = true;
            this.info.Name = "info";
            this.info.ReadOnly = true;
            this.info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.info.ShortcutsEnabled = false;
            this.info.Size = new System.Drawing.Size(284, 315);
            this.info.TabIndex = 3;
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header2.Location = new System.Drawing.Point(53, 71);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(192, 37);
            this.header2.TabIndex = 2;
            this.header2.Text = "Free Rooms";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 450);
            this.Controls.Add(this.info);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.header1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header1;
        private System.Windows.Forms.TextBox info;
        private System.Windows.Forms.Label header2;
    }
}