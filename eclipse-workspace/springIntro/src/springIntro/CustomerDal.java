package springIntro;
//veriye erişim burada yapılır
// ileride hibernate ile örnekleri yapılacak

public class CustomerDal implements ICustomerDal {
	String connectionString;
	
	public String getConnectionString() {
		return connectionString;
	}

	public void setConnectionString(String connectionString) {
		this.connectionString = connectionString;
	}

	public void add() {
		System.out.println("Connection String : " + this.connectionString);
		System.out.println("Oracle veritabanına eklendi");
	}

}
