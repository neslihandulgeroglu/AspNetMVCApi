using AspNetMVCApi_BLL.ContractBLL;
using AspNetMVCApi_BLL.ImplementationBLL;
using AspNetMVCApi_DAL;
using AspNetMVCApi_DAL.Contracts;
using AspNetMVCApi_DAL.Implementations;
using AspNetMVCApi_EL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace AspNetMVCApi_PL.Controllers
{
    [System.Web.Http.RoutePrefix("s")]
    public class StudentController : ApiController
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
         [System.Web.Http.Route("")]
        // GET api/<controller>
        public ResponseData GetAllStudents()
        {
            try
            {
                var result = _studentService.GetAllStudents().Data;
                return new ResponseData() {IsSuccess=true, Data=result};
            } 
            catch (Exception ex)
            {
              
                return new ResponseData()
                {
                    IsSuccess=false,
                    Message=ex.Message
                };
            }
        }
        

        // GET api/<controller>/5

        // POST api/<controller>

        // PUT api/<controller>/5

        // DELETE api/<controller>/5
    }
}