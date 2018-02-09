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
    /// Summary of kills done by the given corporation against enemy factions
    /// </summary>
    [DataContract]
    public partial class GetCorporationsCorporationIdFwStatsKills :  IEquatable<GetCorporationsCorporationIdFwStatsKills>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFwStatsKills" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationsCorporationIdFwStatsKills() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationsCorporationIdFwStatsKills" /> class.
        /// </summary>
        /// <param name="yesterday">Yesterday&#39;s total number of kills by members of the given corporation against enemy factions (required).</param>
        /// <param name="lastWeek">Last week&#39;s total number of kills by members of the given corporation against enemy factions (required).</param>
        /// <param name="total">Total number of kills by members of the given corporation against enemy factions since the corporation enlisted (required).</param>
        public GetCorporationsCorporationIdFwStatsKills(int? yesterday = default(int?), int? lastWeek = default(int?), int? total = default(int?))
        {
            // to ensure "yesterday" is required (not null)
            if (yesterday == null)
            {
                throw new InvalidDataException("yesterday is a required property for GetCorporationsCorporationIdFwStatsKills and cannot be null");
            }
            else
            {
                this.Yesterday = yesterday;
            }
            // to ensure "lastWeek" is required (not null)
            if (lastWeek == null)
            {
                throw new InvalidDataException("lastWeek is a required property for GetCorporationsCorporationIdFwStatsKills and cannot be null");
            }
            else
            {
                this.LastWeek = lastWeek;
            }
            // to ensure "total" is required (not null)
            if (total == null)
            {
                throw new InvalidDataException("total is a required property for GetCorporationsCorporationIdFwStatsKills and cannot be null");
            }
            else
            {
                this.Total = total;
            }
        }
        
        /// <summary>
        /// Yesterday&#39;s total number of kills by members of the given corporation against enemy factions
        /// </summary>
        /// <value>Yesterday&#39;s total number of kills by members of the given corporation against enemy factions</value>
        [DataMember(Name="yesterday", EmitDefaultValue=false)]
        public int? Yesterday { get; set; }

        /// <summary>
        /// Last week&#39;s total number of kills by members of the given corporation against enemy factions
        /// </summary>
        /// <value>Last week&#39;s total number of kills by members of the given corporation against enemy factions</value>
        [DataMember(Name="last_week", EmitDefaultValue=false)]
        public int? LastWeek { get; set; }

        /// <summary>
        /// Total number of kills by members of the given corporation against enemy factions since the corporation enlisted
        /// </summary>
        /// <value>Total number of kills by members of the given corporation against enemy factions since the corporation enlisted</value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationsCorporationIdFwStatsKills {\n");
            sb.Append("  Yesterday: ").Append(Yesterday).Append("\n");
            sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as GetCorporationsCorporationIdFwStatsKills);
        }

        /// <summary>
        /// Returns true if GetCorporationsCorporationIdFwStatsKills instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationsCorporationIdFwStatsKills to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationsCorporationIdFwStatsKills input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Yesterday == input.Yesterday ||
                    (this.Yesterday != null &&
                    this.Yesterday.Equals(input.Yesterday))
                ) && 
                (
                    this.LastWeek == input.LastWeek ||
                    (this.LastWeek != null &&
                    this.LastWeek.Equals(input.LastWeek))
                ) && 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
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
                if (this.Yesterday != null)
                    hashCode = hashCode * 59 + this.Yesterday.GetHashCode();
                if (this.LastWeek != null)
                    hashCode = hashCode * 59 + this.LastWeek.GetHashCode();
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
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
