using ShowcaseWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowcaseWeb.Domain
{
    public interface IShowcaseService
    {
        bool Add(Showcase showcase);
        List<Showcase> Get();
        Showcase Get(int showcaseId);
        bool Edit(Showcase showcase);
    }
}
