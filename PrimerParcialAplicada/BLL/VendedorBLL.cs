using PrimerParcialAplicada.DAL;
using PrimerParcialAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcialAplicada.BLL
{
    public class VendedorBLL
    {
        public static bool Guardar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Vendedor.Add(vendedor) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool Modificar(Vendedor vendedor)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(vendedor).State = System.Data.Entity.EntityState.Modified;
                if(contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            Vendedor vendedor = new Vendedor();
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                vendedor = contexto.Vendedor.Find(id);
                
                if(vendedor != null)
                {
                    contexto.Vendedor.Remove(vendedor);
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }


            return paso;

        }

        public static Vendedor Buscar(int id)
        {
            Vendedor vendedor = new Vendedor();
            Contexto contexto = new Contexto();
            try
            {
                vendedor = contexto.Vendedor.Find(id);
                if (vendedor != null)
                {
                    vendedor.Detalles.Count();
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return vendedor;
        }

        public static List<Vendedor> GetList(Expression<Func<Vendedor, bool>> expression)
        {
            List<Vendedor> lista = new List<Vendedor>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Vendedor.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }


            return lista;
        }
    }


    

}
