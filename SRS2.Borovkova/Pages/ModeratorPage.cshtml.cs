using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SRS2.Borovkova.Data;
using SRS2.Borovkova.Models;

namespace SRS2.Borovkova.Pages
{
    public class ModeratorPageModel : PageModel
    {
        //private readonly DateBaseContext _context;

        //public ModeratorPageModel(DateBaseContext context)
        //{
        //    _context = context;
        //}

        //public IList<LoginPersonals> LoginPersonals { get; set; }
        //public IList<Order> Orders { get; set; }
        //public IList<Tovars> Tovar { get; set; }

        //public async Task OnGetAsync()
        //{
        //    LoginPersonals = await _context.LoginPersonal.ToListAsync();
        //    Orders = await _context.Orders.Include(o => o.User).Include(o => o.Tovar).ToListAsync();
        //    Tovar = await _context.Tovar.ToListAsync();
        //}

        //// Редактирование пользователя
        //public async Task<IActionResult> OnPostEditUserAsync(string login, string password, int role, int id)
        //{
        //    var user = await _context.LoginPersonal.FindAsync(id);
        //    if (user != null)
        //    {
        //        user.Login = login;
        //        user.Paroli = password;
        //        user.Role = role;
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}

        //// Редактирование заказа
        //public async Task<IActionResult> OnPostEditOrderAsync(int count, int id)
        //{
        //    var order = await _context.Orders.FindAsync(id);
        //    if (order != null)
        //    {
        //        order.Count = count;
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}

        //// Редактирование товара
        //public async Task<IActionResult> OnPostEditGoodsAsync(string name, string description, bool inStock, int id)
        //{
        //    var goods = await _context.Tovar.FindAsync(id);
        //    if (goods != null)
        //    {
        //        goods.Name = name;
        //        goods.Description = description;
        //        goods.in_stock = inStock;
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}

        //// Удаление пользователя
        //public async Task<IActionResult> OnPostDeleteUserAsync(int id)
        //{
        //    var user = await _context.LoginPersonal.FindAsync(id);
        //    if (user != null)
        //    {
        //        _context.LoginPersonal.Remove(user);
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}

        //// Удаление заказа
        //public async Task<IActionResult> OnPostDeleteOrderAsync(int id)
        //{
        //    var order = await _context.Orders.FindAsync(id);
        //    if (order != null)
        //    {
        //        _context.Orders.Remove(order);
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}

        //// Удаление товара
        //public async Task<IActionResult> OnPostDeleteGoodsAsync(int id)
        //{
        //    var goods = await _context.Tovar.FindAsync(id);
        //    if (goods != null)
        //    {
        //        _context.Tovar.Remove(goods);
        //        await _context.SaveChangesAsync();
        //    }
        //    return RedirectToPage();
        //}
    }
}

    

