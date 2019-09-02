using System.Threading.Tasks;
using Accounting.Api.Interfaces;
using Accounting.Core.Dto.UseCases.Requests;
using Accounting.Core.Entities;
using Accounting.Core.Interfaces.UseCases;
using Microsoft.AspNetCore.Mvc;

namespace Accounting.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private readonly IUseCase<Transaction, int> _useCase;
        private readonly IPresenter<Transaction> _presenter;

        public TransactionController(IUseCase<Transaction, int> useCase, IPresenter<Transaction> presenter)
        {
            _useCase = useCase;
            _presenter = presenter;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return _presenter.Handle(await _useCase.Handle(new ReadRequest()));
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
