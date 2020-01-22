using MvcClient.Models;
using SOAMultiLayerSolution.DTO;
using System.Web.Mvc;

namespace MvcClient.Controllers
{
    public class CustomersController : Controller
    {
        CustomersViewModel viewModel;

        public CustomersViewModel ViewModel { 
            get {
                if (viewModel == null) {
                    viewModel = new CustomersViewModel ();
                }
                return viewModel;
            }
        }

        // GET: Customers
        public ActionResult Index () => View (ViewModel);

        // GET: Customers/Create
        public ActionResult Create ()
        {
            ViewModel.Data = new CustomerDTO ();
            return View (ViewModel);
        }

        // POST: Customers/Create
        [HttpPost]
        public ActionResult Create (CustomerDTO dto)
        {
            try {
                ViewModel.Create (dto);
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        // GET: Customers/Edit/5
        public ActionResult Edit (int id)
        {
            ViewModel.Data = ViewModel.Get (id);
            return View (ViewModel);
        }

        // POST: Customers/Edit/5
        [HttpPost]
        public ActionResult Edit (int id, CustomerDTO dto)
        {
            try {
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }

        // POST: Customers/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete (int id)
        {
            try {
                ViewModel.Delete (id);
                return RedirectToAction ("Index");
            } catch {
                return View ();
            }
        }
    }
}
