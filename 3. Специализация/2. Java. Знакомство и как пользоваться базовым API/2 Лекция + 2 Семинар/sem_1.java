/**
План урока:
— Повторить теорию о String, StringBuilder, File, Exception Handling, Logging, Import
— Получить практические навыки в работе с файловой системой и файлами, обработке исключений и логировании, работой со строками
— Научиться составлять программы с логированием и корректной обработкой исключений
 */
public class sem_1 {

 public static void main(String[] args) {

  // Дано четное число N (>0) и символы с1 и с2. Написать метод,
  // который вернет строку длины N,
  // которая состоит из чередубщихся символов с1 и с2, начиная с с1.
  String stroka = "asdfg";
  StringBuilder sb = new StringBuilder(stroka);
  sb.append("!");
  sb.append(stroka).append("Se");
  System.out.println(sb.toString()); // переводит к строке, как я понимаю конвертация

 }



  public static void Fs(){

  }
}