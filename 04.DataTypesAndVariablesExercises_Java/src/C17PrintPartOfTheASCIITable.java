import java.util.Scanner;

public class C17PrintPartOfTheASCIITable {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        {
            int inputOne = Integer.parseInt(console.nextLine());
            int inputTwo = Integer.parseInt(console.nextLine());
            for (int staringPoint = inputOne; inputOne <= inputTwo; inputOne++)
            {
                char charUnicod = (char)inputOne;
                System.out.print(String.valueOf(charUnicod)+" ");
            }
        }
    }
}
