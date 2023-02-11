namespace POS {
    partial class Menu_item_design {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_item_design));
            this.main_pnl = new System.Windows.Forms.Panel();
            this.main_tbl_layout_pnl = new System.Windows.Forms.TableLayoutPanel();
            this.item_img_picture_box = new System.Windows.Forms.PictureBox();
            this.item_lbl = new System.Windows.Forms.Label();
            this.price_pnl = new System.Windows.Forms.Panel();
            this.price_lbl = new System.Windows.Forms.Label();
            this.main_pnl.SuspendLayout();
            this.main_tbl_layout_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_img_picture_box)).BeginInit();
            this.price_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_pnl
            // 
            this.main_pnl.Controls.Add(this.main_tbl_layout_pnl);
            this.main_pnl.Location = new System.Drawing.Point(39, 60);
            this.main_pnl.Margin = new System.Windows.Forms.Padding(3, 8, 8, 3);
            this.main_pnl.Name = "main_pnl";
            this.main_pnl.Size = new System.Drawing.Size(200, 228);
            this.main_pnl.TabIndex = 1;
            // 
            // main_tbl_layout_pnl
            // 
            this.main_tbl_layout_pnl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.main_tbl_layout_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.main_tbl_layout_pnl.ColumnCount = 1;
            this.main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_tbl_layout_pnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.main_tbl_layout_pnl.Controls.Add(this.item_img_picture_box, 0, 0);
            this.main_tbl_layout_pnl.Controls.Add(this.item_lbl, 0, 1);
            this.main_tbl_layout_pnl.Controls.Add(this.price_pnl, 0, 2);
            this.main_tbl_layout_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_tbl_layout_pnl.Location = new System.Drawing.Point(0, 0);
            this.main_tbl_layout_pnl.Name = "main_tbl_layout_pnl";
            this.main_tbl_layout_pnl.Padding = new System.Windows.Forms.Padding(10);
            this.main_tbl_layout_pnl.RowCount = 3;
            this.main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.95454F));
            this.main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04545F));
            this.main_tbl_layout_pnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.main_tbl_layout_pnl.Size = new System.Drawing.Size(200, 228);
            this.main_tbl_layout_pnl.TabIndex = 0;
            // 
            // item_img_picture_box
            // 
            this.item_img_picture_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.item_img_picture_box.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_img_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("item_img_picture_box.Image")));
            this.item_img_picture_box.Location = new System.Drawing.Point(13, 13);
            this.item_img_picture_box.Name = "item_img_picture_box";
            this.item_img_picture_box.Size = new System.Drawing.Size(174, 140);
            this.item_img_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.item_img_picture_box.TabIndex = 0;
            this.item_img_picture_box.TabStop = false;
            this.item_img_picture_box.Click += new System.EventHandler(this.Item_img_picture_box_Click);
            // 
            // item_lbl
            // 
            this.item_lbl.AutoSize = true;
            this.item_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.item_lbl.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_lbl.ForeColor = System.Drawing.Color.White;
            this.item_lbl.Location = new System.Drawing.Point(13, 156);
            this.item_lbl.Name = "item_lbl";
            this.item_lbl.Size = new System.Drawing.Size(174, 30);
            this.item_lbl.TabIndex = 1;
            this.item_lbl.Text = "Double Burger";
            this.item_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price_pnl
            // 
            this.price_pnl.Controls.Add(this.price_lbl);
            this.price_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_pnl.Location = new System.Drawing.Point(13, 189);
            this.price_pnl.Name = "price_pnl";
            this.price_pnl.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.price_pnl.Size = new System.Drawing.Size(174, 26);
            this.price_pnl.TabIndex = 2;
            // 
            // price_lbl
            // 
            this.price_lbl.AutoSize = true;
            this.price_lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.price_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.price_lbl.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.price_lbl.Location = new System.Drawing.Point(0, 5);
            this.price_lbl.Name = "price_lbl";
            this.price_lbl.Size = new System.Drawing.Size(68, 19);
            this.price_lbl.TabIndex = 0;
            this.price_lbl.Text = "20.00 Rs";
            this.price_lbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Menu_item_design
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 338);
            this.Controls.Add(this.main_pnl);
            this.Name = "Menu_item_design";
            this.Text = "Menu_item_design";
            this.main_pnl.ResumeLayout(false);
            this.main_tbl_layout_pnl.ResumeLayout(false);
            this.main_tbl_layout_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.item_img_picture_box)).EndInit();
            this.price_pnl.ResumeLayout(false);
            this.price_pnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_pnl;
        private System.Windows.Forms.TableLayoutPanel main_tbl_layout_pnl;
        private System.Windows.Forms.PictureBox item_img_picture_box;
        private System.Windows.Forms.Label item_lbl;
        private System.Windows.Forms.Panel price_pnl;
        private System.Windows.Forms.Label price_lbl;
    }
}