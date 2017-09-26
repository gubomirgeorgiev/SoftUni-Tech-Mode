import java.util.Scanner;

public class NeighborWars {
    public static void main(String[] args) {
        Scanner console = new Scanner(System.in);
        int stopper = 999;
        int roundhouseKick = Integer.parseInt(console.nextLine());
        int thunderousFist = Integer.parseInt(console.nextLine());
        int peshosHealth = 100;
        int goshosHealth = 100;
        int odd = 1;
        int even = 3;
        int round = 0;
        for (int i=0; i < stopper; i++)
        {
            for (int j = odd; j <=even; j++)
            {
                if (j % 2 != 0)
                {
                    round++;
                    goshosHealth -= roundhouseKick;
                    if (goshosHealth <= 0)
                    {
                        System.out.printf("Pesho won in %dth round.%n",round);
                        j += (even + 2);
                        stopper = 0;
                    }
                    else
                    {
                        System.out.printf("Pesho used Roundhouse kick and reduced Gosho to %d health.%n",goshosHealth);
                    }
                }
                else
                {
                    round++;
                    peshosHealth -= thunderousFist;
                    if (peshosHealth <= 0)
                    {
                        System.out.printf("Gosho won in %dth round.%n",round);
                        j += (even + 2);
                        stopper = 0;
                    }
                    else
                    {
                        System.out.printf("Gosho used Thunderous fist and reduced Pesho to %d health.%n",peshosHealth);
                    }
                }
            }
            odd += 3;
            even += 3;
            peshosHealth += 10;
            goshosHealth += 10;
        }
    }
}
