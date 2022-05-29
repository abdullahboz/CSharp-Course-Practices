using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapProject1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Notlar
         * singlair response -- metotları ayırmamız gerekir.
         */

        private void Form1_Load(object sender, EventArgs e)
        {
            ListProducts();

            ListCategories();


        }
        private void ListProducts()
        {
            using (NorthwindContext context = new NorthwindContext())
            //using ile garbage collector'u beklemeden memoryden uçur diyoruz - performans amaçlı kullanılır.
            {
                dgwProduct.DataSource = context.Products.ToList();
                //Gridview'e veritabanımızdaki verileri yazdırıyoruz ve o ürünleri liste içine alıyoruz.
            }
        }
        private void ListCategories()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                cbxCategory.DataSource = context.Categories.ToList();
                //Her bir eleman bir category nesnesidir.
                cbxCategory.DisplayMember = "CategoryName";
                cbxCategory.ValueMember = "CategoryId";
                // CategoryName olarak gözükecektir ama değeri CategoryId'den alacaktır.

            }
        }
        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.CategoryId == categoryId).ToList();
                //burada ürünleri liste ama bu ürünlerden CategoryId'si parametre olarak verdiğim categoryId olsun ve onu listeye çevir diyoruz.
            }
        }
        private void ListProductByProductName(string key)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                dgwProduct.DataSource = context.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
                //Burada arama ifademizi içeren ürünleri listeliyoruz.
                //Aynı sql Server büyük küçük harf duyarsızdır ama oracle gibi başka database serverler için yukarıdaki gibi toLower ifadesini kullanıyoruz.
            }
        }
        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
                //elemanlar eklenirken hata veriyor bu nedenle böyle yapıyoruz.
                //catch'in içini boş bırakıyoruz biliyoruz böyle bir hata vereceğini.
                //kategoriye göre filtrelememizi yapmış oluyoruz.
            }
            catch
            {


            }

        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            string key = tbxSearch.Text;
            if (string.IsNullOrEmpty(key))
                //eğer key değeri null ya da boş ise tüm ürünleri getir diyoruz.           
                ListProducts();
            else
                ListProductByProductName(tbxSearch.Text);

        }
    }
}
