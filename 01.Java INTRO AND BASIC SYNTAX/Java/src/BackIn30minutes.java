    import java.util.Scanner;
    public class BackIn30minutes {
        public static void main(String[] args) {
            Scanner console = new Scanner(System.in);
            int hours = Integer.parseInt(console.nextLine());
            int minutes = Integer.parseInt(console.nextLine());
            int totalInMinutes = (hours * 60) + minutes;
            int output = totalInMinutes+30;
            if (output >= 1440)
            {
                System.out.printf("0:%02d",output-1440);
            }else{
                System.out.printf("%1d:%02d",(output/60),(output%60));
            }
        }
    }
