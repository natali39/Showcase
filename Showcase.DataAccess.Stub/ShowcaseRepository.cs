using ShowcaseWeb.Domain;
using ShowcaseWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ShowcaseWeb.DataAccess.Stub
{
    public class ShowcaseRepository : IShowcaseRepository
    {
        private List<Showcase> showcases { get; set; }

        public ShowcaseRepository()
        {
            showcases = new List<Showcase>
            {
                new Showcase("Showcase1", 50) { Id = 1, CreateDate = DateTime.Now },
                new Showcase("Showcase2", 10) { Id = 2, CreateDate = DateTime.Now },
                new Showcase("Showcase3", 23) { Id = 3, CreateDate = DateTime.Now },
            };
        }

        public void Add(Showcase showcase)
        {
            showcases.Add(showcase);
        }

        public void Delete(int showcaseId)
        {
            showcases.Remove(showcases.Where(s => s.Id == showcaseId).FirstOrDefault());

        }

        public Showcase Get(int showcaseId)
        {
            return showcases.Where(s => s.Id == showcaseId).FirstOrDefault();
        }

        public List<Showcase> Get()
        {
            return showcases;
        }

        public void Update(Showcase modifiedShowcase)
        {
            var exsistssShowcase = showcases.Where(s => s.Id == modifiedShowcase.Id).FirstOrDefault();

            exsistssShowcase.Name = modifiedShowcase.Name;
            exsistssShowcase.Volume = modifiedShowcase.Volume;
            exsistssShowcase.CreateDate = modifiedShowcase.CreateDate;
            exsistssShowcase.RemoveDate = modifiedShowcase.RemoveDate;
        }
    }
}
