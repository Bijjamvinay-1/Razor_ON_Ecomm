using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor_ON_Ecomm.Data;
using Razor_ON_Ecomm.Model;

namespace Razor_ON_Ecomm.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public List<Category>CategoryList { get; set; }

        public IndexModel(ApplicationDbContext db)
        { 
            _db=db;
        
        }
        public void OnGet()
        {
            CategoryList =_db.Categories.ToList();
        }
    }
}
