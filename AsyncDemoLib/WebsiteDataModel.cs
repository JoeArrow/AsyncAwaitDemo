
using System.ComponentModel;

namespace AsyncDemoLib
{
    // ----------------------------------------------------
    /// <summary>
    ///     WebsiteDataModel Description
    /// </summary>

    public class WebsiteDataModel
    {
        [DisplayName("URL")]
        public string WebsiteUrl { get; set; } = "";
        [DisplayName("Data Length")]
        public int DataLength { get; set; } = 0;
        [DisplayName("Download Time (sec)")]
        public double DownloadTime { set; get; } = 0.0;
    }
}
