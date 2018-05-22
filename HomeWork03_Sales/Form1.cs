using HomeWork03_Sales.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork03_Sales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CalculateSales();
            CasulateProduct();
        }

        private void CasulateProduct()
        {
            var pt = from p in products
                     join t in salesSaleProducts
                     on p.Prodct equals t.Product
                     select new ProductTotal { Product = p.Prodct, ProductTotal1 = p.Price * t.ProductNumber };

            var ptt = (from h in pt
                       group h by new { h.Product } into hh
                       select new
                       {
                           hh.Key.Product,
                           Total = hh.Sum(s => s.ProductTotal1)
                       });

            dataGridView2.DataSource = ptt.ToList();

            var result2 = ptt.Max((x) => x.Total);
            var Bestproduct = ptt.Where((x) => x.Total == result2);
            foreach (var m in Bestproduct)
            {
                lb_product.Text = m.Product;
            }
        }

        private void CalculateSales()
        {
            var result = from p in products
                         join s in salesSaleProducts
                         on p.Prodct equals s.Product
                         select new SaleTotal { SaleTotal1 = s.ProductNumber * p.Price, Sales = s.SalesName };

            var pr = (from h in result
                      group h by new { h.Sales } into hh
                      select new
                      {
                          hh.Key.Sales,
                          Total = hh.Sum(s => s.SaleTotal1)
                      });

            dataGridView1.DataSource = pr.ToList();

            var n = pr.Max((x) => x.Total);
            var ss =pr.Where((x) => x.Total == n);
            foreach (var item in ss)
            {
                lb_sales.Text = item.Sales;
            }
        }

        private List<Product> products = new List<Product>()
        {
            new Product(){Prodct = "原子筆",Price=  12},
            new Product(){Prodct = "鉛筆",Price = 16},
            new Product(){Prodct = "橡皮擦",Price = 10},
            new Product(){Prodct = "直尺", Price = 14},
            new Product(){Prodct = "立可白",Price = 15}
        };

        private List<SalesSaleProduct> salesSaleProducts = new List<SalesSaleProduct>()
        {
            new SalesSaleProduct() {SalesName="Bill" , Product="原子筆" , ProductNumber=33 },
                new SalesSaleProduct() {SalesName="Bill" , Product="鉛筆" , ProductNumber=32 },
                new SalesSaleProduct() {SalesName="Bill" , Product="橡皮擦" , ProductNumber=56 },
                new SalesSaleProduct() {SalesName="Bill" , Product="直尺" , ProductNumber=45 },
                new SalesSaleProduct() {SalesName="Bill" , Product="立可白" , ProductNumber=33 },
                new SalesSaleProduct() {SalesName="John", Product="原子筆" , ProductNumber=77 },
                new SalesSaleProduct() {SalesName="John", Product="鉛筆" , ProductNumber=33 },
                new SalesSaleProduct() {SalesName="John", Product="橡皮擦" , ProductNumber=68 },
                new SalesSaleProduct() {SalesName="John", Product="直尺" , ProductNumber=45 },
                new SalesSaleProduct() {SalesName="John", Product="立可白" , ProductNumber=23 },
                new SalesSaleProduct() {SalesName="David",Product="原子筆" , ProductNumber=43 },
                new SalesSaleProduct() {SalesName="David",Product="鉛筆" , ProductNumber=55 },
                new SalesSaleProduct() {SalesName="David",Product="橡皮擦" , ProductNumber=43 },
                new SalesSaleProduct() {SalesName="David",Product="直尺" , ProductNumber=67 },
                new SalesSaleProduct() {SalesName="David",Product="立可白" , ProductNumber=65 }
        };


    }
}
