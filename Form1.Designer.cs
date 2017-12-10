namespace Moorhuhn_Klon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pB_leopard1 = new System.Windows.Forms.PictureBox();
            this.pB_leopard2 = new System.Windows.Forms.PictureBox();
            this.pB_leopard3 = new System.Windows.Forms.PictureBox();
            this.labelPoints = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard3)).BeginInit();
            this.SuspendLayout();
            // 
            // pB_leopard1
            // 
            this.pB_leopard1.BackColor = System.Drawing.Color.Transparent;
            this.pB_leopard1.Image = ((System.Drawing.Image)(resources.GetObject("pB_leopard1.Image")));
            this.pB_leopard1.Location = new System.Drawing.Point(12, 646);
            this.pB_leopard1.Margin = new System.Windows.Forms.Padding(0);
            this.pB_leopard1.Name = "pB_leopard1";
            this.pB_leopard1.Size = new System.Drawing.Size(130, 58);
            this.pB_leopard1.TabIndex = 0;
            this.pB_leopard1.TabStop = false;
            this.pB_leopard1.Click += new System.EventHandler(this.hitLeopard);
            // 
            // pB_leopard2
            // 
            this.pB_leopard2.BackColor = System.Drawing.Color.Transparent;
            this.pB_leopard2.Image = ((System.Drawing.Image)(resources.GetObject("pB_leopard2.Image")));
            this.pB_leopard2.Location = new System.Drawing.Point(143, 725);
            this.pB_leopard2.Name = "pB_leopard2";
            this.pB_leopard2.Size = new System.Drawing.Size(133, 50);
            this.pB_leopard2.TabIndex = 2;
            this.pB_leopard2.TabStop = false;
            this.pB_leopard2.Click += new System.EventHandler(this.hitLeopard2);
            // 
            // pB_leopard3
            // 
            this.pB_leopard3.BackColor = System.Drawing.Color.Transparent;
            this.pB_leopard3.Image = ((System.Drawing.Image)(resources.GetObject("pB_leopard3.Image")));
            this.pB_leopard3.Location = new System.Drawing.Point(286, 786);
            this.pB_leopard3.Name = "pB_leopard3";
            this.pB_leopard3.Size = new System.Drawing.Size(130, 50);
            this.pB_leopard3.TabIndex = 3;
            this.pB_leopard3.TabStop = false;
            this.pB_leopard3.Click += new System.EventHandler(this.hitLeopard3);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.labelPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoints.Location = new System.Drawing.Point(1323, 43);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(0, 20);
            this.labelPoints.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1445, 899);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.pB_leopard3);
            this.Controls.Add(this.pB_leopard2);
            this.Controls.Add(this.pB_leopard1);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pB_leopard3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pB_leopard1;
        private System.Windows.Forms.PictureBox pB_leopard2;
        private System.Windows.Forms.PictureBox pB_leopard3;
        private System.Windows.Forms.Label labelPoints;
    }
}

