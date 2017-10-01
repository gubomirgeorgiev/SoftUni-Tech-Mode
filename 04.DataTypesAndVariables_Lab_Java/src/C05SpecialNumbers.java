import java.util.Scanner;

public class C05SpecialNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int input = Integer.parseInt(console.nextLine());
        for (int i=1; i<=input; i++)
        {
            int sum = 0;
            int num = i;
            while (num>0){
                sum +=num%10;
                num/=10;
            }
            boolean result = (sum == 5 || sum==7 || sum == 11);
            System.out.printf("%d -> %s%n", i,result);
        }
    }
}
