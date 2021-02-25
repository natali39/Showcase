using ShowcaseWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowcaseWeb.Domain
{
    public interface IShowcaseRepository
    {
        void Add(Showcase showcase);
        Showcase Get(int showcaseId);
        List<Showcase> Get();
        void Update(Showcase showcase);
        void Delete(int showcaseId);
    }
}
