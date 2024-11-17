using System;
using System.Linq;

public class HelloWorld
{
    
     static string[] pokemons = { "Bulbasaur", "Charmander", "Squirtle", "Pikachu", "Jigglypuff", "Meowth", "Psyduck", "Machop", "Geodude", "Slowpoke", "Gastly", "Onix", "Cubone", "Rhyhorn", "Magikarp", "Eevee", "Snorlax", "Dratini", "Mewtwo", "Chikorita" }; //the library that contains the array
    static Random rnd = new Random(); //Definition of random in this script
    static string [] pokAsh = pokemons.OrderBy(x => rnd.Next()).Take(5).ToArray(); //select a 5 randoms pokemons from array
    static string [] pokGary = pokemons.Except(pokAsh).OrderBy(x => rnd.Next()).Take(5).ToArray(); //select a 5 randoms pokemons from array without the 5 before pokemons
        
    
    
    public static void Main(string[] args) //Main function in the script
    {
        menu();
    }
    
    
    static void menu() //Menu function
    {
               int op;
        do{
            Console.WriteLine("=====================================");
            Console.WriteLine("       Welcome to the program");
            Console.WriteLine("\n=====================================");
            Console.WriteLine("             1. ShowTeams");
            Console.WriteLine("=====================================");
            Console.WriteLine("             0. Exit");
            Console.WriteLine("=====================================");
            Console.Write("         Selecte an option\n");
            op = user_op(); //Call a user_op where it cheacking the answer if it's a correct character or invalid
        }while(op == 0);
        if(op == 1){
            Console.WriteLine("=====================================");
            Console.WriteLine("              Characters");
            Console.WriteLine("\n=====================================");
            Console.WriteLine("             1. Gary");
            Console.WriteLine("=====================================");
            Console.WriteLine("             0. Ash");
            Console.WriteLine("=====================================");
            Console.Write("         Selecte a character\n");
            int character_op = user_op(); //Call a user_op where it cheacking the answer if it's a correct character or invalid
            showteams(op,character_op); //Send variables to a function

        }

    }
    
    
    
    static void showteams(int op, int character_op) //Function take variables
    {
        if(character_op == 1){
            Console.WriteLine("Team Gary: " + string.Join(", ", pokGary));  //"string.Join" it's used for write in the same line the content from array, where we can put what was between the variables and we could select their positions
            }else{
            Console.WriteLine("Team Ash: " + string.Join(", ", pokAsh));
        }
    }
    
    
    static int user_op()
    {
        while(true){ //Infinite bucle, but in this case we have a manual stop for it, a "return"
        try{ //It's used like if | else if | else, but for exceptions or errors
            int op = Convert.ToInt32(Console.ReadLine()); 
            if(op == 0 || op == 1){ //if the answer its 0 or 1, the program return the data where is came from
                return op;
            }else{ //if it's another number do this:
                Console.WriteLine("Select a correct number (1 or 0)");
            }
            }catch(Exception){ //finally, in variable  int we cannot use a letters, this is one example of a catch bloq. There comes all of things cannot be in a try part
            Console.WriteLine("Select a number, not another's characters");
        }
        }
    } 
}

