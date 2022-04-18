using Entity_Project.Data_access_layer;
using Entity_Project.Models;
using System;

namespace Entity_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Books();
            Authors();
            Genres();
            Publisings();
        }
        static void Books()
        {
            Book book = new Book { Name = "Qurur ve Qerez", PageCount = 380, Price = 8, StockCount = 10 };
            //Book book1 = new Book { Name = "Sirli Devetname", PageCount = 486,Price=5,StockCount=15 };
            //Book book2 = new Book { Name = "Xeyanet", PageCount = 350,Price=12,StockCount=35};
            //Book book3 = new Book { Name = "Adsiz Tablo", PageCount = 498,Price=7,StockCount=70};
            //Book book4 = new Book { Name = "Qan Lekesi", PageCount = 700,Price=13,StockCount=4 };
            using (AppDbContext sql = new AppDbContext())
            {
                sql.Books.Add(book);
                sql.SaveChanges();
            }
        }
        static void Authors()
        {
            Author author = new Author { Name = "Elxan", Surname = "Elatli" };
            Author author1 = new Author { Name = "Lev", Surname = "Tolstoy" };
            Author author2 = new Author { Name = "Con", Surname = "Steynbek" };
            Author author3 = new Author { Name = "Oldos ", Surname = "Haksli" };
            Author author4 = new Author { Name = "Cingiz", Surname = "Abdullayev" };
            using (AppDbContext sql = new AppDbContext())
            {
                sql.Authors.Add(author4);
                sql.SaveChanges();
            }
        }
        static void Genres()
        {
            Genre genre = new Genre { Name = "Dedektiv" };
            Genre genre1 = new Genre { Name = "Romantik" };
            Genre genre2 = new Genre { Name = "Klassik" };
            Genre genre3 = new Genre { Name = "Hekaye" };
            Genre genre4 = new Genre { Name = "Povest" };
            using (AppDbContext sql = new AppDbContext())
            {
                sql.Genres.Add(genre4);
                sql.SaveChanges();
            }
        }
        static void Publisings()
        {
            Publising publising = new Publising { Name = "Nurlar" };
            Publising publising1 = new Publising { Name = "MTM Innovation" };
            Publising publising2 = new Publising { Name = "Aspoliqraf" };
            Publising publising3 = new Publising { Name = "Altun kitab" };
            Publising publising4 = new Publising { Name = "Casioglu" };
            using (AppDbContext sql = new AppDbContext())
            {
                sql.Publisings.Add(publising);
                sql.SaveChanges();
            }
        }
    }
}
