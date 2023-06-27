import java.sql.Array;
import java.util.ArrayList;
import java.util.Arrays;

public class sem_2 {
 public static void main(String[] args) {
  ArrayList<String> arr = new ArrayList<>(
    Arrays.asList("Земля", "Нептун", "Марс", "Земля", "Марс", "Земля", "Венера", "Нептун", "Земля", "Нептун"));
  System.out.println(arr);
  ArrayList<String> arr2 = new ArrayList<>();
  int count = 1;
  for (int i = 0; i < arr.size() - 1; i++) {
   if (!arr2.contains(arr.get(i))) {// contains - наличие
    arr2.add(arr.get(i));
    count = 1;
    for (int j = i + 1; j < arr.size(); j++) {
     if (arr.get(i) == arr.get(j)) {
      count += 1;
     }
    }
    System.out.println(arr.get(i) + " " + count);
   }
  }
 }
}