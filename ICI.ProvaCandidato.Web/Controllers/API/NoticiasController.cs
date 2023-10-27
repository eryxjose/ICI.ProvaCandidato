using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio.Noticias;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers.API
{
    public class NoticiasController : BaseApiController
    {

        [HttpGet]
        public async Task<ActionResult<List<NoticiaDTO>>> GetNoticias()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateNoticia(Noticia noticia)
        {
            return Ok(await Mediator.Send(new Create.Command { Noticia = noticia }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditNoticia(int id, Noticia noticia)
        {
            noticia.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Noticia = noticia }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteActivity(int id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }

    }
}
