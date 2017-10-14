import java.util.Scanner;

public class C05BooleanVariable {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        String stringInput = console.nextLine();
        boolean stringOrNot = Boolean.valueOf(stringInput);
        if (stringOrNot == true)
        {
            System.out.print("Yes");
        }
        else
        {
            System.out.print("No");
        }
    }
}
