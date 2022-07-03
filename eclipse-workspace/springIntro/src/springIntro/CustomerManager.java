package springIntro;

public class CustomerManager implements ICustomerService{
	private ICustomerDal customerDal;
	
	// constructor injection
	/*public CustomerManager(ICustomerDal customerDal) {
		this.customerDal = customerDal;
	}*/
	
	
	// setter injection
	public ICustomerDal getCustomerDal() {
		return customerDal;
	}

	public void setCustomerDal(ICustomerDal customerDal) {
		this.customerDal = customerDal;
	}

	public void add() {
		// iş kuralları sağlanırsa veri erişimi çağrılacak
		customerDal.add();
	}

}
