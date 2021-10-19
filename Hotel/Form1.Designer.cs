
namespace Hotel
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
            this.header = new System.Windows.Forms.Label();
            this.bfree = new System.Windows.Forms.Button();
            this.bclear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bmake = new System.Windows.Forms.Button();
            this.bmanual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(14, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(295, 51);
            this.header.TabIndex = 0;
            this.header.Text = "Hotel Barbosa";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bfree
            // 
            this.bfree.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bfree.Location = new System.Drawing.Point(12, 79);
            this.bfree.Name = "bfree";
            this.bfree.Size = new System.Drawing.Size(286, 64);
            this.bfree.TabIndex = 1;
            this.bfree.Text = "Free Rooms";
            this.bfree.UseVisualStyleBackColor = true;
            this.bfree.Click += new System.EventHandler(this.bfree_Click);
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bclear.Location = new System.Drawing.Point(12, 289);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(286, 64);
            this.bclear.TabIndex = 3;
            this.bclear.Text = "Clear reservation";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Have a nice shift!";
            // 
            // bmake
            // 
            this.bmake.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmake.Location = new System.Drawing.Point(12, 149);
            this.bmake.Name = "bmake";
            this.bmake.Size = new System.Drawing.Size(286, 64);
            this.bmake.TabIndex = 2;
            this.bmake.Text = "Make reservation";
            this.bmake.UseVisualStyleBackColor = true;
            this.bmake.Click += new System.EventHandler(this.bmake_Click);
            // 
            // bmanual
            // 
            this.bmanual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bmanual.Location = new System.Drawing.Point(12, 219);
            this.bmanual.Name = "bmanual";
            this.bmanual.Size = new System.Drawing.Size(286, 64);
            this.bmanual.TabIndex = 5;
            this.bmanual.Text = "Manual making";
            this.bmanual.UseVisualStyleBackColor = true;
            this.bmanual.Click += new System.EventHandler(this.bmanual_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 450);
            this.Controls.Add(this.bmanual);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.bmake);
            this.Controls.Add(this.bfree);
            this.Controls.Add(this.header);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button bfree;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bmake;
        private System.Windows.Forms.Button bmanual;
    }
}

