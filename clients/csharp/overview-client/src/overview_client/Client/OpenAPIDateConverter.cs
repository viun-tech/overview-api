/*
 * Overview Smart AI Cameras API
 *
 * This the API specifications for the OV20i Smart AI Camera produced by Overview Inc. It works with firmware versions above 2024.23.1.  Some useful links: - [Overview Documentation](https://overview.ai/support)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: lucas.vandroux@viun.tech
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using Newtonsoft.Json.Converters;

namespace overview_client.Client
{
    /// <summary>
    /// Formatter for 'date' openapi formats ss defined by full-date - RFC3339
    /// see https://github.com/OAI/OpenAPI-Specification/blob/master/versions/3.0.0.md#data-types
    /// </summary>
    public class OpenAPIDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenAPIDateConverter" /> class.
        /// </summary>
        public OpenAPIDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
