using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.Entidade;

namespace WebApi.Data.Repositorio
{
    public class CampanhaRepository
    {
        public string json = " {Data:""2020-02-04T00:00:00"", ""Cliques"":6.0, ""Impressoes"":10.0, ""Views"":0.0, ""CPM"":1187000000.0, ""CPC"":1978333.0, ""CTR"":6000.0, ""Conversoes"":0.0, ""Investimento"":11870000.0, ""IdCampanha"":125671287589127, ""NomeCampanha"":""125671287589127"" }{""Data"":""2020-02-04T00:00:00"",""Cliques"":0.0,""Impressoes"":1.0,""Views"":0.0,""CPM"":0.0,""CPC"":0.0,""CTR"":0.0,""Conversoes"":0.0,""Investimento"":0.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":0.0,""Impressoes"":1.0,""Views"":0.0,""CPM"":0.0,""CPC"":0.0,""CTR"":0.0,""Conversoes"":0.0,""Investimento"":0.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":0.0,""Impressoes"":1.0,""Views"":0.0,""CPM"":0.0,""CPC"":0.0,""CTR"":0.0,""Conversoes"":0.0,""Investimento"":0.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":1.0,""Impressoes"":3.0,""Views"":0.0,""CPM"":553333333.0,""CPC"":1660000.0,""CTR"":3333.0,""Conversoes"":0.0,""Investimento"":1660000.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":0.0,""Impressoes"":1.0,""Views"":0.0,""CPM"":0.0,""CPC"":0.0,""CTR"":0.0,""Conversoes"":0.0,""Investimento"":0.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":2.0,""Impressoes"":10.0,""Views"":0.0,""CPM"":319000000.0,""CPC"":1595000.0,""CTR"":2000.0,""Conversoes"":0.0,""Investimento"":3190000.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":1.0,""Impressoes"":2.0,""Views"":0.0,""CPM"":425000000.0,""CPC"":850000.0,""CTR"":5000.0,""Conversoes"":0.0,""Investimento"":850000.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":1.0,""Impressoes"":14.0,""Views"":0.0,""CPM"":327142857.0,""CPC"":4580000.0,""CTR"":714.0,""Conversoes"":0.0,""Investimento"":4580000.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":1.0,""Impressoes"":10.0,""Views"":0.0,""CPM"":488000000.0,""CPC"":4880000.0,""CTR"":1000.0,""Conversoes"":0.0,""Investimento"":4880000.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}{""Data"":""2020-02-06T00:00:00"",""Cliques"":0.0,""Impressoes"":11.0,""Views"":0.0,""CPM"":0.0,""CPC"":0.0,""CTR"":0.0,""Conversoes"":0.0,""Investimento"":0.0,""IdCampanha"":125671287589127,""NomeCampanha"":""125671287589127""}";

        //dbSet Local onde esta armazenado os arquivos processados
        public IEnumerable<Xml> Listar(string campanha)
        {
            IQueryable<Xml> query = dbSet;

                    query = dbSet.Where("NomeCampanha = @0", campanha);

            return query;
        }

    }
}
