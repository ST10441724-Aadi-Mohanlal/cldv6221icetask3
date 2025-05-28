using Microsoft.AspNetCore.Mvc;

namespace IceTask2.Models
{
    public class Student : Controller
    {
        public class Students
        {
            public int Id { get; set; }
            public string FullName { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
        }

    }
}
