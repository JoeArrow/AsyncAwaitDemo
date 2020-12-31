
using System.Net;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace AsyncDemoLib
{
    public class AsyncDemo
    {
        private List<WebsiteDataModel> WebsiteModels { get; }

        // ------------------------------------------------

        public AsyncDemo()
        {
            WebsiteModels = new List<WebsiteDataModel>();
        }

        // ------------------------------------------------

        public async Task<List<WebsiteDataModel>> Execute(List<string> urls, eParadigm paradigm)
        {
            WebsiteModels.Clear();

            switch(paradigm)
            {
                case eParadigm.Synchronous:
                    RunDownloadSync(urls);
                    break;

                case eParadigm.Asynchronous:
                    await RunDownloadAsync(urls);
                    break;

                case eParadigm.AsyncParallel:
                    await RunDownloadParallelAsync(urls);
                    break;
            }

            return WebsiteModels;
        }

        // ------------------------------------------------

        private void RunDownloadSync(List<string> urls)
        {
            foreach(string url in urls)
            {
                WebsiteModels.Add(DownloadWebsite(url));
            }
        }

        // ------------------------------------------------

        private async Task RunDownloadAsync(List<string> urls)
        {
            foreach(var url in urls)
            {
                WebsiteModels.Add(await Task.Run(() => DownloadWebsite(url)));
            }
        }

        // ------------------------------------------------

        private async Task RunDownloadParallelAsync(List<string> urls)
        {
            var tasks = new List<Task<WebsiteDataModel>>();

            foreach(var url in urls)
            {
                tasks.Add(DownloadWebsiteAsync(url));
            }

            var results = await Task.WhenAll(tasks);

            foreach(var item in results)
            {
                WebsiteModels.Add(item);
            }
        }

        // ------------------------------------------------

        private WebsiteDataModel DownloadWebsite(string websiteURL)
        {
            var client = new WebClient();
            var output = new WebsiteDataModel();

            var watch = Stopwatch.StartNew();

            output.WebsiteUrl = websiteURL;
            output.DataLength = client.DownloadString(websiteURL).Length;

            watch.Stop();

            output.DownloadTime = watch.ElapsedMilliseconds;

            return output;
        }

        // ------------------------------------------------

        private async Task<WebsiteDataModel> DownloadWebsiteAsync(string websiteURL)
        {
            var client = new WebClient();

            var watch = Stopwatch.StartNew();

            var data = await client.DownloadStringTaskAsync(websiteURL);

            watch.Stop();

            var output = new WebsiteDataModel()
            {
                WebsiteUrl = websiteURL,
                DataLength = data.Length,
                DownloadTime = watch.ElapsedMilliseconds,
            };

            return output;
        }
    }
}
