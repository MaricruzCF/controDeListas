namespace ControlDeLista
{
    class Producto
    {
        public Producto Siguiente;

        private int codigo;
        public int Codigo { get { return codigo; } }

        private string nombre;
        public string Nombre { get { return nombre; } }

        private string descripcion;
        public string Descripcion { get { return descripcion; } }

        private int cantidad;
        public int Cantidad { get { return cantidad; } }

        private float costo;
        public float Costo { get { return costo; } }

        public Producto(int codigo, string nombre, string descripcion, int cantidad, float costo)
        {
            this.codigo = codigo;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.costo = costo;
        }
        public override string ToString()
        {
            return "codigo: " + codigo + ", " +
                "nombre: " + nombre + ", " +
                "descripcion: " + descripcion + ", " +
                "cantidad: " + cantidad + ", " +
                "costo: " + costo + System.Environment.NewLine;
        }

    }
}
