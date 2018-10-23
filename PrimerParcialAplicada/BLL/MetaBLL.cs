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
    public class MetaBLL
    {
        public static bool Guardar(Meta meta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Meta.Add(meta) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;
        }

        public static bool Modificar(Meta meta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(meta).State = System.Data.Entity.EntityState.Modified;
                if (contexto.SaveChanges() > 0)
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
            Meta meta = new Meta();
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                meta = contexto.Meta.Find(id);

                if (meta != null)
                {
                    contexto.Meta.Remove(meta);
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }


            return paso;

        }

        public static Meta Buscar(int id)
        {
            Meta meta = new Meta();
            Contexto contexto = new Contexto();
            try
            {
                meta = contexto.Meta.Find(id);
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return meta;
        }

        public static List<Meta> GetList(Expression<Func<Meta, bool>> expression)
        {
            List<Meta> lista = new List<Meta>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.Meta.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) { throw; }


            return lista;
        }
    }
}
