using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using proje.Models;

namespace proje.Controllers
{
    public class AccountController : Controller
    {

        DataContext context = new DataContext();
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(string Email, string Password)
        {

            var user = context.Users.FirstOrDefault(w => w.Email.Equals(Email) && w.Password.Equals(Password));
            if (user != null)
            {

                //HttpContext.Session.SetInt32("id",user.Id);
                //HttpContext.Session.SetString("fullname", user.Name + " " + user.Surname);

                return Redirect("/Home/Index");
            }
            return Redirect("Index");
        }
        public IActionResult Logout()
        {
            //HttpContext.Session.Clear();
            return Redirect("Index");
        }

        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult RandevuAlmaFormu()
        {
            /*var deneme = context.Clinics
                .Include(i => i.Departments)
                .ToList();

            return View(deneme);*/




            var deneme = context.Clinics
      .Include(clinic => clinic.Departments)
          .ThenInclude(department => department.Doctors)
              .ThenInclude(doctor => doctor.Appointments)
      .ToList();

            return View(deneme);

        }


        public async Task<IActionResult> Register(User model)
        {

            await context.AddAsync(model);
            await context.SaveChangesAsync();

            return Redirect("Index");
        }

        public IActionResult Hastanemiz()
        {
            return View();
        }
        public IActionResult Haskkimizda()
        {
            return View();
        }
        public IActionResult Tedavi()
        {
            return View();
        }

        public IActionResult Doktorlarimiz()
        {
            return View();
        }
        public IActionResult Referanslarimiz()
        {
            return View();
        }




    }
}
