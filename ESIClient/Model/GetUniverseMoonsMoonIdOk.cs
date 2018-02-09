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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetUniverseMoonsMoonIdOk :  IEquatable<GetUniverseMoonsMoonIdOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseMoonsMoonIdOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseMoonsMoonIdOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseMoonsMoonIdOk" /> class.
        /// </summary>
        /// <param name="moonId">moon_id integer (required).</param>
        /// <param name="name">name string (required).</param>
        /// <param name="position">position (required).</param>
        /// <param name="systemId">The solar system this moon is in (required).</param>
        public GetUniverseMoonsMoonIdOk(int? moonId = default(int?), string name = default(string), GetUniverseMoonsMoonIdPosition position = default(GetUniverseMoonsMoonIdPosition), int? systemId = default(int?))
        {
            // to ensure "moonId" is required (not null)
            if (moonId == null)
            {
                throw new InvalidDataException("moonId is a required property for GetUniverseMoonsMoonIdOk and cannot be null");
            }
            else
            {
                this.MoonId = moonId;
            }
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for GetUniverseMoonsMoonIdOk and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "position" is required (not null)
            if (position == null)
            {
                throw new InvalidDataException("position is a required property for GetUniverseMoonsMoonIdOk and cannot be null");
            }
            else
            {
                this.Position = position;
            }
            // to ensure "systemId" is required (not null)
            if (systemId == null)
            {
                throw new InvalidDataException("systemId is a required property for GetUniverseMoonsMoonIdOk and cannot be null");
            }
            else
            {
                this.SystemId = systemId;
            }
        }
        
        /// <summary>
        /// moon_id integer
        /// </summary>
        /// <value>moon_id integer</value>
        [DataMember(Name="moon_id", EmitDefaultValue=false)]
        public int? MoonId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        /// <value>name string</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Position
        /// </summary>
        [DataMember(Name="position", EmitDefaultValue=false)]
        public GetUniverseMoonsMoonIdPosition Position { get; set; }

        /// <summary>
        /// The solar system this moon is in
        /// </summary>
        /// <value>The solar system this moon is in</value>
        [DataMember(Name="system_id", EmitDefaultValue=false)]
        public int? SystemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseMoonsMoonIdOk {\n");
            sb.Append("  MoonId: ").Append(MoonId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Position: ").Append(Position).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
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
            return this.Equals(input as GetUniverseMoonsMoonIdOk);
        }

        /// <summary>
        /// Returns true if GetUniverseMoonsMoonIdOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseMoonsMoonIdOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseMoonsMoonIdOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MoonId == input.MoonId ||
                    (this.MoonId != null &&
                    this.MoonId.Equals(input.MoonId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Position == input.Position ||
                    (this.Position != null &&
                    this.Position.Equals(input.Position))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
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
                if (this.MoonId != null)
                    hashCode = hashCode * 59 + this.MoonId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Position != null)
                    hashCode = hashCode * 59 + this.Position.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
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
