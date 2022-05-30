public class Password
{

    private int longitud;   //-----------Atributos
    private String contraseña;

    public Password() {   //-----------Constructores
        longitud =8;
    }
    
    public Password(int long) {
        longitud =long;
    }

    private String ListaPass[] PassToList(string password) {
        List<char[]> lista = new ArrayList<char[]>();

    }

    private boolean MayusculasOk() {   //-----------Métodos privados

    }

    public boolean esFuerte()   //-----------Métodos publicos
    { arrCarFrt = new ArrayList();
        
    }

    public String metodo2()
    {
        return "metodo2";
    }
}

public static void main(String[] args)
{
    //Creamos un animal cuyo nombré será Falco
    Animal miAnimal = new Animal("Falco");
    //Le establecemos 3 años de edad a Falco.
    miAnimal.setEdad(3);
    //Mostraremos el nombre del animal por pantalla
    System.out.println("El nombre es: " + miAnimal.getNombre());
    //Mostramos la edad del animal por pantalla
    System.out.println(" y tiene " + miAnimal.getEdad() + " años");
    //Este código deberia imprimir "El nombre es: Falco y tiene 3 años"
}