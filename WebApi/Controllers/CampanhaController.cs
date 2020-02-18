using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using WebApi.Negocios;

namespace WebApi.Controllers
{
    public class CampanhaController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage ObterAnuncioCampanha(string anuncio)
        {
            HttpResponseMessage response = new HttpResponseMessage();

            try
            {
                CampanhaNegocios campanhaNegocios = new CampanhaNegocios();

                var exameComplementar = this.campanhaNegocios.BuscarCampanha(anuncio);

                response = Request.CreateResponse(HttpStatusCode.OK, exameComplementar);

            }
            catch (Exception ex)
            {

            }

            return response;

        }


    }
}