package Work;

public class sem_2 {
 public static void main(String[] args) {
  cat slon = new cat();
  slon.name = "Слоняра";
  slon.age = 36;
  slon.sex = true;
  slon.vaccine();
  System.out.println(slon.lives_limit);
  slon.car_accident();
  slon.vaccine();
  slon.vaccine();
 }
}
