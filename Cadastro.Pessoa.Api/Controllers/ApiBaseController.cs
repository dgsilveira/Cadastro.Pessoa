using Cadastro.Pessoa.Domain.ModelsApi;
using Flunt.Notifications;
using Microsoft.AspNetCore.Mvc;

namespace Cadastro.Pessoa.Api.Controllers
{
    /// <summary>
    /// ApiBaseController
    /// </summary>
    public abstract class ApiBaseController : ControllerBase
    {
        /// <summary>
        /// Solicitação incorreta - BadRequest
        /// </summary>
        /// <param name="notifications">Notificações</param>
        /// <returns></returns>
        protected BadRequestObjectResult BadRequest(IReadOnlyCollection<Notification> notifications)
        {
            return new BadRequestObjectResult(new ErrorModel(notifications));
        }

        /// <summary>
        /// Entidade não processável - UnprocessableEntitiy
        /// </summary>
        /// <param name="notifications">Notificações</param>
        /// <returns></returns>
        protected UnprocessableEntityObjectResult UnprocessableEntitiy(IReadOnlyCollection<Notification> notifications)
        {
            return new UnprocessableEntityObjectResult(new ErrorModel(notifications));
        }

        /// <summary>
        /// Não encontrado - NotFound
        /// </summary>
        /// <param name="message">Mensagem</param>
        /// <returns></returns>
        protected NotFoundObjectResult NotFound(string message)
        {
            return new NotFoundObjectResult(new ErrorModel(message));
        }
    }
}
