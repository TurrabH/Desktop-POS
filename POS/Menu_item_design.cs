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
    public partial class Menu_item_design : Form {
        Panel order_panel;
        add_bill Add_Bill;
        public Menu_item_design(Image item_image, string item_name, string price, string tag, Panel order_panel, add_bill Add_Bill) {
            InitializeComponent();
            this.item_img_picture_box.Image = item_image;
            this.item_lbl.Text = item_name;
            this.price_lbl.Text = price;
            this.order_panel = order_panel;
            set_click_to_all_controls(this.main_pnl);
            set_tag_to_all_controls(tag, this.main_pnl);
            this.Add_Bill = Add_Bill;
        }

        public Panel get_order_panel() {
            return this.main_pnl;
        }

        public void item_clicked(object sender, EventArgs e) {
            create_order_item order_item_ui = new create_order_item(this.item_lbl.Text, this.price_lbl.Text, this.item_img_picture_box.Image);
            order_item_ui.ShowDialog();
            if (order_item_ui.result == DialogResult.OK) {
                Order_item_design order_item_design = new Order_item_design(this.item_lbl.Text, order_item_ui.get_notes(), this.price_lbl.Text, this.item_img_picture_box.Image, order_item_ui.get_quantity(), this.order_panel, Add_Bill);
                Add_Bill(order_item_ui.get_quantity(), this.price_lbl.Text);
                this.order_panel.Controls.Add(order_item_design.get_order_item());
            }
        }

        private void Item_img_picture_box_Click(object sender, EventArgs e) {

        }

        private void remove_order_item_at(int index) {
            this.order_panel.Controls.RemoveAt(index);
        }

        private void set_click_to_all_controls(Control control_to_tag) {
            foreach (Control control in control_to_tag.Controls) {
                control.Click+=item_clicked;
                set_click_to_all_controls(control);
            }
        }

        private void set_tag_to_all_controls(string tag, Control control_to_tag) {
            foreach (Control control in control_to_tag.Controls) {
                control.Tag = tag;
                set_tag_to_all_controls(tag, control);
            }
        }
    }
}
