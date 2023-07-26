
public class Usuario{

    public string Nombre {set;get;}
    public int Edad {set; get;}
    public string Hobbie {set;get;}
    public Usuario(int edad, string nombre, string hobbie){
        Edad = edad;
        Nombre = nombre;
        Hobbie = hobbie;
    }

}

internal class Program{

    public static void Main(string[] args){

    Dictionary<int, object> usuarios = new Dictionary<int, object>();
    bool next = true;

    void AddUser(){
        Console.Write("Ingrese el nùmero de identidad: ");
        int id = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el nombre: ");
        string ? nombre = Console.ReadLine();
        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine());
        Console.Write("Ingrese el hobbie: ");
        string ? hobbie = Console.ReadLine();

        Usuario user = new Usuario(edad,nombre,hobbie);

        usuarios.Add(id, user);

    }

    void ShowUsers(){
        foreach(var user in usuarios){
            //Por terminar 
            Console.WriteLine(user.Key.ToString(), user.Value);
        }
    }


    do{
      Console.ForegroundColor = ConsoleColor.Blue;
      Console.WriteLine("\n ========== MENÚ ========== \n");
      Console.ResetColor();
      Console.Write("1.Agregar nuevo usuario. \n"+
                    "2.Mostrar usuario. \n"+
                    "3.Mostras usuarios. \n"+
                    "4.Eliminar usuario. \n"+
                    "0.Salir.\n");

      int ? select = int.Parse(Console.ReadLine());

      switch(select){
        case 1:
          AddUser();
        break;
        case 2: 
          ShowUsers(); 
        break;
        case 3:
          //ImportantSelect();          
        break;
        case 4:
          //ShowContacts(directoryImportant);
        break;
        case 0: 
            next = false;
        break;
      }
      
    }while(next);

    }

}
