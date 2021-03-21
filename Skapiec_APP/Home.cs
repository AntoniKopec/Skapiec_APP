﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.Web;

namespace Skapiec_APP
{
    public partial class Home : Form
    {
        List<ProductsModel> Product = new List<ProductsModel>();
        List<RunSearch> Run = new List<RunSearch>();
        public Home()
        {
            InitializeComponent();
            LoadList();
            populateItemsHome();
        }


             

        
        private void LoadList()
        {
            Product = SqliteDataAccess.LoadProducts();
            Run = SqliteDataAccess.LoadRun();
            WireUpSearchList(); //podglądowe okienko list box do wyrzucenia jak wszystko będzie śmigać
        }



        private void search_text_TextChanged(object sender, EventArgs e)
        {

        }


        
        private void search_btn_Click(object sender, EventArgs e)
        {
            AddData();
            search_text.Text = "";
            System.Windows.Forms.Application.Restart();
        }

        public void AddData()
        {
            RunSearch runSearch = new RunSearch();
            runSearch.search_text = search_text.Text;
            SqliteDataAccess.SaveRun(runSearch);

            HtmlWeb web = new HtmlWeb();
            var doc = web.Load($"https://www.skapiec.pl/szukaj/w_calym_serwisie/{search_text.Text}");

            var Articles = doc.DocumentNode.SelectNodes("//*[@class = 'box-row js']");
            foreach (var article in Articles)
            {
                var title = HttpUtility.HtmlDecode(article.SelectSingleNode(".//h2[@class = 'title gtm_red_solink']").InnerText);
                var price = HttpUtility.HtmlDecode(article.SelectSingleNode(".//strong[@class = 'price gtm_sor_price']").InnerText);
                var link = HttpUtility.HtmlDecode(article.SelectSingleNode(".//a[@class = 'btn l direct-link-1 gtm_sor_button']").GetAttributeValue("href", string.Empty).ToString());
                var image = HttpUtility.HtmlDecode(article.SelectSingleNode(".//img").Attributes["src"].Value.ToString());
                var bytes = Encoding.Default.GetBytes(image);

                ProductsModel productsModel = new ProductsModel();
                productsModel.search_query = search_text.Text;
                productsModel.image = bytes;
                productsModel.title = title;
                productsModel.price = price;
                productsModel.link = "https://www.skapiec.pl" + link;
                SqliteDataAccess.SaveProducts(productsModel);
            }
        }


        private void history_btn_Click(object sender, EventArgs e)
        {
            populateItemsHistory();           
        }




        //zapełnienie panelu danymi z searcha
        public void populateItemsHome()
        {
            //wypełnienie
            HomeItem[] listItems = new HomeItem[20];



            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new HomeItem();

                listItems[i].Title = Product[i].title;
                listItems[i].Button = Product[i].link;
                listItems[i].Price = Product[i].price;

                //listItems[i].Icon = Image.FromFile(@"C:\Users\domin\Documents\Studia\Zespołowy Projekt Programistyczny\Skapiec_APP\img\" + Product[i].title + ".jpg");

                //listItems[i].Icon = Image.FromFile(@"C:\Users\anton\Desktop\Projekt_1\" + Product[i].image);
                //każdy niech daje swoją ścieżkę żeby spawdzać czy działa                
                //wygląda na to że tytuły zdjęć muszą być takie jak tytuły ofert   

                // dodawnie do flow layout panelu 
                if (home_panel.Controls.Count < 0)
                {
                    home_panel.Controls.Clear();
                }
                else
                    home_panel.Controls.Add(listItems[i]);
            }
        }

        //zapełnienie panelu danymi z histori
        private void populateItemsHistory()
        {
            home_panel.Controls.Clear();
            //wypełnienie 
            HistoryItem[] listItems = new HistoryItem[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new HistoryItem();

                listItems[i].Title = Product[i].search_query;


                // dodawnie do flow layout panelu 
                if (home_panel.Controls.Count < 0)
                {
                    home_panel.Controls.Clear();
                }
                else
                    home_panel.Controls.Add(listItems[i]);
            }
        }



        //podglądowe okienko list box do wyrzucenia jak wszystko będzie śmigać
        private void test_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void WireUpSearchList()
        {
            test.DataSource = null;
            test.DataSource = Run;
            test.DisplayMember = "search_text";
        }
    }
}
