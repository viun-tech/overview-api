/*
 * Overview Smart AI Cameras API
 *
 * This the API specifications for the OV20i Smart AI Camera produced by Overview Inc. It works with firmware versions above 2024.23.1.  Some useful links: - [Overview Documentation](https://overview.ai/support)
 *
 * The version of the OpenAPI document: 0.0.1
 * Contact: lucas.vandroux@viun.tech
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = overview_client.Client.OpenAPIDateConverter;

namespace overview_client.Model
{
    /// <summary>
    /// RecipeId
    /// </summary>
    [DataContract(Name = "RecipeId")]
    public partial class RecipeId : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecipeId" /> class.
        /// </summary>
        /// <param name="id">ID of the recipe available (Not the PLC ID, [more info](https://docs.overview.ai/docs/recipe-change-using-http)).</param>
        public RecipeId(int id = default(int))
        {
            this.Id = id;
        }

        /// <summary>
        /// ID of the recipe available (Not the PLC ID, [more info](https://docs.overview.ai/docs/recipe-change-using-http))
        /// </summary>
        /// <value>ID of the recipe available (Not the PLC ID, [more info](https://docs.overview.ai/docs/recipe-change-using-http))</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecipeId {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Id (int) maximum
            if (this.Id > (int)65535)
            {
                yield return new ValidationResult("Invalid value for Id, must be a value less than or equal to 65535.", new [] { "Id" });
            }

            // Id (int) minimum
            if (this.Id < (int)1)
            {
                yield return new ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            yield break;
        }
    }

}
