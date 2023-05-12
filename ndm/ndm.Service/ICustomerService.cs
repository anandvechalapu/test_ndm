IEnumerable

namespace ndm.Service 
{ 
    public class CustomerService 
    { 
        public IEnumerable<CustomerDTO> GetCustomers() 
        { 
            // Method implementation
        } 
    } 
}

using ndm.DTO;

namespace ndm.Service 
{ 
    public interface ICustomerService 
    { 
        IEnumerable<CustomerDTO> GetCustomers();  
    } 
}