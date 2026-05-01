using Dsw2026Ej8;
using System;

class Program
{
    static void Main(string[] args)
    {
        // =========================
        // PROBLEMA 1
        // =========================
        Console.WriteLine("=== Problema 1 ===");
        ProductHelper helper = new ProductHelper();
        Console.WriteLine(helper.ObtenerEtiquetaProducto(1001, "Mouse Gamer", 2500.50m));

        // =========================
        // PROBLEMA 2
        // =========================
        Console.WriteLine("\n=== Problema 2 ===");
        Problema2 p2 = new Problema2();
        Console.WriteLine(p2.CrearResumenVenta(2002, "Teclado MecÃ¡nico", 3, 1500m));

        // =========================
        // PROBLEMA 3
        // =========================
        Console.WriteLine("\n=== Problema 3 ===");
        Product product = new Product("Monitor LED");
        Problema3 p3 = new Problema3();
        Console.WriteLine(p3.CompararCopias(10, product));

        // =========================
        // PROBLEMA 4
        // =========================
        Console.WriteLine("\n=== Problema 4 ===");
        Problema4 p4 = new Problema4();

        Console.WriteLine($"Promedio 1: {p4.CalcularPromedio(8, 6, 10)}");
        Console.WriteLine($"Promedio 2: {p4.CalcularPromedio(8, null, 6)}");
        Console.WriteLine($"Promedio 3: {p4.CalcularPromedio(null, null, null)}");
        Console.WriteLine($"Promedio 4: {p4.CalcularPromedio(8, -1, 15)}");

        // =========================
        // PROBLEMA 5
        // =========================
        Console.WriteLine("\n=== Problema 5 ===");
        Problema5 p5 = new Problema5();

        Sale retail = new RetailSale(1000m);
        Sale wholesale = new WholesaleSale(1000m);

        Console.WriteLine($"Retail Sale: {p5.ObtenerImporteFinal(retail)}");
        Console.WriteLine($"Wholesale Sale: {p5.ObtenerImporteFinal(wholesale)}");

        // =========================
        // PROBLEMA 6
        // =========================
        Console.WriteLine("\n=== Problema 6 ===");
        Problema6 p6 = new Problema6();

        Console.WriteLine(p6.NormalizarCodigoProducto(" ab 123 x "));
        Console.WriteLine(p6.NormalizarCodigoProducto(null));
    }
}