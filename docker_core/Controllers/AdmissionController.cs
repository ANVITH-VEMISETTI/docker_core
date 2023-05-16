using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using docker_core.Models;
using Microsoft.VisualBasic;

namespace docker_core.Controllers
{
    public class AdmissionController : Controller
    {
        // GET: AdmissionController
        public ActionResult Index()
        {
            Admitions adm = new Admitions()
            {
                AdmissionId = 1,
                StudentName = "Anvith",
                Branch = "B.Tech"
            };
            return View(adm);
        }

        // GET: AdmissionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdmissionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdmissionController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                Admitions adm = new Admitions()
                {
                    AdmissionId = Int32.Parse(collection["AdmissionId"]),
                    StudentName = collection["StudentName"],
                    Branch = collection["Branch"]
                };

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmissionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdmissionController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdmissionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdmissionController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
