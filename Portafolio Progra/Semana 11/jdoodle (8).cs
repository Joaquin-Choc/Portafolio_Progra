using System;

class Libro
{
    string nombre;
    int codigo = 200;
    bool estado = true;
    int capacidad;
    int pag = 0, lpag = 0;
    double porcentaje = 0;
    
    public void Leer(int pag, int lpag, bool estado)
    {
        lpag++;
        
        if(lpag == pag)
        {
            estado = true;
        }else if(lpag < pag){
            Console.WriteLine("La cantidad de páginas llegó a su limite");
        }
    }
    
    public double tenerPorcentaje(int lpag, int pag, double porcentaje)
    {
        porcentaje = ((double)lpag/pag) * 100;
        return porcentaje;
    }
    
    public int paginaActual(int lpag){
        return lpag;
    }
    
    public void mostrarLibro()
    {
        string texto = codigo+" Código"+nombre+" Nombre del libro"+pag+"Cantida de páginas"+porcentaje+
                                " Porcentaje leido"+lpag+" Páginas leidas";
        Console.WriteLine(texto);
    }
    
    public string estadoLibro(int lpag)
    {
        if (lpag == pag)
        {
            estado = "Leido";
        }
         if (pag && lpag > 0){
            estado = "En proceso";
        }else if (lpag < 0){
            estado = "No leido";
        }
    }
    
    static void Main() {
        
        Libro l = new Libro();
        
        Console.WriteLine("Ingrese el nombre del libro");
        l.nombre = Console.ReadLine();
        
        Console.WriteLine("Ingrese el código del libro");
        l.codigo = ConvertToInt32(Console.ReadLine());
        
        l pág = 500;
        l lpag = 300;
        
        l.mostrarLibro;
        l.estadoLibro;
        
        
    }
}