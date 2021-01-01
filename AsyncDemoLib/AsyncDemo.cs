
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
        /// <summary>
        ///     By running synchronously, we will block
        ///     everything until all calls are finished and
        ///     returned.
        /// </summary>
        /// <param name="urls"></param>

        private void RunDownloadSync(List<string> urls)
        {
            foreach(string url in urls)
            {
                WebsiteModels.Add(DownloadWebsite(url));
            }
        }

        // ------------------------------------------------
        /// <summary>
        ///     By awaiting each task indiviudually, we do not
        ///     benefit from Parallel processing. But the UI 
        ///     does remain responsive.
        /// </summary>
        /// <param name="urls"></param>
        /// <returns></returns>

        private async Task RunDownloadAsync(List<string> urls)
        {
            foreach(var url in urls)
            {
                WebsiteModels.Add(await Task.Run(() => DownloadWebsite(url)));
            }
        }

        // ------------------------------------------------
        /// <summary>
        ///     By gathering the Tasks, and awaiting them all,
        ///     the calling method can continue on, and when
        ///     these tasks are finished, this method will continue.
        /// </summary>
        /// <param name="urls"></param>
        /// <returns></returns>

        private async Task RunDownloadParallelAsync(List<string> urls)
        {
            var tasks = new List<Task<WebsiteDataModel>>();

            // ---------------------------------
            // Gather Tasks running for each URL

            foreach(var url in urls)
            {
                tasks.Add(DownloadWebsiteAsync(url));
            }

            // ----------------------------
            // Wait for all Tasks to finish

            var results = await Task.WhenAll(tasks);

            // --------------------------
            // Get results from each Task

            foreach(var item in results)
            {
                WebsiteModels.Add(item);
            }
        }

        // ------------------------------------------------
        /// <summary>
        ///     Nothing asynchronous about this methiod. 
        ///     It just gets the data as best it can.
        /// </summary>
        /// <param name="websiteURL"></param>
        /// <returns></returns>

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
        /// <summary>
        ///     Use the Asynchronous download method on the
        ///     WebClient, and await its response.
        /// </summary>
        /// <param name="websiteURL"></param>
        /// <returns></returns>

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
                DownloadTime = watch.ElapsedMilliseconds / 1000.0,
            };

            return output;
        }
    }
}
