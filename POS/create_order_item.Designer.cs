namespace POS {
    partial class create_order_item {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(create_order_item));
            this.main_panel = new System.Windows.Forms.Panel();
            this.quantity_input_num_up_down = new System.Windows.Forms.NumericUpDown();
            this.item_image_picture_box = new System.Windows.Forms.PictureBox();
            this.item_price_lbl = new System.Windows.Forms.Label();
            this.item_name_lbl = new System.Windows.Forms.Label();
            this.notes_txt_box = new System.Windows.Forms.RichTextBox();
            this.item_notes_lbl = new System.Windows.Forms.Label();
            this.ok_btn = new System.Windows.Forms.Button();
            this.file_name_lbl = new System.Windows.Forms.Label();
            this.item_quantity_lbl = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_input_num_up_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_image_picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.main_panel.Controls.Add(this.quantity_input_num_up_down);
            this.main_panel.Controls.Add(this.item_image_picture_box);
            this.main_panel.Controls.Add(this.item_price_lbl);
            this.main_panel.Controls.Add(this.item_name_lbl);
            this.main_panel.Controls.Add(this.notes_txt_box);
            this.main_panel.Controls.Add(this.item_notes_lbl);
            this.main_panel.Controls.Add(this.ok_btn);
            this.main_panel.Controls.Add(this.file_name_lbl);
            this.main_panel.Controls.Add(this.item_quantity_lbl);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(431, 415);
            this.main_panel.TabIndex = 1;
            // 
            // quantity_input_num_up_down
            // 
            this.quantity_input_num_up_down.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantity_input_num_up_down.Location = new System.Drawing.Point(148, 158);
            this.quantity_input_num_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.quantity_input_num_up_down.Name = "quantity_input_num_up_down";
            this.quantity_input_num_up_down.Size = new System.Drawing.Size(217, 22);
            this.quantity_input_num_up_down.TabIndex = 16;
            this.quantity_input_num_up_down.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // item_image_picture_box
            // 
            this.item_image_picture_box.Image = ((System.Drawing.Image)(resources.GetObject("item_image_picture_box.Image")));
            this.item_image_picture_box.Location = new System.Drawing.Point(36, 64);
            this.item_image_picture_box.Name = "item_image_picture_box";
            this.item_image_picture_box.Size = new System.Drawing.Size(72, 69);
            this.item_image_picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.item_image_picture_box.TabIndex = 15;
            this.item_image_picture_box.TabStop = false;
            // 
            // item_price_lbl
            // 
            this.item_price_lbl.AutoSize = true;
            this.item_price_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_lbl.ForeColor = System.Drawing.Color.White;
            this.item_price_lbl.Location = new System.Drawing.Point(114, 115);
            this.item_price_lbl.Name = "item_price_lbl";
            this.item_price_lbl.Size = new System.Drawing.Size(80, 18);
            this.item_price_lbl.TabIndex = 14;
            this.item_price_lbl.Text = "Item Price";
            // 
            // item_name_lbl
            // 
            this.item_name_lbl.AutoSize = true;
            this.item_name_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_lbl.ForeColor = System.Drawing.Color.White;
            this.item_name_lbl.Location = new System.Drawing.Point(114, 64);
            this.item_name_lbl.Name = "item_name_lbl";
            this.item_name_lbl.Size = new System.Drawing.Size(89, 18);
            this.item_name_lbl.TabIndex = 13;
            this.item_name_lbl.Text = "Item Name";
            // 
            // notes_txt_box
            // 
            this.notes_txt_box.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notes_txt_box.Location = new System.Drawing.Point(148, 194);
            this.notes_txt_box.Name = "notes_txt_box";
            this.notes_txt_box.Size = new System.Drawing.Size(217, 127);
            this.notes_txt_box.TabIndex = 12;
            this.notes_txt_box.Text = "";
            // 
            // item_notes_lbl
            // 
            this.item_notes_lbl.AutoSize = true;
            this.item_notes_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_notes_lbl.ForeColor = System.Drawing.Color.White;
            this.item_notes_lbl.Location = new System.Drawing.Point(39, 203);
            this.item_notes_lbl.Name = "item_notes_lbl";
            this.item_notes_lbl.Size = new System.Drawing.Size(88, 18);
            this.item_notes_lbl.TabIndex = 11;
            this.item_notes_lbl.Text = "Item Notes";
            // 
            // ok_btn
            // 
            this.ok_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ok_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ok_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(87)))), ((int)(((byte)(86)))));
            this.ok_btn.FlatAppearance.BorderSize = 0;
            this.ok_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok_btn.Font = new System.Drawing.Font("Gilroy ExtraBold", 10F, System.Drawing.FontStyle.Bold);
            this.ok_btn.ForeColor = System.Drawing.Color.White;
            this.ok_btn.Image = ((System.Drawing.Image)(resources.GetObject("ok_btn.Image")));
            this.ok_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ok_btn.Location = new System.Drawing.Point(95, 352);
            this.ok_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(230, 25);
            this.ok_btn.TabIndex = 10;
            this.ok_btn.Text = "Ok";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // file_name_lbl
            // 
            this.file_name_lbl.AutoEllipsis = true;
            this.file_name_lbl.ForeColor = System.Drawing.Color.White;
            this.file_name_lbl.Location = new System.Drawing.Point(285, 181);
            this.file_name_lbl.Name = "file_name_lbl";
            this.file_name_lbl.Size = new System.Drawing.Size(110, 23);
            this.file_name_lbl.TabIndex = 8;
            this.file_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // item_quantity_lbl
            // 
            this.item_quantity_lbl.AutoSize = true;
            this.item_quantity_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_lbl.ForeColor = System.Drawing.Color.White;
            this.item_quantity_lbl.Location = new System.Drawing.Point(33, 158);
            this.item_quantity_lbl.Name = "item_quantity_lbl";
            this.item_quantity_lbl.Size = new System.Drawing.Size(109, 18);
            this.item_quantity_lbl.TabIndex = 1;
            this.item_quantity_lbl.Text = "Item Quantity";
            // 
            // create_order_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 415);
            this.Controls.Add(this.main_panel);
            this.Name = "create_order_item";
            this.Text = "Add Item";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quantity_input_num_up_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_image_picture_box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label file_name_lbl;
        private System.Windows.Forms.Label item_quantity_lbl;
        private System.Windows.Forms.RichTextBox notes_txt_box;
        private System.Windows.Forms.Label item_notes_lbl;
        private System.Windows.Forms.NumericUpDown quantity_input_num_up_down;
        private System.Windows.Forms.PictureBox item_image_picture_box;
        private System.Windows.Forms.Label item_price_lbl;
        private System.Windows.Forms.Label item_name_lbl;
    }
}