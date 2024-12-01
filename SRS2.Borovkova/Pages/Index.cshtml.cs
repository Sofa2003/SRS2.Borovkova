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
            // ���� ������������ � ����� ������� � ������� � ���� ������
            var user = _context.LoginPersonal.FirstOrDefault(u => u.Login.ToLower() == Login.ToLower() && u.Paroli == hashedPassword);

            if (user != null)
            {
                // ���� ������������ ������, �������������� �� �������� ��������
                return RedirectToPage("/HomePage");
            }
            else
            {
                // ���� ������������ �� ������, ��������� ������ � ModelState
                ModelState.AddModelError(string.Empty, "������������ ����� ��� ������.");
                return Page(); // ���������� �� �� �������� � �������
            }
        }
    }
}

