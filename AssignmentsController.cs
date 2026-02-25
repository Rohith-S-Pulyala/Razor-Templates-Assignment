using Microsoft.AspNetCore.Mvc;
using CIS174_TestCoreApp_Pulyala.Models;

/*
 * Assignment Controller
 */

namespace CIS174_TestCoreApp_Pulyala.Controllers
{
    public class AssignmentsController : Controller
    {   
        // Route Range Constraint: Ensures 'accessLevel' is an integer between 1 and 10
        // {accessLevel} handles integer parameter in Route attribute
        [Route("Assignments/Assignment61/{accessLevel:int:range(1,10)}")]
        public IActionResult Assignment61(int accessLevel)
        {
            // Creates ViewModel to pass both raw Access Level and the list of Students
            var viewModel = new Assignment61ViewModel
            {
                AccessLevel = accessLevel,
                Students = new List<Student> 
                {
                    new Student { FirstName = "Rachel", LastName = "Lee", Grade = 95 },
                    new Student { FirstName = "Jack", LastName = "David", Grade = 88 },
                    new Student { FirstName = "Jordan", LastName = "Ray", Grade = 100 },
                    new Student { FirstName = "Thomasine", LastName = "Luther", Grade = 99 }
                }
            };

            return View(viewModel);
        }
    }
}
