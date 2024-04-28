using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PeopleApp.Models;
using PeopleApp.Services;
using PeopleApp.ViewModels;

namespace PeopleApp.Controllers.api
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _depRepo;
        public DepartmentController(IDepartmentRepository depRepo)
        {
            _depRepo = depRepo;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            var departments = _depRepo.GetDepartments();
            //List<Department> departments = _depRepo.GetDepartments().Select(x=>new Department { Id=x.Id, Name= x.Name}).ToList();
            return Ok(departments);
        }
    }
}
