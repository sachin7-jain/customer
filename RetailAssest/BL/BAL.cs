using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace RetailAssest.BL
{
    public class BAL
    {
        /// <summary>
        /// This section to be used for any business logic, no direct DB call in the class, it also include validation from any external or internal API
        /// </summary>
        DAL _dal = null;
        public BAL()
        {
            _dal = new DAL();
        }

        public Response ManageCustomer(Customer customer)
        {
            return _dal.ManageCustomer(customer);
        }

        public Response GetCustomer(string id)
        {
            return _dal.GetCustomer(id);
        }
    }


}
