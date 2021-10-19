
namespace Hotel
{
    partial class Form5
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
            this.ldone = new System.Windows.Forms.Label();
            this.bclear = new System.Windows.Forms.Button();
            this.thour = new System.Windows.Forms.TextBox();
            this.lhour = new System.Windows.Forms.Label();
            this.tdate = new System.Windows.Forms.TextBox();
            this.troomlist = new System.Windows.Forms.TextBox();
            this.ldate = new System.Windows.Forms.Label();
            this.lrooms = new System.Windows.Forms.Label();
            this.header = new System.Windows.Forms.Label();
            this.header2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ldone
            // 
            this.ldone.AutoSize = true;
            this.ldone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ldone.Location = new System.Drawing.Point(60, 340);
            this.ldone.Name = "ldone";
            this.ldone.Size = new System.Drawing.Size(200, 24);
            this.ldone.TabIndex = 50;
            this.ldone.Text = "Reservation is cleared!";
            this.ldone.Visible = false;
            // 
            // bclear
            // 
            this.bclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bclear.Location = new System.Drawing.Point(115, 260);
            this.bclear.Name = "bclear";
            this.bclear.Size = new System.Drawing.Size(88, 55);
            this.bclear.TabIndex = 49;
            this.bclear.Text = "Clear";
            this.bclear.UseVisualStyleBackColor = true;
            this.bclear.Click += new System.EventHandler(this.bclear_Click);
            // 
            // thour
            // 
            this.thour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thour.Location = new System.Drawing.Point(136, 200);
            this.thour.Name = "thour";
            this.thour.Size = new System.Drawing.Size(100, 35);
            this.thour.TabIndex = 48;
            // 
            // lhour
            // 
            this.lhour.AutoSize = true;
            this.lhour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lhour.Location = new System.Drawing.Point(59, 200);
            this.lhour.Name = "lhour";
            this.lhour.Size = new System.Drawing.Size(71, 29);
            this.lhour.TabIndex = 47;
            this.lhour.Text = "Hour:";
            // 
            // tdate
            // 
            this.tdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tdate.Location = new System.Drawing.Point(136, 159);
            this.tdate.Name = "tdate";
            this.tdate.Size = new System.Drawing.Size(100, 35);
            this.tdate.TabIndex = 46;
            // 
            // troomlist
            // 
            this.troomlist.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.troomlist.Location = new System.Drawing.Point(136, 118);
            this.troomlist.Name = "troomlist";
            this.troomlist.Size = new System.Drawing.Size(136, 35);
            this.troomlist.TabIndex = 44;
            // 
            // ldate
            // 
            this.ldate.AutoSize = true;
            this.ldate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ldate.Location = new System.Drawing.Point(61, 159);
            this.ldate.Name = "ldate";
            this.ldate.Size = new System.Drawing.Size(69, 29);
            this.ldate.TabIndex = 41;
            this.ldate.Text = "Date:";
            // 
            // lrooms
            // 
            this.lrooms.AutoSize = true;
            this.lrooms.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lrooms.Location = new System.Drawing.Point(30, 118);
            this.lrooms.Name = "lrooms";
            this.lrooms.Size = new System.Drawing.Size(96, 29);
            this.lrooms.TabIndex = 39;
            this.lrooms.Text = "Rooms:";
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(295, 51);
            this.header.TabIndex = 36;
            this.header.Text = "Hotel Barbosa";
            this.header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // header2
            // 
            this.header2.AutoSize = true;
            this.header2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header2.Location = new System.Drawing.Point(50, 60);
            this.header2.Name = "header2";
            this.header2.Size = new System.Drawing.Size(221, 31);
            this.header2.TabIndex = 53;
            this.header2.Text = "Clear reservation";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.header2);
            this.Controls.Add(this.ldone);
            this.Controls.Add(this.bclear);
            this.Controls.Add(this.thour);
            this.Controls.Add(this.lhour);
            this.Controls.Add(this.tdate);
            this.Controls.Add(this.troomlist);
            this.Controls.Add(this.ldate);
            this.Controls.Add(this.lrooms);
            this.Controls.Add(this.header);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label ldone;
        private System.Windows.Forms.Button bclear;
        private System.Windows.Forms.TextBox thour;
        private System.Windows.Forms.Label lhour;
        private System.Windows.Forms.TextBox tdate;
        private System.Windows.Forms.TextBox troomlist;
        private System.Windows.Forms.Label ldate;
        private System.Windows.Forms.Label lrooms;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label header2;
    }
}