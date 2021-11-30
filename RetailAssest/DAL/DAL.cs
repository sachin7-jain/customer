using Newtonsoft.Json;
using RetailAssest.RetailContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using model = RetailAssest.RetailContext;

namespace RetailAssest
{
    public class DAL
    {
        public Response ManageCustomer(Customer customer)
        {
            Response response = new Response();
            try
            {
                model.RetailAssest retailAssest = new model.RetailAssest()
                {
                    FirstName = customer.FirstName,
                    LastName = customer.LastName,
                    Status = customer.Status,
                    IncomeType = customer.IncomeType,
                    AlternateMobileNumber = customer.AlternateMobileNumber,
                    ApplicantType = customer.ApplicantType,
                    CreatedBy = customer.CreatedBy,
                    EmailId = customer.EmailId,
                    Gender = customer.Gender,
                    IsTncAgree = customer.IsTncAgree,
                    MobileNumber = customer.MobileNumber,
                    ResidentStatus = customer.ResidentStatus
                };
                int affectedRecords = 0;
                using (IRCMSContext context = new IRCMSContext())
                {
                    if (string.IsNullOrEmpty(customer.RequestId))
                    {
                        if (context.RetailAssest.Where(x => x.EmailId == retailAssest.EmailId).Count() > 0)
                        {
                            response.Code = 400;
                            response.Message = ResponseMessage.DataExist;
                        }
                        else
                        {
                            response.Code = 200;
                            retailAssest.RequestId = Guid.NewGuid().ToString();
                            context.RetailAssest.Add(retailAssest);
                            response.Message = ResponseMessage.DataSaved;
                        }
                    }
                    else
                    {
                        retailAssest.RequestId = customer.RequestId;
                        context.RetailAssest.Update(retailAssest);
                    }
                    affectedRecords = context.SaveChanges();
                    response.Count = affectedRecords;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return response;
        }



        public Response GetCustomer(string id)
        {
            Response response = null;
            List<model.RetailAssest> customers = null;
            try
            {
                using (IRCMSContext context = new IRCMSContext())
                {
                    response = new Response();
                    if (!string.IsNullOrEmpty(id))
                    {
                        customers = context.RetailAssest.Where(x => x.RequestId == id).ToList();
                    }
                    else
                    {
                        customers = context.RetailAssest.ToList();
                    }
                    response.Code = 200;
                    response.Data = JsonConvert.SerializeObject(customers);
                    // Response message can be get from a Constant
                    response.Message = ResponseMessage.DataSaved;
                }
            }
            catch (Exception)
            {
                //Error handling at project level
                throw;
            }
            return response;
        }
    }
}
