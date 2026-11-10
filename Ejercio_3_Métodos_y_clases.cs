using System;

class Cliente
{
    private string nombre;
    private double cantidadTotal;

    public Cliente(string nombre)
    {
        this.nombre = nombre;
        cantidadTotal = 0;
    }

    public void Ingresar(double cantidad)
    {
        cantidadTotal += cantidad;
    }

    public void Sacar(double cantidad)
    {
        cantidadTotal -= cantidad;
    }

    public double GetCantidadTotal()
    {
        return cantidadTotal;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"{nombre} tiene {cantidadTotal} € en su cuenta");
    }
}

class Banco
{
    private Cliente[] clientes;

    public Banco()
    {
        clientes = new Cliente[3];
        clientes[0] = new Cliente("Ana");
        clientes[1] = new Cliente("Luis");
        clientes[2] = new Cliente("Marta");
    }

    public void Operar()
    {
        clientes[0].Ingresar(100);
        clientes[1].Ingresar(250.5);
        clientes[2].Ingresar(75);
    }

    public void ObtenerEstado()
    {
        double total = 0;
        for (int i = 0; i < clientes.Length; i++)
        {
            total += clientes[i].GetCantidadTotal();
        }

        Console.WriteLine($"Dinero total ingresado en el banco: {total} €");
        for (int i = 0; i < clientes.Length; i++)
        {
            clientes[i].MostrarInformacion();
        }
    }
}

class Program
{
    static int ContarEspacios(string texto)
    {
        int espacios = 0;
        for (int i = 0; i < texto.Length; i++)
        {
            if (texto[i] == ' ')
            {
                espacios++;
            }
        }
        return espacios;
    }

    static long Factorial(int numero)
    {
        if (numero <= 1)
        {
            return 1;
        }
        return numero * Factorial(numero - 1);
    }

    static bool EsPrimo(int numero)
    {
        if (numero < 2)
        {
            return false;
        }
        for (int i = 2; i < numero; i++)
        {
            if (numero % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static double PotenciaIterativa(double baseNumero, int exponente)
    {
        double resultado = 1;
        for (int i = 0; i < exponente; i++)
        {
            resultado *= baseNumero;
        }
        return resultado;
    }

    static double PotenciaRecursiva(double baseNumero, int exponente)
    {
        if (exponente == 0)
        {
            return 1;
        }
        return baseNumero * PotenciaRecursiva(baseNumero, exponente - 1);
    }

    static bool Login(string usuario, string contrasena)
    {
        return usuario == "usuario2DAM" && contrasena == "pass2DAM";
    }

    static bool EsMultiplo(int numero1, int numero2)
    {
        return numero1 % numero2 == 0;
    }

    static int SumaDigitos(int numero)
    {
        int suma = 0;
        numero = Math.Abs(numero);
        while (numero > 0)
        {
            suma += numero % 10;
            numero /= 10;
        }
        return suma;
    }

    static int PosicionMenor(int[] numeros)
    {
        int posicion = 0;
        for (int i = 1; i < numeros.Length; i++)
        {
            if (numeros[i] < numeros[posicion])
            {
                posicion = i;
            }
        }
        return posicion;
    }

    static void Main()
    {
        Console.WriteLine("Ejercicio 1");
        Console.Write("Tamaño del array: ");
        int tamano = int.Parse(Console.ReadLine());
        int[] numeros = new int[tamano];
        int suma = 0;
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Introduce el valor {i + 1}: ");
            numeros[i] = int.Parse(Console.ReadLine());
            suma += numeros[i];
        }
        Console.WriteLine($"La suma es {suma}");
        Console.WriteLine($"La media es {(double)suma / numeros.Length}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 2");
        Console.Write("Introduce una cadena de texto: ");
        string cadena = Console.ReadLine();
        Console.WriteLine($"Número de espacios en blanco: {ContarEspacios(cadena)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 3");
        Console.Write("Introduce un número: ");
        int numeroFactorial = int.Parse(Console.ReadLine());
        Console.WriteLine($"El factorial de {numeroFactorial} es {Factorial(numeroFactorial)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 4");
        Console.Write("Introduce un número: ");
        int numeroPrimo = int.Parse(Console.ReadLine());
        if (EsPrimo(numeroPrimo))
        {
            Console.WriteLine($"{numeroPrimo} es primo");
        }
        else
        {
            Console.WriteLine($"{numeroPrimo} no es primo");
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 5");
        Console.Write("Introduce la base: ");
        double baseNumero = double.Parse(Console.ReadLine());
        Console.Write("Introduce el exponente: ");
        int exponente = int.Parse(Console.ReadLine());
        Console.WriteLine($"Potencia iterativa: {PotenciaIterativa(baseNumero, exponente)}");
        Console.WriteLine($"Potencia recursiva: {PotenciaRecursiva(baseNumero, exponente)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 6");
        int intentos = 0;
        bool accesoCorrecto = false;
        while (intentos < 3 && !accesoCorrecto)
        {
            Console.Write("Usuario: ");
            string usuario = Console.ReadLine();
            Console.Write("Contraseña: ");
            string contrasena = Console.ReadLine();
            accesoCorrecto = Login(usuario, contrasena);
            intentos++;
            if (!accesoCorrecto && intentos < 3)
            {
                Console.WriteLine("Usuario o contraseña incorrectos");
            }
        }
        if (accesoCorrecto)
        {
            Console.WriteLine("Acceso concedido");
        }
        else
        {
            Console.WriteLine("Has agotado los tres intentos");
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 7");
        Console.Write("Introduce el primer número: ");
        int multiplo1 = int.Parse(Console.ReadLine());
        Console.Write("Introduce el segundo número: ");
        int multiplo2 = int.Parse(Console.ReadLine());
        if (EsMultiplo(multiplo1, multiplo2))
        {
            Console.WriteLine($"{multiplo1} es múltiplo de {multiplo2}");
        }
        else if (EsMultiplo(multiplo2, multiplo1))
        {
            Console.WriteLine($"{multiplo2} es múltiplo de {multiplo1}");
        }
        else
        {
            Console.WriteLine("Ninguno es múltiplo del otro");
        }
        Console.WriteLine();

        Console.WriteLine("Ejercicio 8");
        Console.Write("Introduce un número: ");
        int numeroDigitos = int.Parse(Console.ReadLine());
        Console.WriteLine($"La suma de los dígitos es {SumaDigitos(numeroDigitos)}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 9");
        int[] valores = { 42, 7, 19, 3, 88, 25, 61, 14, 50, 9 };
        int posicionMenor = PosicionMenor(valores);
        Console.WriteLine($"El menor es {valores[posicionMenor]} y está en la posición {posicionMenor}");
        Console.WriteLine();

        Console.WriteLine("Ejercicio 10");
        Banco banco = new Banco();
        banco.Operar();
        banco.ObtenerEstado();
    }
}
