import java.util.Scanner;
import java.io.*;
import java.util.*;
//jan 21 2022

public class Main {
    public static Scanner s = new Scanner(System.in);
    public static void main(String[] args) {
        String s1 = s.nextLine();
        String s2 = s.nextLine();

        char s1l = s1.toLowerCase().charAt(0);
        String s2l = s2.toLowerCase();

        System.out.println(count(s1l, s2l));
    }

    public static int count (char c, String s){
      
      int total = 0;

      for (int i = 0; i < s.length(); i++){
        if (c == s.charAt(i)){
          total++;
        }
      }

      return(total);
    }
}