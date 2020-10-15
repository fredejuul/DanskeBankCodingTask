using DanskeBankCodingTask.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DanskeBankCodingTask.Models.DataManager
{
    public class MunicipalityTaxManager : IDataRepository<MunicipalityTax>
    {
        readonly MunicipalityTaxContext _municipalityTaxContext;

        public MunicipalityTaxManager(MunicipalityTaxContext context)
        {
            _municipalityTaxContext = context;
        }

        public IEnumerable<MunicipalityTax> GetAll()
        {
            return _municipalityTaxContext.MunicipalityTaxes.ToList();
        }

        public MunicipalityTax Get(int id)
        {
            return _municipalityTaxContext.MunicipalityTaxes
                .FirstOrDefault(e => e.ID == id);
        }

        public void Add(MunicipalityTax entity)
        {
            _municipalityTaxContext.MunicipalityTaxes.Add(entity);
            _municipalityTaxContext.SaveChanges();
        }

        public void Update(MunicipalityTax municipalityTax, MunicipalityTax entity)
        {
            municipalityTax.Municipality = entity.Municipality;
            municipalityTax.TaxRate = entity.TaxRate;
            municipalityTax.Schedule = entity.Schedule;
            municipalityTax.StartDate = entity.StartDate;
            municipalityTax.EndDate = entity.EndDate;

            _municipalityTaxContext.SaveChanges();
        }

        public void Delete(MunicipalityTax municipalityTax)
        {
            _municipalityTaxContext.MunicipalityTaxes.Remove(municipalityTax);
            _municipalityTaxContext.SaveChanges();
        }
    }
}
