using Shopware.Api;
using Shopware.Api.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var shop = new Shop("www.shopware1.local", "apiuser", "Q57tUCXFDJwHhOnX5MgsFthPelFeT0mKqKKJZSq1", false);
            /*var categories = shop.GetList<Category>();
            categories?.Select(c => c.id + "\t" + c.name).
                Select(s =>
                {
                    Console.WriteLine(s);
                    return s;
                }).ToArray();
            Console.WriteLine();
            var category = shop.Get<Category>(1);
            Console.WriteLine(category?.id + "\t" + category?.name);
            int catId = shop.Post(new Category
            {
                name = "Test",
                parentId = 1
            });
            Console.WriteLine(catId);
            catId = shop.Put(new Category
            {
                id = catId,
                name = "PutTest",
                parentId = 1
            },
            catId);
            Console.WriteLine(catId);
            shop.Delete<Category>(catId);
            var cat = category.added;
            category.added = DateTime.Now;*/
            var articles = shop.GetList<Article>();
            var firstId = articles?.FirstOrDefault()?.id;
            if(firstId != null)
            {
                var article = shop.Get<Article>(firstId.Value);
                Console.WriteLine(article.name);
            }
            Console.ReadLine();
        }
    }
}
