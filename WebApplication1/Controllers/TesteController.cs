using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [RoutePrefix("teste")]
    public class TesteController : ApiController
    {
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage RetornaTeste(int id)
        {
            var dadosRetorno = "teste de dados retorno " + id;
            return Request.CreateResponse(HttpStatusCode.OK, dadosRetorno);
        }

        [Route("")]
        public HttpResponseMessage PostCliente([FromBody] Pessoa p)
        {
            // grava no banco, ex.

            p.Id = 999;
            return Request.CreateResponse(HttpStatusCode.Created, p);
        }

        [Route("{id}")]
        public HttpResponseMessage PutTeste(int id, [FromBody]Pessoa p)
        {
            var p2 = p;

            p2.Nome = p2.Nome + " alterando a informação no server";

            return Request.CreateResponse(HttpStatusCode.OK, p2);
        }

        public HttpResponseMessage DeleteTeste(int id)
        {
            // delete no banco de dados
            return Request.CreateResponse(HttpStatusCode.NoContent);
        }
    }
}
