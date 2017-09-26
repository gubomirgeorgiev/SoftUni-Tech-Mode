import java.util.Scanner;

public class RestaurantDiscount {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int groupSize = Integer.parseInt(console.nextLine());
        String resturantPackage = console.nextLine();
        if (groupSize>0&&groupSize<=50){
            String hall = "Small Hall";
            switch (resturantPackage){
                case "Normal":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((2500 + 500) - (2500 + 500) * 0.05)/groupSize));
                    break;
                case "Gold":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((2500 + 750) - (2500 + 750) * 0.1) / groupSize));
                    break;
                case "Platinum":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((2500 + 1000) - (2500 + 1000) * 0.15) / groupSize));
                    break;
            }
        }
        else if (groupSize>50&&groupSize<=100){
            String hall = "Terrace";
            switch (resturantPackage){
                case "Normal":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((5000 + 500) - (5000 + 500) * 0.05) / groupSize));
                    break;
                case "Gold":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((5000 + 750) - (5000 + 750) * 0.1) / groupSize));
                    break;
                case "Platinum":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((5000 + 1000) - (5000 + 1000) * 0.15) / groupSize));
                    break;
            }
        }
        else if (groupSize>100&&groupSize<=120){
            String hall = "Great Hall";
            switch (resturantPackage){
                case "Normal":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((7500 + 500) - (7500 + 500) * 0.05) / groupSize));
                    break;
                case "Gold":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((7500 + 750) - (7500 + 750) * 0.1) / groupSize));
                    break;
                case "Platinum":
                    System.out.printf("We can offer you the %s%n",hall);
                    System.out.printf("The price per person is %.2f$",(((7500 + 1000) - (7500 + 1000) * 0.15) / groupSize));
                    break;
            }
        }
    }
}
