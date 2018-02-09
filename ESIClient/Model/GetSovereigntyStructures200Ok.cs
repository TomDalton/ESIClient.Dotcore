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
    public partial class GetSovereigntyStructures200Ok :  IEquatable<GetSovereigntyStructures200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSovereigntyStructures200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetSovereigntyStructures200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSovereigntyStructures200Ok" /> class.
        /// </summary>
        /// <param name="allianceId">The alliance that owns the structure.  (required).</param>
        /// <param name="solarSystemId">Solar system in which the structure is located.  (required).</param>
        /// <param name="structureId">Unique item ID for this structure. (required).</param>
        /// <param name="structureTypeId">A reference to the type of structure this is.  (required).</param>
        /// <param name="vulnerabilityOccupancyLevel">The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure. .</param>
        /// <param name="vulnerableStartTime">The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime. .</param>
        /// <param name="vulnerableEndTime">The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to &#39;overtime&#39; and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated. .</param>
        public GetSovereigntyStructures200Ok(int? allianceId = default(int?), int? solarSystemId = default(int?), long? structureId = default(long?), int? structureTypeId = default(int?), float? vulnerabilityOccupancyLevel = default(float?), DateTime? vulnerableStartTime = default(DateTime?), DateTime? vulnerableEndTime = default(DateTime?))
        {
            // to ensure "allianceId" is required (not null)
            if (allianceId == null)
            {
                throw new InvalidDataException("allianceId is a required property for GetSovereigntyStructures200Ok and cannot be null");
            }
            else
            {
                this.AllianceId = allianceId;
            }
            // to ensure "solarSystemId" is required (not null)
            if (solarSystemId == null)
            {
                throw new InvalidDataException("solarSystemId is a required property for GetSovereigntyStructures200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = solarSystemId;
            }
            // to ensure "structureId" is required (not null)
            if (structureId == null)
            {
                throw new InvalidDataException("structureId is a required property for GetSovereigntyStructures200Ok and cannot be null");
            }
            else
            {
                this.StructureId = structureId;
            }
            // to ensure "structureTypeId" is required (not null)
            if (structureTypeId == null)
            {
                throw new InvalidDataException("structureTypeId is a required property for GetSovereigntyStructures200Ok and cannot be null");
            }
            else
            {
                this.StructureTypeId = structureTypeId;
            }
            this.VulnerabilityOccupancyLevel = vulnerabilityOccupancyLevel;
            this.VulnerableStartTime = vulnerableStartTime;
            this.VulnerableEndTime = vulnerableEndTime;
        }
        
        /// <summary>
        /// The alliance that owns the structure. 
        /// </summary>
        /// <value>The alliance that owns the structure. </value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// Solar system in which the structure is located. 
        /// </summary>
        /// <value>Solar system in which the structure is located. </value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Unique item ID for this structure.
        /// </summary>
        /// <value>Unique item ID for this structure.</value>
        [DataMember(Name="structure_id", EmitDefaultValue=false)]
        public long? StructureId { get; set; }

        /// <summary>
        /// A reference to the type of structure this is. 
        /// </summary>
        /// <value>A reference to the type of structure this is. </value>
        [DataMember(Name="structure_type_id", EmitDefaultValue=false)]
        public int? StructureTypeId { get; set; }

        /// <summary>
        /// The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure. 
        /// </summary>
        /// <value>The occupancy level for the next or current vulnerability window. This takes into account all development indexes and capital system bonuses. Also known as Activity Defense Multiplier from in the client. It increases the time that attackers must spend using their entosis links on the structure. </value>
        [DataMember(Name="vulnerability_occupancy_level", EmitDefaultValue=false)]
        public float? VulnerabilityOccupancyLevel { get; set; }

        /// <summary>
        /// The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime. 
        /// </summary>
        /// <value>The next time at which the structure will become vulnerable. Or the start time of the current window if current time is between this and vulnerableEndTime. </value>
        [DataMember(Name="vulnerable_start_time", EmitDefaultValue=false)]
        public DateTime? VulnerableStartTime { get; set; }

        /// <summary>
        /// The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to &#39;overtime&#39; and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated. 
        /// </summary>
        /// <value>The time at which the next or current vulnerability window ends. At the end of a vulnerability window the next window is recalculated and locked in along with the vulnerabilityOccupancyLevel. If the structure is not in 100% entosis control of the defender, it will go in to &#39;overtime&#39; and stay vulnerable for as long as that situation persists. Only once the defenders have 100% entosis control and has the vulnerableEndTime passed does the vulnerability interval expire and a new one is calculated. </value>
        [DataMember(Name="vulnerable_end_time", EmitDefaultValue=false)]
        public DateTime? VulnerableEndTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetSovereigntyStructures200Ok {\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  StructureId: ").Append(StructureId).Append("\n");
            sb.Append("  StructureTypeId: ").Append(StructureTypeId).Append("\n");
            sb.Append("  VulnerabilityOccupancyLevel: ").Append(VulnerabilityOccupancyLevel).Append("\n");
            sb.Append("  VulnerableStartTime: ").Append(VulnerableStartTime).Append("\n");
            sb.Append("  VulnerableEndTime: ").Append(VulnerableEndTime).Append("\n");
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
            return this.Equals(input as GetSovereigntyStructures200Ok);
        }

        /// <summary>
        /// Returns true if GetSovereigntyStructures200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetSovereigntyStructures200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetSovereigntyStructures200Ok input)
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
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
                ) && 
                (
                    this.StructureId == input.StructureId ||
                    (this.StructureId != null &&
                    this.StructureId.Equals(input.StructureId))
                ) && 
                (
                    this.StructureTypeId == input.StructureTypeId ||
                    (this.StructureTypeId != null &&
                    this.StructureTypeId.Equals(input.StructureTypeId))
                ) && 
                (
                    this.VulnerabilityOccupancyLevel == input.VulnerabilityOccupancyLevel ||
                    (this.VulnerabilityOccupancyLevel != null &&
                    this.VulnerabilityOccupancyLevel.Equals(input.VulnerabilityOccupancyLevel))
                ) && 
                (
                    this.VulnerableStartTime == input.VulnerableStartTime ||
                    (this.VulnerableStartTime != null &&
                    this.VulnerableStartTime.Equals(input.VulnerableStartTime))
                ) && 
                (
                    this.VulnerableEndTime == input.VulnerableEndTime ||
                    (this.VulnerableEndTime != null &&
                    this.VulnerableEndTime.Equals(input.VulnerableEndTime))
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
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
                if (this.StructureId != null)
                    hashCode = hashCode * 59 + this.StructureId.GetHashCode();
                if (this.StructureTypeId != null)
                    hashCode = hashCode * 59 + this.StructureTypeId.GetHashCode();
                if (this.VulnerabilityOccupancyLevel != null)
                    hashCode = hashCode * 59 + this.VulnerabilityOccupancyLevel.GetHashCode();
                if (this.VulnerableStartTime != null)
                    hashCode = hashCode * 59 + this.VulnerableStartTime.GetHashCode();
                if (this.VulnerableEndTime != null)
                    hashCode = hashCode * 59 + this.VulnerableEndTime.GetHashCode();
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
