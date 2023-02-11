using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS {
    public delegate void add_bill(int item_count, string price_of_one_item);
    public partial class Order_item_design : Form {
        private int quantity;
        private Panel order_panel;
        private add_bill Add_Bill;
        public Order_item_design(string name, string notes, string price, Image image, int quantity, Panel order_panel,add_bill Add_Bill ) {
            InitializeComponent();
            this.name_lbl.Text = name;
            this.notes_lbl.Text = notes;
            this.price_lbl.Text = price;
            this.item_img_picture_box.Image = image;
            this.quantity = quantity;
            this.quantity_lbl.Text = quantity+"x";
            this.order_panel = order_panel;
            this.Add_Bill = Add_Bill;
        }

        public Panel get_order_item() {
            return this.main_pnl;
        }

        public string get_price() {
            return this.price_lbl.Text;
        }

        private void Add_quantity_btn_Click(object sender, EventArgs e) {
            this.quantity++;
            this.quantity_lbl.Text = this.quantity + "x";
            Add_Bill(1,this.price_lbl.Text);
        }

        public int get_quantity() {
            return this.quantity;
        }

        private void Remove_quantity_btn_Click(object sender, EventArgs e) {
            this.quantity--;
            Add_Bill(-1, this.price_lbl.Text);
            if (quantity == 0)
                order_panel.Controls.Remove(this.main_pnl);
            this.quantity_lbl.Text = this.quantity + "x";
        }
    }
}
