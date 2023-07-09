using Microsoft.AspNetCore.Mvc;

namespace excel_upload_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenFolderController : ControllerBase
    {
        [HttpGet(Name = "GetOpenFolder")]
        public IActionResult Get()
        {
            string folderPath = "C:\\Path\\To\\Folder"; // Replace with your actual logic to retrieve the folder path
            return Ok(new { folderPath });
        }
    }
}
