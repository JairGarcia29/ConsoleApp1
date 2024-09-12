internal class Program
{
    private static void Main(string[] args)
    {
        // Realizar un programa que permita registrar una contraseña y luego validar  si es correcto(solo tiene 3 intentos), si es incorrecto cerrar el programa.//
        int intentos=1;
        string contra = "";
        string JAMES29;
        while (intentos <= 3)
        {
            Console.WriteLine("Ingrese la contraseña");
            contra = Console.ReadLine();
            if(contra == "JAMES29") {
                Console.WriteLine("Bienvenido a tu perfil");
                Console.WriteLine("Haz ingresado.....");
                intentos = 4;
            }
            else
            {
                if (intentos == 3)
                {
                    Console.WriteLine("PROGRAMA BLOQUEADO");
                    Console.WriteLine("HAS AGOTADO TUS INTENTOS");
                } 
            }
            intentos++;
        }
    }
}