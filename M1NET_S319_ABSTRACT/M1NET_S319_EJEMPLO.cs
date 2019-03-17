using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1NET_S319_ABSTRACT
{
    class M1NET_S319_EJEMPLO
    {
    }

    interface IApliDescuento {
        void Descuento();
        void DescuentoCumpleaños();
    }

    abstract class Mantto {
        public abstract void insertar();
        public abstract void eliminar();
        public abstract void editar();        
    }

    class Empleados : Mantto,IApliDescuento
    {
        public void Descuento()
        {
            throw new NotImplementedException();
        }

        public void DescuentoCumpleaños()
        {
            throw new NotImplementedException();
        }

        public override void editar()
        {
            throw new NotImplementedException();
        }

        public override void eliminar()
        {
            throw new NotImplementedException();
        }

        public override void insertar()
        {
            throw new NotImplementedException();
        }
    }
    class Proveedores : Mantto
    {
        public override void editar()
        {
            throw new NotImplementedException();
        }

        public override void eliminar()
        {
            throw new NotImplementedException();
        }

        public override void insertar()
        {
            throw new NotImplementedException();
        }
    }
    class Conyuges : Mantto
    {
        public override void editar()
        {
            throw new NotImplementedException();
        }

        public override void eliminar()
        {
            throw new NotImplementedException();
        }

        public override void insertar()
        {
            throw new NotImplementedException();
        }
    }


}
