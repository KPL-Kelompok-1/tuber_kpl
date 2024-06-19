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
<<<<<<< Updated upstream
=======
           /* int i = 0;
            while (i < 1000000000000000) {
                i++;
            }*/
>>>>>>> Stashed changes
            return ForumConfig.LoadConfig(id);
        }

        [HttpPost]
        public ActionResult Post([FromBody] Forum forum)
        {
            try
            {
                if (forum == null)
                {
                    throw new Exception("Invalid forum data provided.");
                }
                if (string.IsNullOrEmpty(forum.title) || forum.title.Length > 100)
                {
                    throw new Exception("Title is required and cannot exceed 100 characters.");
                }

                if (string.IsNullOrEmpty(forum.content) || forum.content.Length > 20)
                {
                    throw new Exception("Content is required and cannot exceed 20 characters.");
                }

                ForumConfig.Add(forum);
                ForumConfig.SaveConfig();
                return Ok();
            }
            catch (Exception e) {
                return BadRequest(e.Message);
            }
           
        }

        [HttpPut("{id}/update")]
        public ActionResult Put( int id, [FromBody] ForumRequest forum)
        {
            try {
                if (forum == null)
                {
                    throw new Exception("Invalid forum data provided.");
                }
                if (string.IsNullOrEmpty(forum.title) || forum.title.Length > 10)
                {
                    throw new Exception("Title is required and cannot exceed 10 characters.");
                }

                if (string.IsNullOrEmpty(forum.content) || forum.content.Length > 20)
                {
                    throw new Exception("Content is required and cannot exceed 20 characters.");
                }

                Forum f = new Forum();
                f.title = forum.title;
                f.content = forum.content;
                f.created_at = forum.created_at;
                ForumConfig.Edit(f, id);
                ForumConfig.SaveConfig();
                return Ok();
            }catch (Exception e)
            {
                return BadRequest(e.Message);
            }
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
