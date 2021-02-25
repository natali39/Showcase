using ShowcaseWeb.Domain;
using ShowcaseWeb.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShowcaseWeb.Application.Services
{
    public class ShowcaseService : IShowcaseService
    {
        private readonly IShowcaseRepository showcaseRepository;

        public ShowcaseService(IShowcaseRepository showcaseRepository)
        {
            this.showcaseRepository = showcaseRepository;
        }

        public bool Add(Showcase showcase)
        {
            if (showcase != null)
            {
                showcaseRepository.Add(showcase);
                return true;
            }
            return false;
        }

        public bool Edit(Showcase showcase)
        {
            throw new NotImplementedException();
        }

        public List<Showcase> Get()
        {
            return showcaseRepository.Get();
        }

        public Showcase Get(int showcaseId)
        {
            return showcaseRepository.Get(showcaseId);
        }
    }
}
