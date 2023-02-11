using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS {
    public class Item {
        private bool checked_;
        private string name;
        private float price;
        private string ingredients;
        private Image image;
        public Item(string name, float price, string ingredients, string image_path) {
            this.checked_ = false;
            this.name = name;
            this.price = price;
            this.ingredients = ingredients;
            this.image = Image.FromFile(image_path);
        }
        public Item(string name, float price, string ingredients, Image image) {
            this.checked_ = false;
            this.name = name;
            this.price = price;
            this.ingredients = ingredients;
            this.image = image;
        }
        public string get_name() {
            return this.name;
        }
        public void set_name(string name) {
            this.name = name;
        }

        public float get_price() {
            return this.price;
        }
        public void set_price(int price) {
            this.price = price;
        }

        public string get_ingredients() {
            return this.ingredients;
        }
        public void set_ingredients(string ingredients) {
            this.ingredients = ingredients;
        }

        public Image get_image() {
            return this.image;
        }
        public void set_image_path(string image_path) {
            this.image = Image.FromFile(image_path);
        }

        public void set_checked(bool checked_) {
            this.checked_ = checked_;
        }

        public bool get_checked() {
            return this.checked_;
        }
    }
}
