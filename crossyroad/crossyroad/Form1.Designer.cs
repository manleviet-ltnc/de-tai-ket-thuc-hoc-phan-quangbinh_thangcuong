namespace crossyroad
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.pxbStreet = new System.Windows.Forms.PictureBox();
            this.pxbAuto = new System.Windows.Forms.PictureBox();
            this.pxbGarden = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pxbStreet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGarden)).BeginInit();
            this.SuspendLayout();
            // 
            // pxbStreet
            // 
            this.pxbStreet.Image = ((System.Drawing.Image)(resources.GetObject("pxbStreet.Image")));
            this.pxbStreet.Location = new System.Drawing.Point(0, 99);
            this.pxbStreet.Name = "pxbStreet";
            this.pxbStreet.Size = new System.Drawing.Size(652, 172);
            this.pxbStreet.TabIndex = 1;
            this.pxbStreet.TabStop = false;
            // 
            // pxbAuto
            // 
            this.pxbAuto.BackColor = System.Drawing.Color.GreenYellow;
            this.pxbAuto.InitialImage = global::crossyroad.Properties.Resources._131130hinh_nen_laptop_nhung_giot_nuoc_tinh_kiet_mau_xanh_la_cay;
            this.pxbAuto.Location = new System.Drawing.Point(0, 266);
            this.pxbAuto.Name = "pxbAuto";
            this.pxbAuto.Size = new System.Drawing.Size(652, 123);
            this.pxbAuto.TabIndex = 0;
            this.pxbAuto.TabStop = false;
            // 
            // pxbGarden
            // 
            this.pxbGarden.BackColor = System.Drawing.Color.GreenYellow;
            this.pxbGarden.Location = new System.Drawing.Point(0, 5);
            this.pxbGarden.Name = "pxbGarden";
            this.pxbGarden.Size = new System.Drawing.Size(643, 95);
            this.pxbGarden.TabIndex = 2;
            this.pxbGarden.TabStop = false;
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 388);
            this.Controls.Add(this.pxbGarden);
            this.Controls.Add(this.pxbStreet);
            this.Controls.Add(this.pxbAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmGame";
            this.Text = "Crossy Road";
            ((System.ComponentModel.ISupportInitialize)(this.pxbStreet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pxbGarden)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pxbAuto;
        private System.Windows.Forms.PictureBox pxbStreet;
        private System.Windows.Forms.PictureBox pxbGarden;
    }
}

