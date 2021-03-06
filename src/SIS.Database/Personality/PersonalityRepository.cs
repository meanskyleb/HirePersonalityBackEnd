﻿using AutoMapper;
using HirePersonality.Database.Contexts;
using HirePersonality.Database.DataContract.Personality;
using HirePersonality.Database.Entities.People;
using HirePersonality.Database.Entities.Personality;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<UserEntity>_userManager;


        public PersonalityRepository(SISContext context, IMapper mapper, UserManager<UserEntity> userManager)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
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

        public async Task<ReceivePersonalityRAO> GetPersonality(int id)
        {
            var entity = await _context
                .PersonalityTableAccess
                .SingleOrDefaultAsync(e => e.PersonalityEntityId == id);

            var rao = _mapper.Map<ReceivePersonalityRAO>(entity);

            return rao;

        }

        public async Task<bool> UpdatePersonality(UpdatePersonalityRAO rao)
        {
            var entity = await _context
                .PersonalityTableAccess
                .SingleOrDefaultAsync(e => e.UserId == rao.OwnerId);

            entity.PersonalityNumber = rao.PersonalityNumber;
            entity.PersonalityType = rao.PersonalityType;

            return await _context.SaveChangesAsync() == 1;
        }

        public bool DeletePersonality(int id)
        {
            var query = _context
                .PersonalityTableAccess
                .Where(e => e.UserId == id)
                .ToList();

            int count = 0;
            foreach (var entity in query)
            {
                _context.Remove(entity);
                count++;
            }

            return _context.SaveChanges() == count;  
        }

        public async Task<int> GetPersonalityType(int id)
        {
            var entity = await _context.PersonalityTableAccess.FirstOrDefaultAsync(e => e.UserId == id);

            return entity.PersonalityType;
        }

        //public async Task<IEnumerable<ReceivePersonalityRAO>> GetPersonalityByUser(int id)
        //{
        //    var query = await _context
        //        .PersonalityTableAccess
        //        .Where(e => e.UserId == id)
        //        .ToArrayAsync();

        //    var mappedQuery = _mapper.Map<IEnumerable<ReceivePersonalityRAO>>(query);

        //    return mappedQuery;
        //}
    }
}
