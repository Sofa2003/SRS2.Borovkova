using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SRS2.Borovkova.Data;

namespace SRS2.Borovkova.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly DateBaseContext _context;

        [BindProperty]
        public string Login { get; set; }

        [BindProperty]
        public string Paroli { get; set; }


        public IndexModel(ILogger<IndexModel> logger, DateBaseContext context)
        {
            _logger = logger;
            _context = context;
        }


        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            hashPassword hash = new hashPassword();
            string hashedPassword = hash.HashingPassword(Paroli);
            // Ищем пользователя с таким логином и паролем в базе данных
            var user = _context.LoginPersonal.FirstOrDefault(u => u.Login.ToLower() == Login.ToLower() && u.Paroli == hashedPassword);

            if (user != null)
            {
                // Если пользователь найден, перенаправляем на домашнюю страницу
                return RedirectToPage("/HomePage");
            }
            else
            {
                // Если пользователь не найден, добавляем ошибку в ModelState
                ModelState.AddModelError(string.Empty, "Неправильный логин или пароль.");
                return Page(); // Возвращаем ту же страницу с ошибкой
            }
        }
    }
}

