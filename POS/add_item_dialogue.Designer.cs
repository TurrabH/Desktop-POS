namespace POS {
    partial class add_item_dialogue {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_item_dialogue));
            this.main_panel = new System.Windows.Forms.Panel();
            this.ok_btn = new System.Windows.Forms.Button();
            this.file_name_lbl = new System.Windows.Forms.Label();
            this.choose_file_btn = new System.Windows.Forms.Button();
            this.item_ingredients_txt_box = new System.Windows.Forms.TextBox();
            this.item_price_txt_box = new System.Windows.Forms.TextBox();
            this.item_name_txt_box = new System.Windows.Forms.TextBox();
            this.item_ingredients_lbl = new System.Windows.Forms.Label();
            this.item_image_lbl = new System.Windows.Forms.Label();
            this.item_price_lbl = new System.Windows.Forms.Label();
            this.item_name_lbl = new System.Windows.Forms.Label();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(41)))));
            this.main_panel.Controls.Add(this.ok_btn);
            this.main_panel.Controls.Add(this.file_name_lbl);
            this.main_panel.Controls.Add(this.choose_file_btn);
            this.main_panel.Controls.Add(this.item_ingredients_txt_box);
            this.main_panel.Controls.Add(this.item_price_txt_box);
            this.main_panel.Controls.Add(this.item_name_txt_box);
            this.main_panel.Controls.Add(this.item_ingredients_lbl);
            this.main_panel.Controls.Add(this.item_image_lbl);
            this.main_panel.Controls.Add(this.item_price_lbl);
            this.main_panel.Controls.Add(this.item_name_lbl);
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(0, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(472, 288);
            this.main_panel.TabIndex = 0;
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
            this.ok_btn.Location = new System.Drawing.Point(129, 231);
            this.ok_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(230, 25);
            this.ok_btn.TabIndex = 10;
            this.ok_btn.Text = "Ok";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.Add_remove_items_add_btn_Click);
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
            // choose_file_btn
            // 
            this.choose_file_btn.BackColor = System.Drawing.Color.White;
            this.choose_file_btn.FlatAppearance.BorderSize = 0;
            this.choose_file_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choose_file_btn.Font = new System.Drawing.Font("Gilroy Light", 8F);
            this.choose_file_btn.Location = new System.Drawing.Point(178, 181);
            this.choose_file_btn.Name = "choose_file_btn";
            this.choose_file_btn.Size = new System.Drawing.Size(101, 23);
            this.choose_file_btn.TabIndex = 7;
            this.choose_file_btn.Text = "Choose File";
            this.choose_file_btn.UseVisualStyleBackColor = false;
            this.choose_file_btn.Click += new System.EventHandler(this.Choose_file_btn_Click);
            // 
            // item_ingredients_txt_box
            // 
            this.item_ingredients_txt_box.Location = new System.Drawing.Point(178, 142);
            this.item_ingredients_txt_box.Name = "item_ingredients_txt_box";
            this.item_ingredients_txt_box.Size = new System.Drawing.Size(217, 20);
            this.item_ingredients_txt_box.TabIndex = 6;
            // 
            // item_price_txt_box
            // 
            this.item_price_txt_box.Location = new System.Drawing.Point(178, 108);
            this.item_price_txt_box.Name = "item_price_txt_box";
            this.item_price_txt_box.Size = new System.Drawing.Size(217, 20);
            this.item_price_txt_box.TabIndex = 5;
            // 
            // item_name_txt_box
            // 
            this.item_name_txt_box.Location = new System.Drawing.Point(178, 74);
            this.item_name_txt_box.Name = "item_name_txt_box";
            this.item_name_txt_box.Size = new System.Drawing.Size(217, 20);
            this.item_name_txt_box.TabIndex = 4;
            // 
            // item_ingredients_lbl
            // 
            this.item_ingredients_lbl.AutoSize = true;
            this.item_ingredients_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_ingredients_lbl.ForeColor = System.Drawing.Color.White;
            this.item_ingredients_lbl.Location = new System.Drawing.Point(69, 144);
            this.item_ingredients_lbl.Name = "item_ingredients_lbl";
            this.item_ingredients_lbl.Size = new System.Drawing.Size(89, 18);
            this.item_ingredients_lbl.TabIndex = 3;
            this.item_ingredients_lbl.Text = "Ingredients";
            // 
            // item_image_lbl
            // 
            this.item_image_lbl.AutoSize = true;
            this.item_image_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_image_lbl.ForeColor = System.Drawing.Color.White;
            this.item_image_lbl.Location = new System.Drawing.Point(69, 181);
            this.item_image_lbl.Name = "item_image_lbl";
            this.item_image_lbl.Size = new System.Drawing.Size(92, 18);
            this.item_image_lbl.TabIndex = 2;
            this.item_image_lbl.Text = "Item Image";
            // 
            // item_price_lbl
            // 
            this.item_price_lbl.AutoSize = true;
            this.item_price_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_lbl.ForeColor = System.Drawing.Color.White;
            this.item_price_lbl.Location = new System.Drawing.Point(69, 110);
            this.item_price_lbl.Name = "item_price_lbl";
            this.item_price_lbl.Size = new System.Drawing.Size(80, 18);
            this.item_price_lbl.TabIndex = 1;
            this.item_price_lbl.Text = "Item Price";
            // 
            // item_name_lbl
            // 
            this.item_name_lbl.AutoSize = true;
            this.item_name_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_lbl.ForeColor = System.Drawing.Color.White;
            this.item_name_lbl.Location = new System.Drawing.Point(69, 76);
            this.item_name_lbl.Name = "item_name_lbl";
            this.item_name_lbl.Size = new System.Drawing.Size(89, 18);
            this.item_name_lbl.TabIndex = 0;
            this.item_name_lbl.Text = "Item Name";
            // 
            // add_item_dialogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(472, 288);
            this.Controls.Add(this.main_panel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "add_item_dialogue";
            this.Text = "New Item";
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel main_panel;
        private System.Windows.Forms.Label item_price_lbl;
        private System.Windows.Forms.Label item_name_lbl;
        private System.Windows.Forms.TextBox item_name_txt_box;
        private System.Windows.Forms.Label item_ingredients_lbl;
        private System.Windows.Forms.Label item_image_lbl;
        private System.Windows.Forms.Label file_name_lbl;
        private System.Windows.Forms.Button choose_file_btn;
        private System.Windows.Forms.TextBox item_ingredients_txt_box;
        private System.Windows.Forms.TextBox item_price_txt_box;
        private System.Windows.Forms.Button ok_btn;
    }
}