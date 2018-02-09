/* 
 * EVE Swagger Interface
 *
 * An OpenAPI for EVE Online
 *
 * OpenAPI spec version: 0.7.5
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = ESIClient.Client.SwaggerDateConverter;

namespace ESIClient.Model
{
    /// <summary>
    /// head object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdPlanetsPlanetIdHead :  IEquatable<GetCharactersCharacterIdPlanetsPlanetIdHead>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdHead" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdPlanetsPlanetIdHead() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdHead" /> class.
        /// </summary>
        /// <param name="headId">head_id integer (required).</param>
        /// <param name="latitude">latitude number (required).</param>
        /// <param name="longitude">longitude number (required).</param>
        public GetCharactersCharacterIdPlanetsPlanetIdHead(int? headId = default(int?), float? latitude = default(float?), float? longitude = default(float?))
        {
            // to ensure "headId" is required (not null)
            if (headId == null)
            {
                throw new InvalidDataException("headId is a required property for GetCharactersCharacterIdPlanetsPlanetIdHead and cannot be null");
            }
            else
            {
                this.HeadId = headId;
            }
            // to ensure "latitude" is required (not null)
            if (latitude == null)
            {
                throw new InvalidDataException("latitude is a required property for GetCharactersCharacterIdPlanetsPlanetIdHead and cannot be null");
            }
            else
            {
                this.Latitude = latitude;
            }
            // to ensure "longitude" is required (not null)
            if (longitude == null)
            {
                throw new InvalidDataException("longitude is a required property for GetCharactersCharacterIdPlanetsPlanetIdHead and cannot be null");
            }
            else
            {
                this.Longitude = longitude;
            }
        }
        
        /// <summary>
        /// head_id integer
        /// </summary>
        /// <value>head_id integer</value>
        [DataMember(Name="head_id", EmitDefaultValue=false)]
        public int? HeadId { get; set; }

        /// <summary>
        /// latitude number
        /// </summary>
        /// <value>latitude number</value>
        [DataMember(Name="latitude", EmitDefaultValue=false)]
        public float? Latitude { get; set; }

        /// <summary>
        /// longitude number
        /// </summary>
        /// <value>longitude number</value>
        [DataMember(Name="longitude", EmitDefaultValue=false)]
        public float? Longitude { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdHead {\n");
            sb.Append("  HeadId: ").Append(HeadId).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdPlanetsPlanetIdHead);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanetsPlanetIdHead instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdPlanetsPlanetIdHead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanetsPlanetIdHead input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.HeadId == input.HeadId ||
                    (this.HeadId != null &&
                    this.HeadId.Equals(input.HeadId))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
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
                if (this.HeadId != null)
                    hashCode = hashCode * 59 + this.HeadId.GetHashCode();
                if (this.Latitude != null)
                    hashCode = hashCode * 59 + this.Latitude.GetHashCode();
                if (this.Longitude != null)
                    hashCode = hashCode * 59 + this.Longitude.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // HeadId (int?) maximum
            if(this.HeadId > (int?)9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeadId, must be a value less than or equal to 9.", new [] { "HeadId" });
            }

            // HeadId (int?) minimum
            if(this.HeadId < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for HeadId, must be a value greater than or equal to 0.", new [] { "HeadId" });
            }

            yield break;
        }
    }

}
