using AFFMUSA.ViewModel;
using MultiAplicacion.Models;
using PruebasNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public class SQLCountryMethods : CountryMethods
    {
        private readonly AppDbContext context;

        public SQLCountryMethods(AppDbContext context)
        {
            this.context = context;
        }
        public int IdCountrySelected { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Country AddCountry(Country country)
        {

            context.Add(country);
            context.SaveChanges();
            return country;
        }

        public Country DeleteCountry(int CountryId)
        {
            Country country = context.Countries.Find(CountryId);
            if (country != null)
            {
                context.Countries.Remove(country);
                context.SaveChanges();
            }
            return country;
        }

        public IEnumerable<Country> GetCountries()
        {
            return context.Countries;
        }

        public Country GetCountry(int CountryId)
        {
            Country country = context.Countries.Find(CountryId);
            return country;
        }

        public Country UpdateCountry(Country country_changes)
        {
            var country = context.Countries.Attach(country_changes);
            country.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return country_changes;
        }
    }
}
