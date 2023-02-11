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
    public partial class create_order_item : Form {
        public DialogResult result = DialogResult.Cancel;
        public create_order_item(string item_name, string item_price, Image item_image) {
            InitializeComponent();
            this.item_name_lbl.Text = item_name;
            this.item_price_lbl.Text = item_price;
            this.item_image_picture_box.Image = item_image;
        }

        private void Ok_btn_Click(object sender, EventArgs e) {
            result = DialogResult.OK;
            this.Close();
        }
        public string get_notes() {
            return this.notes_txt_box.Text;
        }

        public int get_quantity() {
            return (int)this.quantity_input_num_up_down.Value;
        }
    }
}
