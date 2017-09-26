import java.util.Scanner;

public class FiveDifferentNumbers {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int a = Integer.parseInt(console.nextLine());
        int b = Integer.parseInt(console.nextLine());
        if (Math.max(a, b) - Math.min(a, b) >= 5)
        {
            for (int n1 = a; n1 <= b; n1++)
            {
                for (int n2 = a; n2 <= b; n2++)
                {
                    for (int n3 = a; n3 <= b; n3++)
                    {
                        for (int n4 = a; n4 <= b; n4++)
                        {
                            for (int n5 = a; n5 <= b; n5++)
                            {
                                if (a <= n1 && n1 < n2 && n2 < n3 && n3 < n4 && n4 < n5 && n5 <= b)
                                {
                                    System.out.printf("%d %d %d %d %d%n",n1,n2,n3,n4,n5);
                                }

                            }
                        }
                    }
                }
            }
        }
        else
        {
            System.out.println("No");
        }
    }
}
