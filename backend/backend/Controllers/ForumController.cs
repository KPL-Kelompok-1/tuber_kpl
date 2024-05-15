using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using backend.Model;
using backend.Config;
using backend.Request;
using System.Diagnostics;
namespace backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private ForumConfig forumConfig = new ForumConfig();

        [HttpGet]
        public ActionResult<List<Forum>> Get()
        {
            return ForumConfig.LoadConfig();
        }

        [HttpGet("{id}")]
        public ActionResult<List<Forum>> GetById(int id)
        {
            return ForumConfig.LoadConfig(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Forum forum)
        {
            if (forum == null)
            {
                return BadRequest("Invalid forum data provided.");
            }
            if (string.IsNullOrEmpty(forum.title) || forum.title.Length > 50)
            {
                return BadRequest("Title is required and cannot exceed 50 characters.");
            }

            if (string.IsNullOrEmpty(forum.content) || forum.content.Length > 100)
            {
                return BadRequest("Content is required and cannot exceed 100 characters.");
            }

            ForumConfig.Add(forum);
            ForumConfig.SaveConfig();
            return Ok();
        }

        [HttpPut("{id}/update")]
        public ActionResult Put( int id, [FromBody] ForumRequest forum)
        {
            if (forum == null)
            {
                return BadRequest("Invalid forum data provided.");
            }

            if (string.IsNullOrEmpty(forum.title) || forum.title.Length > 10)
            {
                return BadRequest("Title is required and cannot exceed 50 characters.");
            }

            if (string.IsNullOrEmpty(forum.content) || forum.content.Length > 100)
            {
                return BadRequest("Content is required and cannot exceed 100 characters.");
            }

            Forum f = new Forum();
            f.title = forum.title;
            f.content = forum.content;
            f.created_at = forum.created_at;
            ForumConfig.Edit(f,id);
            ForumConfig.SaveConfig();
            return Ok();
        }
        [HttpDelete("{id}/delete")]
        public ActionResult Delete(int id)
        {
            ForumConfig.Delete(id);
            ForumConfig.SaveConfig();
            return Ok();
        }
    }
}
