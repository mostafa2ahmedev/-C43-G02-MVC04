using IKEA.DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace IKEA.PL.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService,ILogger<>)
        {
            _departmentService = departmentService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var departments = _departmentService.GetAllDepartments();
            return View(departments); // Pass departments as the model
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(); // Renders "Create.cshtml" with empty model
        }
        [HttpPost]
        public IActionResult Create(CreateDepartmentDto model)
        {
            if (!ModelState.IsValid)
                return View(model); // Re-show form with validation errors

            try
            {
                var department = _mapper.Map<Department>(model);
                _departmentService.AddDepartment(department);

                if (_departmentService.SaveChanges() > 0)
                    return RedirectToAction(nameof(Index)); // Success: Redirect to Index

                ModelState.AddModelError("", "Failed to create department.");
                return View(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Department creation failed.");

                if (_env.IsDevelopment())
                    ModelState.AddModelError("", ex.Message); // Show technical error in dev
                else
                    ModelState.AddModelError("", "An error occurred. Try again.");

                return View(model);
            }

            [HttpGet]
            public IActionResult Details(int id)
            {
                var department = _departmentService.GetDepartmentById(id);
                if (department == null)
                    return NotFound(); // 404 error if department not found

                return View(department); // Pass department to "Details.cshtml"
            }
        }
    }
}
