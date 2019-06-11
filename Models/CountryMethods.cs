using PruebasNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFFMUSA.Models
{
    public interface CountryMethods
    {
        int IdCountrySelected { get; set; }
        Country GetCountry(int CountryId);
        IEnumerable<Country> GetCountries();
        Country AddCountry(Country country);
        Country UpdateCountry(Country country_changes);
        Country DeleteCountry(int CountryId);
    }
}
