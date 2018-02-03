﻿using System.Collections.Generic;
using CatOwners.Model;
using CatOwners.Infrastructure;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using CatOwners.Interfaces;

namespace CatOwners.Repository
{
    [Export(typeof(IPersonRepository))]
    public class PersonRepository : IPersonRepository
    {
        private const string _peopleUrl = "http://agl-developer-test.azurewebsites.net/people.json";

        public IList<Person> ReadPeople()
        {
            return HttpClientHelper.GetItemsAsync<Person>(_peopleUrl).Result;
        }

        public async Task<IList<Person>> ReadPeopleAsync()
        {
            return await HttpClientHelper.GetItemsAsync<Person>(_peopleUrl);
        }
    }
}
