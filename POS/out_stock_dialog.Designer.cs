namespace POS {
    partial class out_stock_dialog {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(out_stock_dialog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.out_item_quantity_up_down = new System.Windows.Forms.NumericUpDown();
            this.ok_btn = new System.Windows.Forms.Button();
            this.out_ingredients_lbl = new System.Windows.Forms.Label();
            this.in_item_quantity_up_down = new System.Windows.Forms.NumericUpDown();
            this.in_ingredients_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out_item_quantity_up_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_item_quantity_up_down)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.in_item_quantity_up_down);
            this.panel1.Controls.Add(this.in_ingredients_lbl);
            this.panel1.Controls.Add(this.out_item_quantity_up_down);
            this.panel1.Controls.Add(this.ok_btn);
            this.panel1.Controls.Add(this.out_ingredients_lbl);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 177);
            this.panel1.TabIndex = 0;
            // 
            // out_item_quantity_up_down
            // 
            this.out_item_quantity_up_down.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_item_quantity_up_down.Location = new System.Drawing.Point(147, 77);
            this.out_item_quantity_up_down.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.out_item_quantity_up_down.Name = "out_item_quantity_up_down";
            this.out_item_quantity_up_down.Size = new System.Drawing.Size(217, 22);
            this.out_item_quantity_up_down.TabIndex = 24;
            this.out_item_quantity_up_down.Value = new decimal(new int[] {
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
            this.ok_btn.Location = new System.Drawing.Point(80, 122);
            this.ok_btn.MaximumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.MinimumSize = new System.Drawing.Size(230, 25);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(230, 25);
            this.ok_btn.TabIndex = 23;
            this.ok_btn.Text = "Ok";
            this.ok_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok_btn.UseVisualStyleBackColor = false;
            this.ok_btn.Click += new System.EventHandler(this.Ok_btn_Click);
            // 
            // out_ingredients_lbl
            // 
            this.out_ingredients_lbl.AutoSize = true;
            this.out_ingredients_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.out_ingredients_lbl.ForeColor = System.Drawing.Color.White;
            this.out_ingredients_lbl.Location = new System.Drawing.Point(38, 77);
            this.out_ingredients_lbl.Name = "out_ingredients_lbl";
            this.out_ingredients_lbl.Size = new System.Drawing.Size(76, 18);
            this.out_ingredients_lbl.TabIndex = 22;
            this.out_ingredients_lbl.Text = "Out Units";
            // 
            // in_item_quantity_up_down
            // 
            this.in_item_quantity_up_down.Font = new System.Drawing.Font("Gilroy Light", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_item_quantity_up_down.Location = new System.Drawing.Point(147, 46);
            this.in_item_quantity_up_down.Name = "in_item_quantity_up_down";
            this.in_item_quantity_up_down.Size = new System.Drawing.Size(217, 22);
            this.in_item_quantity_up_down.TabIndex = 26;
            // 
            // in_ingredients_lbl
            // 
            this.in_ingredients_lbl.AutoSize = true;
            this.in_ingredients_lbl.Font = new System.Drawing.Font("Gilroy Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.in_ingredients_lbl.ForeColor = System.Drawing.Color.White;
            this.in_ingredients_lbl.Location = new System.Drawing.Point(38, 46);
            this.in_ingredients_lbl.Name = "in_ingredients_lbl";
            this.in_ingredients_lbl.Size = new System.Drawing.Size(61, 18);
            this.in_ingredients_lbl.TabIndex = 25;
            this.in_ingredients_lbl.Text = "In Units";
            // 
            // out_stock_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 177);
            this.Controls.Add(this.panel1);
            this.Name = "out_stock_dialog";
            this.Text = "Out Units";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.out_item_quantity_up_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.in_item_quantity_up_down)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown out_item_quantity_up_down;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Label out_ingredients_lbl;
        private System.Windows.Forms.NumericUpDown in_item_quantity_up_down;
        private System.Windows.Forms.Label in_ingredients_lbl;
    }
}