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
    public class AccountController : ControllerBase
    {
        private readonly IUseCase<Account, int> _useCase;
        private readonly IPresenter<Account> _presenter;

        public AccountController(IUseCase<Account, int> useCase, IPresenter<Account> presenter)
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
