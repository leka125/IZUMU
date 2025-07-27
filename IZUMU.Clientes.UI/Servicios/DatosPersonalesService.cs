using IZUMU.Clientes.Infrastructure.Repositories;
using IZUMU.Clientes.Infrastructure.Entities;
using IZUMU.Clientes.UI.Models;
using IZUMU.Clientes.UI.Mapper;

namespace IZUMU.Clientes.UI.Servicios
{
    public class DatosPersonalesService
    {
        private readonly DatosPersonalesRepository _repository;

        public DatosPersonalesService(DatosPersonalesRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<DatosPersonales> GetAll()
        {
            return _repository.GetAll().Select(DatosPersonalesMapper.ToModel);
        }

        public DatosPersonales? GetById(int id)
        {
            var entity = _repository.GetById(id);
            return entity != null ? DatosPersonalesMapper.ToModel(entity) : null;
        }

        public void Add(DatosPersonales model)
        {
            var entity = DatosPersonalesMapper.ToDto(model);
            _repository.Add(entity);
        }

        public void Update(DatosPersonales model)
        {
            var entity = DatosPersonalesMapper.ToDto(model);
            _repository.Update(entity);
        }

        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
