using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace GoodReads_NetWrapper.Models
{
    [JsonObject]
    public class ReviewCount
    {
        /// <summary>
        /// Gets or sets the average_rating.
        /// </summary>
        /// <value>
        /// The average_rating.
        /// </value>
        [JsonProperty("average_rating")]
        public string average_rating { get; set; }

        /// <summary>
        /// Gets or sets the identifier.
        /// </summary>
        /// <value>
        /// The identifier.
        /// </value>
        [JsonProperty("id")]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the isbn.
        /// </summary>
        /// <value>
        /// The isbn.
        /// </value>
        [JsonProperty("isbn")]
        public string isbn { get; set; }

        /// <summary>
        /// Gets or sets the isbn13.
        /// </summary>
        /// <value>
        /// The isbn13.
        /// </value>
        [JsonProperty("isbn13")]
        public string isbn13 { get; set; }

        /// <summary>
        /// Gets or sets the ratings_count.
        /// </summary>
        /// <value>
        /// The ratings_count.
        /// </value>
        [JsonProperty("ratings_count")]
        public int ratings_count { get; set; }

        /// <summary>
        /// Gets or sets the reviews_count.
        /// </summary>
        /// <value>
        /// The reviews_count.
        /// </value>
        [JsonProperty("reviews_count")]
        public int reviews_count { get; set; }

        /// <summary>
        /// Gets or sets the text_reviews_count.
        /// </summary>
        /// <value>
        /// The text_reviews_count.
        /// </value>
        [JsonProperty("text_reviews_count")]
        public int text_reviews_count { get; set; }

        /// <summary>
        /// Gets or sets the work_ratings_count.
        /// </summary>
        /// <value>
        /// The work_ratings_count.
        /// </value>
        [JsonProperty("work_ratings_count")]
        public int work_ratings_count { get; set; }

        /// <summary>
        /// Gets or sets the work_reviews_count.
        /// </summary>
        /// <value>
        /// The work_reviews_count.
        /// </value>
        [JsonProperty("work_reviews_count")]
        public int work_reviews_count { get; set; }

        /// <summary>
        /// Gets or sets the work_text_reviews_count.
        /// </summary>
        /// <value>
        /// The work_text_reviews_count.
        /// </value>
        [JsonProperty("work_text_reviews_count")]
        public int work_text_reviews_count { get; set; }
    }

    [JsonObject]
    internal class ReviewCounts
    {
        [JsonProperty("books")]
        public List<ReviewCount> values { get; set; }
    }
}