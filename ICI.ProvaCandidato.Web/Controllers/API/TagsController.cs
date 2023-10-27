using ICI.ProvaCandidato.Dados;
using ICI.ProvaCandidato.Negocio.Tags;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ICI.ProvaCandidato.Web.Controllers.API
{
    public class TagsController : BaseApiController
    {
        [HttpGet]
        public async Task<ActionResult<List<Tag>>> GetTags()
        {
            return await Mediator.Send(new List.Query());
        }

        [HttpPost]
        public async Task<IActionResult> CreateTag(Tag tag)
        {
            return Ok(await Mediator.Send(new Create.Command { Tag = tag }));
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditTag(int id, Tag tag)
        {
            tag.Id = id;
            return Ok(await Mediator.Send(new Edit.Command { Tag = tag }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            return Ok(await Mediator.Send(new Delete.Command { Id = id }));
        }
    }
}
