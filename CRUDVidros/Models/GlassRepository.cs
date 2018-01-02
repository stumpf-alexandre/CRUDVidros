using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using CRUD.Models;

namespace CRUD.Models
{
    public class GlassRepository : IGlassRepositore
    {
       private DataContext context;

       public GlassRepository(DataContext context){
           this.context=context;
       }

       public void Create(Glass glass){
           context.Glasses.Add(glass);
           context.SaveChanges();
       }

       public void Delete(long id){
           context.Glasses.Remove(GetById(id));
           context.SaveChanges();
       }

       public void Update(Glass glass){
           context.Entry(glass).State=EntityState.Modified;
           context.SaveChanges();
       }

       public Glass GetById(long id){
           return context.Glasses.SingleOrDefault(x=>x.id==id);
       }

       public List<Glass> GetAll(){
           return context.Glasses.ToList();
       }
    }
}