using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GoodReads_NetWrapper.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GoodReads_NetWrapper
{
    /// <summary>
    /// The GoodReads API Wrapper.
    /// </summary>
    public class GoodReads
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodReads"/> class.
        /// </summary>
        /// <param name="DeveloperKey">The developer key for the api.</param>
        public GoodReads(string DeveloperKey = null)
        {
            this.DeveloperKey = DeveloperKey;
        }

        /// <summary>
        /// Gets or sets the developer key.
        /// </summary>
        /// <value>
        /// The developer key for the api.
        /// </value>
        public string DeveloperKey { get; set; }

        /// <summary>
        /// Gets the GoodReads book id.
        /// </summary>
        /// <param name="isbn">The isbn.</param>
        /// <returns></returns>
        public long GetBookID(string isbn)
        {
            string endpoint = "book/isbn_to_id";
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("isbn", isbn);

            object result = APIWrapper.CallAPI(endpoint, "GET", DeveloperKey, param);

            return long.Parse(result.ToString());
        }

        /// <summary>
        /// Get review statistics given a list of ISBNs.
        /// </summary>
        /// <param name="isbns">The isbns.</param>
        /// <returns></returns>
        public List<ReviewCount> GetBookReviewCounts(List<string> isbns)
        {
            List<ReviewCount> reviewCounts = new List<ReviewCount>();
            string endpoint = "book/review_counts.json";

            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("isbns", string.Join(",", isbns));

            object result = APIWrapper.CallAPI(endpoint, "GET", DeveloperKey, param);
            ReviewCounts counts = JsonConvert.DeserializeObject<ReviewCounts>(result.ToString());

            return counts.values;
        }
    }
}