using PrimerParcialAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
echo "# PrimerParcialAplicada1" >> README.md
git init
git add README.md
git commit -m "first commit"
git remote add origin https://github.com/JarvisFullStack/PrimerParcialAplicada1.git
git push -u origin master 
*/
namespace PrimerParcialAplicada.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Vendedor> Vendedor { get; set; }
        public DbSet<Meta> Meta { get; set; }
        public Contexto() : base("ConStr") { }

    }
}
