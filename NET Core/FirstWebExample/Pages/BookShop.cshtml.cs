using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DALLibrary;

namespace FirstWebExample.Pages
{
    public class BookShopModel : PageModel
    {
        public void OnGet()
        {
        }

        public void OnPost(ModelBook book)
        {
            book.Title = Request.Form["bname"].ToString();
            book.AuthorName = Request.Form["bauth"].ToString();
            book.Category = Request.Form["bcat"].ToString();
            book.Pages = int.Parse(Request.Form["bpages"].ToString());
            book.Price = decimal.Parse(Request.Form["bprice"].ToString());
            ModelState.AddModelError("", book.Title + "," + book.AuthorName +
                "," + book.Category + "," + book.Pages + "," + book.Price);

            try
            {
                DBConnect db = new DBConnect();
                var res = db.InsertNewBook(book);
                if (res > 0) ModelState.AddModelError("", "New ISBN No. : " + res.ToString());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", ex.Message);
            }
        }
    }
}
