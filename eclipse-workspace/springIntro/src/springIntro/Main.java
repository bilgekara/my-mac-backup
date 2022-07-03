package springIntro;
// ctrl + shift + C

public class Main {

	public static void main(String[] args) {
		//xml i okumak için
		ClassPathXmlApplicationContext context =
				new ClassPathXmlApplicationContext("applicationContext.xml");
		
		ICustomerService customerService= context.getBean("service", ICustomerService.class);
		
		// arka planda bizim yerimize new yapıyor
		CustomerManager manager = new CustomerManager(context.getBean("database", ICustomerDal.class));
		manager.add();
	}

}
