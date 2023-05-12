public class CustomerServiceImpl implements ICustomerService {

    @Override
    public Customer getCustomerInfo(int customerId) {
        //Retrieve customer information from the database
        return customer;
    }

    @Override
    public void updateCustomerInfo(int customerId, Customer customer) {
        //Update customer information in the database
    }

    @Override
    public void deleteCustomerInfo(int customerId) {
        //Delete customer information from the database
    }

}