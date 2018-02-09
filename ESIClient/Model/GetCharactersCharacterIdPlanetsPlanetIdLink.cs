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
    /// link object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdPlanetsPlanetIdLink :  IEquatable<GetCharactersCharacterIdPlanetsPlanetIdLink>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdPlanetsPlanetIdLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdPlanetsPlanetIdLink" /> class.
        /// </summary>
        /// <param name="sourcePinId">source_pin_id integer (required).</param>
        /// <param name="destinationPinId">destination_pin_id integer (required).</param>
        /// <param name="linkLevel">link_level integer (required).</param>
        public GetCharactersCharacterIdPlanetsPlanetIdLink(long? sourcePinId = default(long?), long? destinationPinId = default(long?), int? linkLevel = default(int?))
        {
            // to ensure "sourcePinId" is required (not null)
            if (sourcePinId == null)
            {
                throw new InvalidDataException("sourcePinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.SourcePinId = sourcePinId;
            }
            // to ensure "destinationPinId" is required (not null)
            if (destinationPinId == null)
            {
                throw new InvalidDataException("destinationPinId is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.DestinationPinId = destinationPinId;
            }
            // to ensure "linkLevel" is required (not null)
            if (linkLevel == null)
            {
                throw new InvalidDataException("linkLevel is a required property for GetCharactersCharacterIdPlanetsPlanetIdLink and cannot be null");
            }
            else
            {
                this.LinkLevel = linkLevel;
            }
        }
        
        /// <summary>
        /// source_pin_id integer
        /// </summary>
        /// <value>source_pin_id integer</value>
        [DataMember(Name="source_pin_id", EmitDefaultValue=false)]
        public long? SourcePinId { get; set; }

        /// <summary>
        /// destination_pin_id integer
        /// </summary>
        /// <value>destination_pin_id integer</value>
        [DataMember(Name="destination_pin_id", EmitDefaultValue=false)]
        public long? DestinationPinId { get; set; }

        /// <summary>
        /// link_level integer
        /// </summary>
        /// <value>link_level integer</value>
        [DataMember(Name="link_level", EmitDefaultValue=false)]
        public int? LinkLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdPlanetsPlanetIdLink {\n");
            sb.Append("  SourcePinId: ").Append(SourcePinId).Append("\n");
            sb.Append("  DestinationPinId: ").Append(DestinationPinId).Append("\n");
            sb.Append("  LinkLevel: ").Append(LinkLevel).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdPlanetsPlanetIdLink);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdPlanetsPlanetIdLink instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdPlanetsPlanetIdLink to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdPlanetsPlanetIdLink input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SourcePinId == input.SourcePinId ||
                    (this.SourcePinId != null &&
                    this.SourcePinId.Equals(input.SourcePinId))
                ) && 
                (
                    this.DestinationPinId == input.DestinationPinId ||
                    (this.DestinationPinId != null &&
                    this.DestinationPinId.Equals(input.DestinationPinId))
                ) && 
                (
                    this.LinkLevel == input.LinkLevel ||
                    (this.LinkLevel != null &&
                    this.LinkLevel.Equals(input.LinkLevel))
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
                if (this.SourcePinId != null)
                    hashCode = hashCode * 59 + this.SourcePinId.GetHashCode();
                if (this.DestinationPinId != null)
                    hashCode = hashCode * 59 + this.DestinationPinId.GetHashCode();
                if (this.LinkLevel != null)
                    hashCode = hashCode * 59 + this.LinkLevel.GetHashCode();
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
            // LinkLevel (int?) maximum
            if(this.LinkLevel > (int?)10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkLevel, must be a value less than or equal to 10.", new [] { "LinkLevel" });
            }

            // LinkLevel (int?) minimum
            if(this.LinkLevel < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LinkLevel, must be a value greater than or equal to 0.", new [] { "LinkLevel" });
            }

            yield break;
        }
    }

}
