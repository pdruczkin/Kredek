using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PatrykRuczkinLab5PracDom.Models;
using PatrykRuczkinLab5PracDom.Models.DbModels;

namespace PatrykRuczkinLab5PracDom.Services
{
    public interface IPublisherService
    {
        ICollection<PublisherViewModel> GetAll();
        PublisherDetailsViewModel GetById(int id);

        Publisher GetByName(string name);
    }

    public class PublisherService : IPublisherService
    {
        //mapper used to map objects between 2 classes
        private readonly IMapper _mapper;

        //database provider
        private readonly DatabaseContext _context;

        public PublisherService(IMapper mapper, DatabaseContext context)
        {
            _mapper = mapper;
            _context = context;
            
        }


        public ICollection<PublisherViewModel> GetAll()
        {
            var publishers = _context
                .Publishers
                .Include(p => p.Books)
                .Include(p => p.Books).ThenInclude(b => b.Category)
                .Include(p => p.Books).ThenInclude(b => b.Author);

            var publishersViewModels = _mapper.Map<List<PublisherViewModel>>(publishers);
            




            return publishersViewModels;

        }

        public PublisherDetailsViewModel GetById(int id)
        {
            var publisher = _context
                .Publishers
                .Include(p => p.Books)
                .Include(p => p.Books).ThenInclude(b => b.Category)
                .Include(p => p.Books).ThenInclude(b => b.Author)
                .SingleOrDefault(p => p.Id == id);

            var publisherDetailsViewModel = _mapper.Map<PublisherDetailsViewModel>(publisher);

            return publisherDetailsViewModel;
        }

        public Publisher GetByName(string name)
        {
            var publisher = _context
                .Publishers
                .Include(p => p.Books)
                .Include(p => p.Books).ThenInclude(b => b.Category)
                .Include(p => p.Books).ThenInclude(b => b.Author)
                .SingleOrDefault(p => p.Name == name);

            return publisher;
        }
    }
}