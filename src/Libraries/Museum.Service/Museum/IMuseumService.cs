using Museum.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museum.Service.Museum
{
    public interface IMuseumService
    {
        IEnumerable<Museums> GetAllMuseums(
            DateTime? createdFromUtc = null, 
            DateTime? createdToUtc = null,
            int affiliateId = 0, 
            int vendorId = 0, 
            int[] customerRoleIds = null,
            string email = null, 
            string username = null, 
            string firstName = null, 
            string lastName = null,
            int dayOfBirth = 0, 
            int monthOfBirth = 0,
            string company = null, 
            string phone = null, 
            string zipPostalCode = null, 
            string ipAddress = null,
            int pageIndex = 0, 
            int pageSize = int.MaxValue, 
            bool getOnlyTotalCount = false);


    }
}
