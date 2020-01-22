using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using viewcompont.Models;
namespace viewcompont.viewcomponents
{
    public class EmployeeList1 : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int noOfEmployee)
        {
            List<Employee> items = new List<Employee>();
            for (var i = 0; i <= noOfEmployee; i++)
            {
                items.Add(new Employee { Id = i, Name = "Emp " + i.ToString() });
            }
            if (noOfEmployee > 5)
            {
                return View("EmployeeList1", items);
            }
            return View(items);
        }
    }
}
