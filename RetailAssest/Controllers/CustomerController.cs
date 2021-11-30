using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using CMS_NC_BusinessUnit.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RetailAssest.BL;

namespace RetailAssest.Controllers
{
    /// <summary>
    /// Controller to manage details of Onboarding Customer for Loan via webSite
    /// </summary>
    
    [ApiController]
    public class CustomerController : ControllerBase
    {
        /// <summary>
        /// Api to get the list of all Customers
        /// </summary>
        [HttpGet]
        [Route("get")]
        [ProducesResponseType(typeof(CustomResponse), 200)]
        [ProducesResponseType(typeof(CustomResponse), 400)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public ActionResult GetCustomers()
        {
            Response response = new BAL().GetCustomer(string.Empty);
            return StatusCode(response.Code, response);
        }

        /// <summary>
        /// Api to get customer based on RequestId
        /// </summary>
        [HttpGet]
        [Route("get/id")]
        [ProducesResponseType(typeof(CustomResponse), 200)]
        [ProducesResponseType(typeof(CustomResponse), 400)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public ActionResult GetCustomers([Required]string Id)
        {
            Response response = new BAL().GetCustomer(Id);
            return StatusCode(response.Code, response);
        }


        /// <summary>
        /// Api to manage the Customer Data
        /// </summary>
        ///<param name="customer">Model for managing the customer data segment</param>
        [HttpPost]
        [Route("add")]
        [ProducesResponseType(typeof(CustomResponse), 200)]
        [ProducesResponseType(typeof(CustomResponse), 400)]
        [ProducesResponseType(typeof(ErrorResponse), 500)]
        public ActionResult Add([Required]Customer customer)
        {
            Response response = new BAL().ManageCustomer(customer);
            return StatusCode(response.Code, response);
        }
    }
}