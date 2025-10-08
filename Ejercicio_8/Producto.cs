class Producto
{
    // Atributos
    private string _nombre = "";
    private string _descripcion = "";
    private double _precio = 0;

    // Constructor
    public Producto(string nombre, string descripcion, double precio)
    {
        _nombre = nombre;
        _descripcion = descripcion;
        _precio = precio;
    }

    // Propiedades
    public string Nombre
    {
        get { return _nombre; }
        set { _nombre = value; }
    }

    public string Descripcion
    {
        get { return _descripcion; }
        set { _descripcion = value; }
    }

    public double Precio
    {
        get { return _precio; }
        set
        {
            if (value < 0)
                throw new ArgumentException("El precio no puede ser negativo.");
            _precio = value;
        }
    }

    // Método Datos()
    public virtual void Datos()
    {
        Console.WriteLine($"Nombre: {_nombre}\nDescripción: {_descripcion}\nPrecio: {_precio:F2}");
    }
}