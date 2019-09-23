using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.Model_Data;
using System.Collections.Generic;
using System.Linq;

namespace Nomadwork.Infra.Repository
{
    public class EstablishmmentRepository
    {
        private readonly NomadworkDbContext _context;

        private EstablishmmentRepository(NomadworkDbContext context)
        {
            _context = context;
        }

        public static EstablishmmentRepository GetInstance(NomadworkDbContext context)
            => new EstablishmmentRepository(context);


        public IEnumerable<EstablishmentModelData> GetAllEstablishmentsByLocation(decimal latitude, decimal longitude)
            => _context.Establishments
                       .Include(x => x.Address)
                       .Where(establismment
                => (decimal.Round(establismment.Address.Latitude, 3).Equals(decimal.Round(latitude, 3))
                    || decimal.Round(establismment.Address.Longitude, 3).Equals(decimal.Round(longitude, 3)))
                     && establismment.Active)
                    .ToHashSet()
                    .Take(20)
                    .ToList();



        public EstablishmentModelData GetEstablishmentById(long id)
             => _context.Establishments
                                    .Include(x => x.Address)
                                    .Include(x => x.Characteristics)
                                    .Include(x => x.Photos)
                                    .FirstOrDefault(establisshment => establisshment.Id.Equals(id) && establisshment.Active);



        //public EstablishmentModelData UpdateEstablishment(EstablishmentModelData establishmentModelData)
        //{
        //    _context.Entry(establishmentModelData).State = EntityState.Modified;

        //    try
        //    {
        //        _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (EstablishmentExists(establishmentModelData.Id))
        //        {
        //            throw;
        //        }
        //    }

        //    return GetEstablishmentById(establishmentModelData.Id);

        //}


        //public async Task CreateEstablishment(List<EstablishmentModelData> establishmentModelData)
        //{
        //    try
        //    {


        //        _context.Establishments.AddRange(establishmentModelData);
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (System.Exception ex)
        //    {


        //        throw ex;
        //    }

        //}


        //public IEnumerable<EstablishmentModelData> DeleteEstablishment(EstablishmentModelData establishmentModelData)
        //{
        //    establishmentModelData.Active = false;

        //    _context.Entry(establishmentModelData).State = EntityState.Modified;

        //    try
        //    {
        //        _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (EstablishmentExists(establishmentModelData.Id))
        //        {
        //            throw;
        //        }
        //    }


        //    return GetAllEstablishmentsByLocation(establishmentModelData.Address.Latitude, establishmentModelData.Address.Longitude);
        //}

        //private bool EstablishmentExists(long id)
        //{
        //    return _context.Establishments.Any(e => e.Id == id);
        //}
    }
}
