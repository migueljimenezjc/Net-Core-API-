using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using DenunciaAPI.App_Code;
using DenunciaAPI.App_Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DenunciaAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/Denuncia")]
    public class DenunciaController : Controller
    {
        private readonly DenunciaContext _denuncia;

        public DenunciaController(DenunciaContext denuncia)
        {
            _denuncia = denuncia;
        }

        [HttpGet]
        [Route("Denuncias")]
        public async Task<List<Denuncia>> Lista()
        {
            var listado =  _denuncia.DenunciaItems.FromSql("dbo.spSel_DenunciaTest").ToList();
            return await Task.Run(()=> listado);
        }

        [HttpPost]
        [Route("InsertarDenuncia")]
        public async Task<Respuesta> GenerarDenuncia([FromBody]Denuncia denuncia)
        {
             _denuncia.Add(denuncia);
            await _denuncia.SaveChangesAsync();
            Respuesta respuesta = new Respuesta();
            respuesta.CodigoRespuesta = 0;
            respuesta.DescripcionRespuesta = "El registro se realizo exitosamente";
            return respuesta;
        }
    }
}
