/*
    Clase Producto básica
    Crea una clase Producto con atributos: Nombre, descripción, precio.
    Constructor que inicialice estos valores.
    Método Datos() que muestre la información del producto.
    Crea 2-3 objetos en Main() y llama al método Datos() de cada uno.
 */

class Program
{
    static void Main(string[] args)
    {
        //Creación de 3 objetos Producto
        Producto camiseta = new Producto("Camiseta", "Camiseta de algodón", 30.50);
        Producto pantalon = new Producto("Pantalón", "Pantalón cargo", 55.99);
        Producto zapatilla = new Producto("Zapatilla", "Zapatillas deportivas", 79.90);
        //Llamada al metodo Datos() de cada objeto
        camiseta.Datos();
        pantalon.Datos();
        zapatilla.Datos();
    }
}
