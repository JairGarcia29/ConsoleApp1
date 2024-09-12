internal class Program
{
    private static void Main(string[] args)
    {
        // Realizar un programa que permita registrar una contraseña y luego validar  si es correcto(solo tiene 3 intentos), si es incorrecto cerrar el programa.//
        int intentos=0;
        string contra = "";
        string Contraseña;
        while (intentos <= 3)
        {
            Console.WriteLine("Ingrese la contraseña");
            contra = Console.ReadLine();
            if(contra == "Contraseña") {
                Console.WriteLine("Bienvenido a tu perfil");
                Console.WriteLine("Haz ingresado.....");
                intentos = 4;
            }
            else
            {
                Console.WriteLine("ERRORRRRRRRRRR....");
                Console.WriteLine("Tu cuenta a sido bloqueada");                
            }
        }
    }
}