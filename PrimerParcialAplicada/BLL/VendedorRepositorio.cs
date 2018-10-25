using PrimerParcialAplicada.DAL;
using PrimerParcialAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcialAplicada.BLL
{
    public class VendedorRepositorio : RepositorioBase<Vendedor>
    {
        public override bool Guardar(Vendedor entity)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                Meta meta = null;
                entity.Detalles.Count();
                
                foreach (var item in entity.Detalles)
                {
                    meta = MetaBLL.Buscar(item.MetaId);
                    meta.Cuota -= item.Cuota;
                }
                MetaBLL.Modificar(meta);
                //Probar con el repositorio
                if (contexto.Vendedor.Add(entity) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }
            return paso;

        }

        public override bool Modificar(Vendedor entity)
        {
           
            bool paso = false;
            
            try
            {

                var Anterior = new VendedorRepositorio().Buscar(entity.VendedorId);
                if (Anterior.Detalles.Count() > entity.Detalles.Count())
                {
                    
                    foreach (var item in Anterior.Detalles)
                    {
                        if (!entity.Detalles.Exists(d => d.MetaDetalleId == item.MetaDetalleId))
                        {
                           
                            Meta meta = MetaBLL.Buscar(item.MetaId);
                            meta.Cuota += item.Cuota;
                            _contexto.Entry(item).State = EntityState.Deleted;

                        }
                    }
                }
                
                Vendedor Antes = new RepositorioBase<Vendedor>().Buscar(entity.VendedorId);
                Antes.Detalles.Count();
                for (int i = 0; i < entity.Detalles.Count(); i++)
                {
                    

                    EntityState estado = (entity.Detalles[i].MetaDetalleId == 0) ? EntityState.Added : EntityState.Modified;
                    Meta meta = MetaBLL.Buscar(entity.Detalles[i].MetaId);

                    if (estado == EntityState.Modified)
                    {
                        
                        if (Antes.Detalles[i].Cuota > entity.Detalles[i].Cuota)
                        {
                            
                            meta.Cuota -= meta.Cuota - entity.Detalles[i].Cuota;
                        }
                        else if (Antes.Detalles[i].Cuota < entity.Detalles[i].Cuota)
                        {
                            meta.Cuota += entity.Detalles[i].Cuota - meta.Cuota;
                           
                        }


                    }
                    else if (estado == EntityState.Added)
                    {
                        //Esto era que estaba malo porque estaba sumando en lugar de restar -_-"
                        meta.Cuota -= entity.Detalles[i].Cuota;
                    }

                    MetaBLL.Modificar(meta);

                }




                _contexto.Entry(entity).State = EntityState.Modified;
                paso = _contexto.SaveChanges() > 0;


            }
            catch (Exception) { throw; }
            finally
            {
                _contexto.Dispose();
            }
            return paso;
        }

        public override Vendedor Buscar(int id)
        {
            Vendedor vendedor = new Vendedor();
            Contexto contexto = new Contexto();
            try
            {
                vendedor = contexto.Vendedor.Find(id);
                vendedor.Detalles.Count();
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return vendedor;
        }
    }
}
