using Microsoft.AspNetCore.Mvc;
using ProjectManagement.Data.Interfaces;
using ProjectManagement.Entities;

namespace ProjectManagement.Api.Controllers
{
    public class BaseController<T> : ControllerBase where T : BaseEntity
    {
        private readonly IBaseRepository<T> _repository;

        public BaseController(IBaseRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(_repository.Get());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var result = _repository.Get(id);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

        [HttpPost()]
        public IActionResult Post([FromBody] T entity)
        {
            _repository.Add(entity);
            return NoContent();
        }

        [HttpPut()]
        public IActionResult Put(T entity)
        {
            _repository.Update(entity);
            return NoContent();
        }

        [HttpDelete()]
        public IActionResult Delete(long id)
        {
            _repository.Delete(id);
            return NoContent();
        }
    }
}
