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
    /// graphic object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdMedalsGraphic :  IEquatable<GetCharactersCharacterIdMedalsGraphic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMedalsGraphic" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdMedalsGraphic() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdMedalsGraphic" /> class.
        /// </summary>
        /// <param name="part">part integer (required).</param>
        /// <param name="layer">layer integer (required).</param>
        /// <param name="graphic">graphic string (required).</param>
        /// <param name="color">color integer.</param>
        public GetCharactersCharacterIdMedalsGraphic(int? part = default(int?), int? layer = default(int?), string graphic = default(string), int? color = default(int?))
        {
            // to ensure "part" is required (not null)
            if (part == null)
            {
                throw new InvalidDataException("part is a required property for GetCharactersCharacterIdMedalsGraphic and cannot be null");
            }
            else
            {
                this.Part = part;
            }
            // to ensure "layer" is required (not null)
            if (layer == null)
            {
                throw new InvalidDataException("layer is a required property for GetCharactersCharacterIdMedalsGraphic and cannot be null");
            }
            else
            {
                this.Layer = layer;
            }
            // to ensure "graphic" is required (not null)
            if (graphic == null)
            {
                throw new InvalidDataException("graphic is a required property for GetCharactersCharacterIdMedalsGraphic and cannot be null");
            }
            else
            {
                this.Graphic = graphic;
            }
            this.Color = color;
        }
        
        /// <summary>
        /// part integer
        /// </summary>
        /// <value>part integer</value>
        [DataMember(Name="part", EmitDefaultValue=false)]
        public int? Part { get; set; }

        /// <summary>
        /// layer integer
        /// </summary>
        /// <value>layer integer</value>
        [DataMember(Name="layer", EmitDefaultValue=false)]
        public int? Layer { get; set; }

        /// <summary>
        /// graphic string
        /// </summary>
        /// <value>graphic string</value>
        [DataMember(Name="graphic", EmitDefaultValue=false)]
        public string Graphic { get; set; }

        /// <summary>
        /// color integer
        /// </summary>
        /// <value>color integer</value>
        [DataMember(Name="color", EmitDefaultValue=false)]
        public int? Color { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdMedalsGraphic {\n");
            sb.Append("  Part: ").Append(Part).Append("\n");
            sb.Append("  Layer: ").Append(Layer).Append("\n");
            sb.Append("  Graphic: ").Append(Graphic).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdMedalsGraphic);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdMedalsGraphic instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdMedalsGraphic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdMedalsGraphic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Part == input.Part ||
                    (this.Part != null &&
                    this.Part.Equals(input.Part))
                ) && 
                (
                    this.Layer == input.Layer ||
                    (this.Layer != null &&
                    this.Layer.Equals(input.Layer))
                ) && 
                (
                    this.Graphic == input.Graphic ||
                    (this.Graphic != null &&
                    this.Graphic.Equals(input.Graphic))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
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
                if (this.Part != null)
                    hashCode = hashCode * 59 + this.Part.GetHashCode();
                if (this.Layer != null)
                    hashCode = hashCode * 59 + this.Layer.GetHashCode();
                if (this.Graphic != null)
                    hashCode = hashCode * 59 + this.Graphic.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
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
            yield break;
        }
    }

}
