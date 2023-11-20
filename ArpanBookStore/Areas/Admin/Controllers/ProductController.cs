using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArpansBooks.DataAccess.Repository.IRepository;
using ArpansBooks.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using ArpansBooks.Models.ViewModels;

namespace ArpanBookStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _hostEnviornment;

        public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _hostEnviornment = hostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Upsert(int? id)
        //// get action method for Upsert
        //{
        //    ProductVM productVM = new ProductVM()
        //    {
        //        Product = new Product(),
        //        CategoryList = _unitOfWork.Category.GetAll().Select(i => new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.ID.ToString()
        //        }),

        //        CoverTypeList = _unitOfWork.CoverType.GetAll().Select(i => new SelectListItem
        //        {
        //            Text = i.Name,
        //            Value = i.ID.ToString()
        //        }),

        //    }; // using AndrewsBooks.Models;
        //    if (id == null)
        //    {
        //        // this is for create
        //        return View(productVM);
        //    }
        //    // this for the edit
        //    productVM.Product = _unitOfWork.Product.Get(id.GetValueOrDefault());
        //    if (productVM.Product == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(productVM);
        //}
        //API calls here

        #region API CALLS
        [HttpGet]

        public IActionResult GetALL()
        {
            var allObj = _unitOfWork.Product.GetAll(includeProperties:"Category,CoverType");
            return Json(new { data = allObj });
        }


        [HttpDelete]

        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Product.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }
            _unitOfWork.Product.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete successful" });
        }
        #endregion
    }
}
