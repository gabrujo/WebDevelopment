using StudentWinApp1.DataLayer;
using StudentWinApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentWinApp1.BusinessLayer
{
    class BusinessCourses
    {
        RepositoryCourses rep = new RepositoryCourses();

    }

    public List <CourseOfferedVM> GetCoursesOffered(string semester)
    {
        return _rep.GetCoursesOffered(semester);
    }

    public List <CourseEnrollmentVM> GetCourseEnrollment(string semester, string courseNum)
    {
        return _rep.GetCourseEnrollment(semester, courseNum);
    }

    public List<string> GetCoursesOfferedForASemester(string semester)
    {
        return _rep.GetCoursesOfferedForASemester(semester);
    }

}