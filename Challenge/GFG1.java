
// Java program to demonstrate
// removeAll() method for Integer value
  
import java.util.*;
import java.util.regex.Matcher;
import java.util.regex.Pattern;
import java.lang.*;

public class GFG1 {

    private int contarMayusc(String pwd) {
        short ind;
        if (pwd.length() > 0) {
            if (pwd[0] in ['a'-'z']) {
                
            }
            if (String(pwd[0]).con includes("A"-"Z")) { 
                system.out.println("Si");
            }
            else {
                system.out.println("No");
            }
            /*if (pwd[0] in ['A'-'Z']) {
                return 1 + contarMayusc(pwd.substring(1)); }
            else {
                return contarMayusc(pwd.substring(1)); }*/
        }
    }

    public static void main(String[] argv) throws Exception
    {
  

        string p = "ABcd";
        
        System.out.println(p + " " + contarMayusc(p));
    }
}
//        try {
  
            // Creating object of ArrayList<Integer>
          /*  ArrayList<char[]>
                arrlist1 = new ArrayList<char[]>();
  
        /*    arrlist1.add('T');
            arrlist1.add('r');
            arrlist1.add('u');
            arrlist1.add('s');
            arrlist1.add('t');
            arrlist1.add('n');
            arrlist1.add('o');
            arrlist1.add('1');*/
            
  //          String pass = "99tgAFCd1243f";
            
        //    Pattern pat = Pattern.compile("^[\\w-]+(\\.[\\w-]+)*@[A-Za-z0-9]+(\\.[A-Za-z0-9]+)*(\\.[A-Za-z]{2,})$"); 
  /*          Pattern pat1 = Pattern.compile("[A-Z]{3,}");
            Pattern pat2 = Pattern.compile("[a-z]{1,}");
            Pattern pat3 = Pattern.compile("[0-9]{4,}");
            Matcher mat1 = pat1.matcher(pass);
            Matcher mat2 = pat2.matcher(pass);
            Matcher mat3 = pat3.matcher(pass);
            
            if (mat1.find() && mat2.find() && mat3.find()) {
                System.out.println("Pasó");
            }
            else {
                System.out.println("No pasó");
            }
/*
            // print arrlist1
            System.out.println("ArrayList before "
                               + "removeAll() operation : "
                               + arrlist1);
  
            // Creating another object of  ArrayList<Integer>
            ArrayList<Integer>
                arrlist2 = new ArrayList<char[]>('A'-'Z');
            
            // print arrlist2
            System.out.println("Collection Elements"
                               + " to be removed : "
                               + arrlist2);
  
            // Removing elements from arrlist
            // specified in arrlist2
            // using removeAll() method
            arrlist1.removeAll(arrlist2);
  
            // print arrlist1
            System.out.println("ArrayList after "
                               + "removeAll() operation : "
                               + arrlist1);
        }
      }
        catch (NullPointerException e) {
            System.out.println("Exception thrown : " + e);
        }*/
    /*}
}*/