using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Repository;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public abstract class AController<TEntity> : ControllerBase where TEntity: class {

        protected IRepository<TEntity> _repository;

        protected ILogger<AController<TEntity>> _logger;

        public AController(IRepository<TEntity> repository, ILogger<AController<TEntity>> logger) {
            _repository = repository;
            _logger = logger;
        }

        [HttpGet("{id:int}")]
        public ActionResult<TEntity> Read(int id) => Ok(_repository.GetById(id));

        [HttpGet]
        public ActionResult<List<TEntity>> Read(int start, int count) => Ok(_repository.GetWithStart(start, count));
        
        [HttpGet("control")]
        public ActionResult<List<TEntity>> ReadAll() => Ok(_repository.ReadAll());

        [HttpPost]
        public ActionResult<TEntity> Create(TEntity t) {
            var item = _repository.Insert(t);
            _logger.LogInformation($"created resource");

            return Ok(item);
        }

        [HttpPut("{id:int}")]
        public ActionResult Update(int id, TEntity t) {
            var item = _repository.GetById(id);

            if (item is null) return NotFound();
            _repository.Update(t);
            _logger.LogInformation($"updated resoucre: {id}");
        
            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id) {
            var item = _repository.GetById(id);

            if (item is null) return NotFound();
            _repository.Delete(item);
            _logger.LogInformation($"deleted resource: {id}");
        
            return NoContent();
        }
    }
}