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
    public partial class GetAlliancesNames200Ok :  IEquatable<GetAlliancesNames200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlliancesNames200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetAlliancesNames200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetAlliancesNames200Ok" /> class.
        /// </summary>
        /// <param name="allianceId">alliance_id integer (required).</param>
        /// <param name="allianceName">alliance_name string (required).</param>
        public GetAlliancesNames200Ok(int? allianceId = default(int?), string allianceName = default(string))
        {
            // to ensure "allianceId" is required (not null)
            if (allianceId == null)
            {
                throw new InvalidDataException("allianceId is a required property for GetAlliancesNames200Ok and cannot be null");
            }
            else
            {
                this.AllianceId = allianceId;
            }
            // to ensure "allianceName" is required (not null)
            if (allianceName == null)
            {
                throw new InvalidDataException("allianceName is a required property for GetAlliancesNames200Ok and cannot be null");
            }
            else
            {
                this.AllianceName = allianceName;
            }
        }
        
        /// <summary>
        /// alliance_id integer
        /// </summary>
        /// <value>alliance_id integer</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// alliance_name string
        /// </summary>
        /// <value>alliance_name string</value>
        [DataMember(Name="alliance_name", EmitDefaultValue=false)]
        public string AllianceName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetAlliancesNames200Ok {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  AllianceName: ").Append(AllianceName).Append("\n");
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
            return this.Equals(input as GetAlliancesNames200Ok);
        }

        /// <summary>
        /// Returns true if GetAlliancesNames200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetAlliancesNames200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetAlliancesNames200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AllianceId == input.AllianceId ||
                    (this.AllianceId != null &&
                    this.AllianceId.Equals(input.AllianceId))
                ) && 
                (
                    this.AllianceName == input.AllianceName ||
                    (this.AllianceName != null &&
                    this.AllianceName.Equals(input.AllianceName))
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
                if (this.AllianceId != null)
                    hashCode = hashCode * 59 + this.AllianceId.GetHashCode();
                if (this.AllianceName != null)
                    hashCode = hashCode * 59 + this.AllianceName.GetHashCode();
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
