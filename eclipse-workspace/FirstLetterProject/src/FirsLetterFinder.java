import java.util.Scanner;

public class FirsLetterFinder {

	static String firstLetterFinder(String scan) {
		String[] words =  scan.split(" ");
		String firstL = "";
		for (String word : words) { 
            
			firstL += word.substring(0,1);
        }
		return firstL;
	}

	public static void main(String[] args) {
		try {
			Scanner girdi = new Scanner(System.in);
			
			System.out.println(firstLetterFinder(girdi.nextLine()));
			
		}catch(Exception e){
			System.out.println("HATA ->"+e);
		}
		
	}

}
