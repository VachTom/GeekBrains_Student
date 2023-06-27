import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

/**
 * sem_3
 */
public class sem_3 {
 /*
  * Создать список типа ArrayList. Поместить в него как строки, так и целые
  * числа.
  * Пройти по списку, найти и удалить целые числа.
  */
 public static void main(String[] args) {
  List<Object> array = new ArrayList<>(
    Arrays.asList("Земля", "Нептун", "Марс", 3, 4, "Земля", "Марс", "Земля", 12, "Нептун", "Земля", 6));
    for (int i = 0; i < array.size(); i++) {
     if (array.get(i)instanceof Integer) {
      array.remove(i);
      i--;
     }
    }
 System.out.println(array);
   }
}