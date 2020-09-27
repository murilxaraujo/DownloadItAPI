using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YouTubeSearch;

namespace MAYoutubeDownload.Controllers
{
    public class DownloadController : Controller
    {
        // GET: /<controller>/
        public IActionResult Video(string url)
        {
            try
            {
                IEnumerable<VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(url, false);

                return Ok(videoInfos);
            }
            catch (Exception ex) {
                return NotFound(ex.Message);
            }
           
        }
    }
}
