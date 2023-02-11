namespace POS {
    partial class add_stock_dialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_stock_dialog));
            this.file_name_lbl = new System.Windows.Forms.Label();
            this.item_name_txt_box = new System.Windows.Forms.TextBox();
            this.item_ingredients_lbl = new System.Windows.Forms.Label();
            this.item_price_lbl = new System.Windows.Forms.Label();
            this.item_name_lbl = new System.Windows.Forms.Label();
            this.item_quantity_up_down = new System.Windows.Forms.NumericUpDown();
            this.item_price_up_down = new System.Windows.Forms.NumericUpDown();
            this.ok_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity_up_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_price_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // file_name_lbl
            // 
            this.file_name_lbl.AutoEllipsis = true;
            this.file_name_lbl.ForeColor = System.Drawing.Color.White;
            this.file_name_lbl.Location = new System.Drawing.Point(288, 175);
            this.file_name_lbl.Name = "file_name_lbl";
            this.file_name_lbl.Size = new System.Drawing.Size(110, 23);
            this.file_name_lbl.TabIndex = 19;
            this.file_name_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // item_name_txt_box
            // 
            this.item_name_txt_box.Location = new System.Drawing.Point(181, 68);
            this.item_name_txt_box.Name = "item_name_txt_box";
            this.item_name_txt_box.Size = new System.Drawing.Size(217, 20);
            this.item_name_txt_box.TabIndex = 15;
            // 
            // item_ingredients_lbl
            // 
            this.item_ingredients_lbl.AutoSize = true;
            this.item_ingredients_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_ingredients_lbl.ForeColor = System.Drawing.Color.White;
            this.item_ingredients_lbl.Location = new System.Drawing.Point(72, 138);
            this.item_ingredients_lbl.Name = "item_ingredients_lbl";
            this.item_ingredients_lbl.Size = new System.Drawing.Size(81, 18);
            this.item_ingredients_lbl.TabIndex = 14;
            this.item_ingredients_lbl.Text = "Item Units";
            // 
            // item_price_lbl
            // 
            this.item_price_lbl.AutoSize = true;
            this.item_price_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_lbl.ForeColor = System.Drawing.Color.White;
            this.item_price_lbl.Location = new System.Drawing.Point(72, 104);
            this.item_price_lbl.Name = "item_price_lbl";
            this.item_price_lbl.Size = new System.Drawing.Size(76, 18);
            this.item_price_lbl.TabIndex = 12;
            this.item_price_lbl.Text = "Unit Price";
            // 
            // item_name_lbl
            // 
            this.item_name_lbl.AutoSize = true;
            this.item_name_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_name_lbl.ForeColor = System.Drawing.Color.White;
            this.item_name_lbl.Location = new System.Drawing.Point(72, 70);
            this.item_name_lbl.Name = "item_name_lbl";
            this.item_name_lbl.Size = new System.Drawing.Size(89, 18);
            this.item_name_lbl.TabIndex = 11;
            this.item_name_lbl.Text = "Item Name";
            // 
            // item_quantity_up_down
            // 
            this.item_quantity_up_down.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantity_up_down.Location = new System.Drawing.Point(181, 138);
            this.item_quantity_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_quantity_up_down.Name = "item_quantity_up_down";
            this.item_quantity_up_down.Size = new System.Drawing.Size(217, 22);
            this.item_quantity_up_down.TabIndex = 21;
            this.item_quantity_up_down.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // item_price_up_down
            // 
            this.item_price_up_down.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_price_up_down.Location = new System.Drawing.Point(181, 100);
            this.item_price_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.item_price_up_down.Name = "item_price_up_down";
            this.item_price_up_down.Size = new System.Drawing.Size(217, 22);
            this.item_price_up_down.TabIndex = 22;
            this.item_price_up_down.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.ok_btn.Location = new System.Drawing.Point(118, 190);
            this.ok_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(230, 25);
            this.ok_btn.TabIndex = 20;
            this.ok_btn.Text = "Ok";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // add_stock_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(472, 254);
            this.Controls.Add(this.item_price_up_down);
            this.Controls.Add(this.item_quantity_up_down);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.file_name_lbl);
            this.Controls.Add(this.item_name_txt_box);
            this.Controls.Add(this.item_ingredients_lbl);
            this.Controls.Add(this.item_price_lbl);
            this.Controls.Add(this.item_name_lbl);
            this.Name = "add_stock_dialog";
            this.Text = "Add Stock";
            ((System.ComponentModel.ISupportInitialize)(this.item_quantity_up_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item_price_up_down)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label file_name_lbl;
        private System.Windows.Forms.TextBox item_name_txt_box;
        private System.Windows.Forms.Label item_ingredients_lbl;
        private System.Windows.Forms.Label item_price_lbl;
        private System.Windows.Forms.Label item_name_lbl;
        private System.Windows.Forms.NumericUpDown item_quantity_up_down;
        private System.Windows.Forms.NumericUpDown item_price_up_down;
    }
}