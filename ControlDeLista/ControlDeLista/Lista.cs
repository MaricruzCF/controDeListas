namespace ControlDeLista
{
    class Lista
    {
        private Producto _primero = null;

        public void Agregar(Producto prod)
        {
            if (_primero == null)
                _primero = prod;
            else
            {
                Producto temp = _primero;
                while (temp.Siguiente != null)
                    temp = temp.Siguiente;
                temp.Siguiente = prod;
            }
        }


        public Producto Buscar(int codigo)
        {
            Producto temp = _primero;
            while (temp != null)
            {
                if (temp.Codigo == codigo)
                    return temp;
                temp = temp.Siguiente;
            }
            return null;
        }

        public void Eliminar(int codigo)
        {
            if (_primero != null)
            {
                if (_primero.Codigo == codigo)
                {
                    Producto temp = _primero;
                    _primero = _primero.Siguiente;
                }
                else
                {
                    Producto anterior = _primero;
                    Producto actual = _primero.Siguiente;
                    while (actual != null)
                    {
                        if (actual.Codigo == codigo)
                        {
                            anterior.Siguiente = actual.Siguiente;
                            return;
                        }
                        anterior = actual;
                        actual = actual.Siguiente;
                    }
                }
            }
        }

        public void InvertirLista()
        {
            Producto anterior = null;
            Producto actual = _primero;
            Producto siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Siguiente;
                actual.Siguiente = anterior;
                anterior = actual;
                actual = siguiente;
            }

            _primero = anterior;
        }
        
        public void AgregarInicio(Producto prod)
        {
            if (_primero == null)
                _primero = prod;
            else
            {
                prod.Siguiente = _primero;
                _primero = prod;
            }
        }
        
        public void EliminarPrimero()
        {
            if (_primero != null)
                _primero = _primero.Siguiente;
        }
        
        public void EliminarUltimo()
        {
            if (_primero != null)
            {
                Producto anterior = null;
                Producto actual = _primero;
                while (actual.Siguiente != null)
                {
                    anterior = actual;
                    actual = actual.Siguiente;
                }
                actual = null;
            }
        }

        public string ReporteInverso()
        {

            int numElementos = 0;
            Producto temp = _primero;
            while (temp != null)
            {
                numElementos++;
                temp = temp.Siguiente;
            }


            string[] lista = new string[numElementos];
  
            temp = _primero;
            int i = 0;
            while (temp != null)
            {
                lista[i++] = temp.ToString();
                temp = temp.Siguiente;
            }

            string str = "";
            for (i = lista.Length - 1; i >= 0; i--)
                str += lista[i] + "," + System.Environment.NewLine;
            return str;
        }

        public override string ToString()
        {
            string str = "";
            Producto temp = _primero;
            while (temp != null)
            {
                str += temp.ToString() + "," + System.Environment.NewLine;
                temp = temp.Siguiente;
            }
            return str;
        }



    }
}
