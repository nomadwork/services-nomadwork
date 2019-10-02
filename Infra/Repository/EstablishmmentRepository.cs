using Microsoft.EntityFrameworkCore;
using Nomadwork.Infra.Data.Contexts;
using Nomadwork.Infra.Data.ObjectData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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


        public IEnumerable<EstablishmentModelData> GetByLocation(decimal latitude, decimal longitude)
            => _context.Establishments
                       .Include(x => x.Address)
                       .Where(establismment
                => (decimal.Round(establismment.Address.Latitude, 3).Equals(decimal.Round(latitude, 3))
                    || decimal.Round(establismment.Address.Longitude, 3).Equals(decimal.Round(longitude, 3)))
                     && establismment.Active)
                    .ToHashSet()
                    .Take(20)
                    .ToList();


        public IEnumerable<EstablishmentModelData> GetByFilter(string select)
            => _context.Establishments
                        .Include(x => x.Address)
                        .Where(x => x.Active
                        && (x.Name.Contains(select)
                        || x.Address.Street.Contains(select)
                        || x.Address.Zipcode.StartsWith(select)))
                        .ToHashSet()
                        .Take(20)
                        .ToList();

        public EstablishmentModelData GetById(long id)
             => _context.Establishments
                                    .Include(x => x.Address)
                                    .Include(x => x.Photos)
                                    .FirstOrDefault(establisshment => establisshment.Id.Equals(id) && establisshment.Active);


        public async Task<string> CreateSingle(EstablishmentModelData establishmentModelData)
        {
            try
            {
                _context.Establishments.Add(establishmentModelData);
                await _context.SaveChangesAsync();
                return string.Format("Estabelecimento {0} salvo com sucesso!", establishmentModelData.Name);
            }
            catch (Exception ex)
            {
                return string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", establishmentModelData.Name, ex.Message);
            }

        }


        public async Task<string> Update(EstablishmentModelData establishmentModelData)
        {
            _context.Entry(establishmentModelData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (Exists(establishmentModelData.Id))
                {
                    return string.Format("Erro ao salvar o estabelecimento {0}!\n Analise o erro: {1}", establishmentModelData.Name, ex.Message);
                }
            }

            return string.Format("Estabelecimento {0} alterado com sucesso!", establishmentModelData.Name);

        }

        public async Task<string> Delete(EstablishmentModelData establishmentModelData)
        {
            establishmentModelData.Active = false;
            _context.Entry(establishmentModelData).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {

                return string.Format("Erro ao deletar o estabelecimento {0}!\n Analise o erro: {1}", establishmentModelData.Name, ex.Message);

            }

            return string.Format("Estabelecimento {0} deletado com sucesso!", establishmentModelData.Name);

        }

<<<<<<< HEAD
<<<<<<< HEAD

=======
>>>>>>> dev/user
=======

>>>>>>> 731b1946b91c1911f7fc169dd9314a869907e4e3

        private bool Exists(long id)
        {
            return _context.Establishments.Any(e => e.Id == id);
        }

        //mok
        public async Task CreateMok(List<EstablishmentModelData> establishmentModelData)
        {
            try
            {
                _context.Establishments.AddRange(establishmentModelData);
                await _context.SaveChangesAsync();
            }
            catch (System.Exception ex)
            {
                throw ex;
            }

        }


    }
}
