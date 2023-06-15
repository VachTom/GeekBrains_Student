import java.io.File;
import java.io.FileReader;
// import java.io.FileWriter;

/**
 * sem_4
 */
public class sem_4 {

 public static void main(String[] args) {

  String text = "TEST";
  try {
   FileWriter writer = new FileWriter("file.txt", true);
   for (int i = 0; i < 10; i++) {
    writer.write(text + "\n");

   }

   System.out.println("Получилось!");
   writer.close();
  } catch (Exception e) {
   System.out.println("Что то пошло не так..");
  }


File fl = new File("file.txt");
  try {
   FileReader file = new FileReader(fl);
   char[] arr = new char[(int) fl.length()];
   file.read(arr);
   for (char c : arr) {
    System.out.print(c);
   }
   file.close();
  } catch (Exception e) {
   System.out.println("Что то пошло не так..");
  }

 }
}