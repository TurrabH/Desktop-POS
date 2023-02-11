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
    public partial class out_stock_dialog : Form {
        public DialogResult result = DialogResult.Cancel;

        public out_stock_dialog(string stock_name) {
            InitializeComponent();
            this.Text = stock_name;
        }

        private void Ok_btn_Click(object sender, EventArgs e) {
            result = DialogResult.OK;
            this.Close();
        }
        public string get_out_quantity() {
            return this.out_item_quantity_up_down.Value.ToString();
        }

        public string get_in_quantity() {
            return this.in_item_quantity_up_down.Value.ToString();
        }
    }
}
