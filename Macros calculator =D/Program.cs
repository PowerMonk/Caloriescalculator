class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hola ¡Por favor escribe tu nombre!");
        String name = Console.ReadLine();
        Console.WriteLine("Hola " + name + " ¡Calculemos tus macros!");

        Console.WriteLine("Tienes que usar medidas en el sistema americano ¿Deseas continuar?");
        String sistema = Console.ReadLine();
        


        switch (sistema)
        {
            case "si":
                Console.WriteLine("Perfecto");
                break;
            case "no":
                Console.WriteLine("Jajajaja vamos a continuar igual, conviertelas");
                break;
        }
     

        Console.WriteLine("Escribe tu peso en libras (1 lb = 0.453592 kg)");  
        double weight = Convert.ToDouble(Console.ReadLine()); 

        Console.WriteLine("Escribe tu altura en pulgadas (1 in = 2.54 cm) ");  
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Cuéntame ¿Cuantos años tienes?");   
        double age = Convert.ToDouble(Console.ReadLine());

        double BMR = 66 + (6.2 * weight) + (12.7 * height) - (6.76 * age);
        

        Console.WriteLine("Tu tasa metabolica basal es de: " + BMR + "calorías diarias");

        Console.WriteLine("Necesito saber tu actividad física semanal");
        Console.WriteLine("Escribe con un número la cantidad de días que haces ejercicio a la semana, si no haces ejercicio, escribe '0'");
        Console.WriteLine("Si haces ejercicio entre 3 y 5 dias a la semana, escribe '4'");
        Console.WriteLine("Si haces ejercicio 2 veces al día escribe '8'");

        string ddactividad = Console.ReadLine();

        switch (ddactividad)
        {
            case "0":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.2 + " calorías");
                break;
            case "1":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.375 + " calorías");
                break;
            case "2":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.375 + " calorías");
                break;
            case "3":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.375 + " calorías");
                break;
            case "4":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.55 + " calorías");
                break;
            case "5":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.55 + " calorías");
                break;
            case "6":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.725 + " calorías");
                break;
            case "7":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.725 + " calorías");
                break;
            case "8":
                Console.WriteLine("Combinado con  tu cantidad de actividad física, queda en " + BMR * 1.9 + " calorías");
                break;
        }

        Console.WriteLine("Requiero saber si para ti es facil o dificil subir de peso");
        Console.WriteLine("Escribe tu dificultad con los numeros del 1 al 3");
        Console.WriteLine("1 es fácil, 2 es normal (ni facil ni dificil) y 3 es dificil");

        String dificultad = Console.ReadLine();

        switch (dificultad)
        {
            case "1":
                Console.WriteLine("Para ganar peso deberás consumir las calorías que te dije +250");
                break; 
            case "2":
                Console.WriteLine("Para ganar peso deberás consumir las calorías que te dije +350");
                break;
            case "3":
                Console.WriteLine("Para ganar peso deberás consumir las calorías que te dije +500");
                break;

        }





    }
}