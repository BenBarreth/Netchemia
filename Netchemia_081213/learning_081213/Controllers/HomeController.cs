using Netchemia_081213.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Netchemia_081213.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetCafeCredit(int studentId)
        {
            int cafeCredits = 0;
            Student student = GetStudentType(studentId);

            cafeCredits = student.GetCafeCredits(studentId);
            return Json("This student has " + cafeCredits + " cafe credits.");
        }

        [HttpPost]
        public ActionResult RegisterClass(int teachingClassId, int studentId) 
        {
            bool success = false;
            Student student = GetStudentType(studentId);

            success = student.RegisterClass(teachingClassId, studentId);
            string msg = success
                    ? "This student has been successully registered for class id: " + teachingClassId + "."
                    : "We're sorry - This student could not be registered for class id: " + teachingClassId + ".";
            return Json(msg); 
        }

        [HttpPost]
        public ActionResult GetTranscript(int studentId)
        {
            Student student = GetStudentType(studentId);
            Transcript transcript = student.GetTranscript(studentId);
            return Json(transcript);
        }

        #region helpers
        private static Student GetStudentType(int studentId)
        {
            //this logic is totally lame, but you get the idea.
            Student student;
            switch (studentId)
            {
                case 1:
                    student = new Undergraduate();
                    break;
                case 2:
                    student = new Graduate();
                    break;
                case 3:
                    student = new Doctorate();
                    break;
                default:
                    throw new IndexOutOfRangeException("This student id could not be found. Please try another.");
            }
            return student;
        }
        #endregion
    }
}
