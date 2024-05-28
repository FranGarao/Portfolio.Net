namespace Portfolio_Web.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public int Age { get; set; }

        public int Sumar(int a, int b)
        {
            return a + b;
        }
            public int Sumar(int a, int b, int c) =>  a + b + c;
            public decimal Sumar(decimal a, decimal b, decimal c) =>  a + b + c;

    }
}
