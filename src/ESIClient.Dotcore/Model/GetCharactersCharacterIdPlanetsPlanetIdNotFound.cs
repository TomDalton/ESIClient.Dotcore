/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.8.2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = ESIClient.Dotcore.Client.SwaggerDateConverter;

namespace ESIClient.Dotcore.Model
{
    /// <summary>
    /// Colony not found
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdPlanetsPlanetIdNotFound :  IEquatable<GetCharactersCharacterIdPlanetsPlanetIdNotFound>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdNotFound" /> class.
        /// </summary>
        /// <param name="error">error message.</param>
        public GetCharactersCharacterIdPlanetsPlanetIdNotFound(string error = default(string))
        {
            this.Error = error;
        }
        
        /// <summary>
        /// error message
        /// </summary>
        /// <value>error message</value>
        [DataMember(Name="error", EmitDefaultValue=false)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdNotFound {\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetCharactersCharacterIdPlanetsPlanetIdNotFound);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanetsPlanetIdNotFound instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdPlanetsPlanetIdNotFound to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanetsPlanetIdNotFound input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Error == input.Error ||
                    (this.Error != null &&
                    this.Error.Equals(input.Error))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Error != null)
                    hashCode = hashCode * 59 + this.Error.GetHashCode();
                return hashCode;
            }
        }
    }

}