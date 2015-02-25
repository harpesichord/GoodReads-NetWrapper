using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}