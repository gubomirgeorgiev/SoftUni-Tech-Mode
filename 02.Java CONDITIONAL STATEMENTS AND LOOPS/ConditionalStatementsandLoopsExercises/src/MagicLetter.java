import java.util.Scanner;

public class MagicLetter {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        char letterOne = console.next().charAt(0);
        char lettertwo = console.next().charAt(0);
        char letterThree = console.next().charAt(0);
        String alphabet = "abcdefghijklmnopqrstuvwxyz";
        int secondLetter = alphabet.indexOf(lettertwo);
        int firstdLetter = alphabet.indexOf(letterOne);
        for (int i=firstdLetter; i <= secondLetter; i++)
        {
            for(int j=firstdLetter; j <= secondLetter; j++)
            {
                for (int l=firstdLetter; l<=secondLetter; l++)
                {
                    if (alphabet.indexOf(letterThree) != l && alphabet.indexOf(letterThree) != j && alphabet.indexOf(letterThree) != i)
                    {
                        System.out.printf("%s",alphabet.charAt(i));
                        System.out.printf("%s",alphabet.charAt(j));
                        System.out.printf("%s ",alphabet.charAt(l));
                    }
                }
            }
        }
    }
}
