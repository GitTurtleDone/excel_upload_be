using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Win32;

namespace excel_upload_be.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OpenFolderController : ControllerBase
    {
        [HttpGet(Name = "GetOpenFolder")]
        public IActionResult Get()
        {
            string folderPath = string.Empty; // Replace with your actual logic to retrieve the folder path
           var dialog = new OpenFileDialog
            {
                Filter = "Folders|*.none",
                CheckFileExists = false,
                CheckPathExists = true,
                FileName = "Select Folder",
                ValidateNames = false
            };

            bool? result = dialog.ShowDialog();

            if (result == true)
            {
                folderPath = System.IO.Path.GetDirectoryName(dialog.FileName);
            }
            return Ok(new { folderPath });
        }
    }
}
