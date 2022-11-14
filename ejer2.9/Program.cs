namespace ejerciciodosnueve
{
    public class sueldo
    {
        public static void Main()
        {
            int SS, CH, VH;
            Console.WriteLine("Dijite las horas trabajadas");
            CH= int.Parse(Console.ReadLine());
            Console.WriteLine("Dijite el valor de la hora");
            VH= int.Parse(Console.ReadLine());
            SS = CH * VH;
            Console.WriteLine($"El valor de la semana es : {SS}");

        }
    }
}
