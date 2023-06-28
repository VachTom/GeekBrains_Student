import java.util.ArrayList;
import java.util.LinkedList;
import java.util.Random;

/**
 * sem_1
 */
public class sem_1 {
 public static void main(String[] args) {
  Random rand = new Random();
  long timeStart = System.currentTimeMillis();
  ArrayList<Integer> list1 = new ArrayList<Integer>();
  for (int i = 0; i < 100000; i++) {
   int val = rand.nextInt(-100, 100);
   list1.add(0, val);
  }
  long timeEnd = System.currentTimeMillis();
  System.out.println(timeEnd - timeStart);




  long timeStart2 = System.currentTimeMillis();
  LinkedList<Integer> list2 = new LinkedList<Integer>();
  for (int i = 0; i < 100000; i++) {
   int val = rand.nextInt(-100, 100);
   list2.add(0, val);
  }
  long timeEnd2 = System.currentTimeMillis();
  System.out.println(timeEnd2 - timeStart2);

 }
}