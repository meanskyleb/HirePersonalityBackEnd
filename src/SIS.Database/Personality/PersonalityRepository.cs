using AutoMapper;
using HirePersonality.Database.Contexts;
using HirePersonality.Database.DataContract.Personality;
using HirePersonality.Database.Entities.Personality;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public async Task<bool> CreatePersonality(CreatePersonalityRAO rao)
        {
            var entity = _mapper.Map<PersonalityEntity>(rao);

             _context.PersonalityTableAccess.AddAsync(entity);

            return await _context.SaveChangesAsync() == 1;
        }


        public async Task<IEnumerable<ReceivePersonalityRAO>> GetPersonality()
        {
            var query = await _context.PersonalityTableAccess.ToArrayAsync();

            var rao = _mapper.Map < IEnumerable<ReceivePersonalityRAO>>(query);
               

            return rao;
        }

        public async Task<ReceivePersonalityRAO> GetPersonalityAsync(int id)
        {
            var entity = await _context
                .PersonalityTableAccess
                .SingleAsync(e => e.PersonalityEntityId == id);

            var rao = _mapper.Map<ReceivePersonalityRAO>(entity);

            return rao;

        }

        public async Task<bool> UpdatePersonality(UpdatePersonalityRAO rao)
        {
            var entity = await _context
                .PersonalityTableAccess
                .SingleAsync(e => e.PersonalityEntityId == rao.PersonalityEntityId);

            entity = _mapper.Map<PersonalityEntity>(rao);
                
                
                throw new NotImplementedException();
        }

        public Task<bool> DeletePersonality(int id)
        {
            throw new NotImplementedException();
        }
    }
}
