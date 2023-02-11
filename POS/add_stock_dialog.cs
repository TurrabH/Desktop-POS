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
    public partial class add_stock_dialog : Form {
        public DialogResult result = DialogResult.Cancel;
        public add_stock_dialog() {
            InitializeComponent();
        }

        private void Ok_btn_Click(object sender, EventArgs e) {
            result = DialogResult.OK;
            this.Close();
        }
        public string get_stock_name() {
            return this.item_name_txt_box.Text;
        }

        public string get_quantity() {
            return this.item_quantity_up_down.Value.ToString();
        }

        public string get_price() {
            return this.item_price_up_down.Value.ToString();

        }
    }
}
