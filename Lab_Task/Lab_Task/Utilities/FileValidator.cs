using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Lab_Task.Utilities
{
    public static class FileValidator
    {
        public static bool CheckImg(this IFormFile file,int mb)
        {
            return file.Length / 1024 / 1024 < mb&&file.ContentType.Contains("image/");
        }
        public static async Task<string> CreateFile(this IFormFile file,string root,string folder)
        {
            string filename = string.Concat(Guid.NewGuid(),file.FileName);
            string path = Path.Combine(root, folder, filename);
            using (FileStream stream=new FileStream(path,FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return filename;

        }
    }
}
