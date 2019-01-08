using AutoMapper;
using HirePersonality.Database.Contexts;
using HirePersonality.Database.DataContract.Personality;
using HirePersonality.Database.Entities.Personality;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HirePersonality.Database.Personality
{
    public class PersonalityRepository : IPersonalityRepository
    {
        private readonly SISContext _context;
        private readonly IMapper _mapper;

        public PersonalityRepository(SISContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<bool> CreatePersonality(PersonalityCreateRAO rao)
        {
            var entity = _mapper.Map<PersonalityEntity>(rao);

             _context.PersonalityTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }
    }
}
