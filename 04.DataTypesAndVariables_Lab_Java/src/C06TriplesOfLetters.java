import java.util.Scanner;

public class C06TriplesOfLetters {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int input = Integer.parseInt(console.nextLine());
        StringBuilder output = new StringBuilder();
        for (int firstChar=97; firstChar <= 96+input; firstChar++)
        {
            for (int secondChar = 97; secondChar <= 96+input; secondChar++)
            {
                for (int lastChar = 97; lastChar <= 96+input; lastChar++)
                {
                    output.append(String.format("%s%s%s%n", (char)firstChar, (char)secondChar,(char)lastChar));
                }
            }
        }
        System.out.println(output);
    }
}
