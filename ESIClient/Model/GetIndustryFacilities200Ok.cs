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
    public partial class GetIndustryFacilities200Ok :  IEquatable<GetIndustryFacilities200Ok>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIndustryFacilities200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetIndustryFacilities200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetIndustryFacilities200Ok" /> class.
        /// </summary>
        /// <param name="facilityId">ID of the facility (required).</param>
        /// <param name="tax">Tax imposed by the facility.</param>
        /// <param name="ownerId">Owner of the facility (required).</param>
        /// <param name="typeId">Type ID of the facility (required).</param>
        /// <param name="solarSystemId">Solar system ID where the facility is (required).</param>
        /// <param name="regionId">Region ID where the facility is (required).</param>
        public GetIndustryFacilities200Ok(long? facilityId = default(long?), float? tax = default(float?), int? ownerId = default(int?), int? typeId = default(int?), int? solarSystemId = default(int?), int? regionId = default(int?))
        {
            // to ensure "facilityId" is required (not null)
            if (facilityId == null)
            {
                throw new InvalidDataException("facilityId is a required property for GetIndustryFacilities200Ok and cannot be null");
            }
            else
            {
                this.FacilityId = facilityId;
            }
            // to ensure "ownerId" is required (not null)
            if (ownerId == null)
            {
                throw new InvalidDataException("ownerId is a required property for GetIndustryFacilities200Ok and cannot be null");
            }
            else
            {
                this.OwnerId = ownerId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetIndustryFacilities200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
            // to ensure "solarSystemId" is required (not null)
            if (solarSystemId == null)
            {
                throw new InvalidDataException("solarSystemId is a required property for GetIndustryFacilities200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = solarSystemId;
            }
            // to ensure "regionId" is required (not null)
            if (regionId == null)
            {
                throw new InvalidDataException("regionId is a required property for GetIndustryFacilities200Ok and cannot be null");
            }
            else
            {
                this.RegionId = regionId;
            }
            this.Tax = tax;
        }
        
        /// <summary>
        /// ID of the facility
        /// </summary>
        /// <value>ID of the facility</value>
        [DataMember(Name="facility_id", EmitDefaultValue=false)]
        public long? FacilityId { get; set; }

        /// <summary>
        /// Tax imposed by the facility
        /// </summary>
        /// <value>Tax imposed by the facility</value>
        [DataMember(Name="tax", EmitDefaultValue=false)]
        public float? Tax { get; set; }

        /// <summary>
        /// Owner of the facility
        /// </summary>
        /// <value>Owner of the facility</value>
        [DataMember(Name="owner_id", EmitDefaultValue=false)]
        public int? OwnerId { get; set; }

        /// <summary>
        /// Type ID of the facility
        /// </summary>
        /// <value>Type ID of the facility</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Solar system ID where the facility is
        /// </summary>
        /// <value>Solar system ID where the facility is</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Region ID where the facility is
        /// </summary>
        /// <value>Region ID where the facility is</value>
        [DataMember(Name="region_id", EmitDefaultValue=false)]
        public int? RegionId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetIndustryFacilities200Ok {\n");
            sb.Append("  FacilityId: ").Append(FacilityId).Append("\n");
            sb.Append("  Tax: ").Append(Tax).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  RegionId: ").Append(RegionId).Append("\n");
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
            return this.Equals(input as GetIndustryFacilities200Ok);
        }

        /// <summary>
        /// Returns true if GetIndustryFacilities200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetIndustryFacilities200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetIndustryFacilities200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FacilityId == input.FacilityId ||
                    (this.FacilityId != null &&
                    this.FacilityId.Equals(input.FacilityId))
                ) && 
                (
                    this.Tax == input.Tax ||
                    (this.Tax != null &&
                    this.Tax.Equals(input.Tax))
                ) && 
                (
                    this.OwnerId == input.OwnerId ||
                    (this.OwnerId != null &&
                    this.OwnerId.Equals(input.OwnerId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
                ) && 
                (
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
                ) && 
                (
                    this.RegionId == input.RegionId ||
                    (this.RegionId != null &&
                    this.RegionId.Equals(input.RegionId))
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
                if (this.FacilityId != null)
                    hashCode = hashCode * 59 + this.FacilityId.GetHashCode();
                if (this.Tax != null)
                    hashCode = hashCode * 59 + this.Tax.GetHashCode();
                if (this.OwnerId != null)
                    hashCode = hashCode * 59 + this.OwnerId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
                if (this.RegionId != null)
                    hashCode = hashCode * 59 + this.RegionId.GetHashCode();
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
