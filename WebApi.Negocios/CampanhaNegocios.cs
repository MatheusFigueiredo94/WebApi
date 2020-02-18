using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entidade;
using WebApi.Data.Repositorio;

namespace WebApi.Negocios
{
    public class CampanhaNegocios
    {

        public void BuscarCampanha(string campanha)
        {

            CampanhaRepository baseCampanha = new CampanhaRepository();

            baseCampanha.Listar(campanha);

        }

    }
}
