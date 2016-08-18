

public class CoffeeShop {

	public static void main(String args[]){

		Beverage espresso=new Espresso();
		System.out.println(espresso.getDescription());

		espresso= new Mocha(espresso);
		System.out.println(espresso.getDescription()+"  "+espresso.cost());

	}
}