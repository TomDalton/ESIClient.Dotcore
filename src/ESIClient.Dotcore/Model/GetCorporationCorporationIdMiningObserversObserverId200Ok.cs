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
    /// 200 ok object
    /// </summary>
    [DataContract]
    public partial class GetCorporationCorporationIdMiningObserversObserverId200Ok :  IEquatable<GetCorporationCorporationIdMiningObserversObserverId200Ok>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationCorporationIdMiningObserversObserverId200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCorporationCorporationIdMiningObserversObserverId200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCorporationCorporationIdMiningObserversObserverId200Ok" /> class.
        /// </summary>
        /// <param name="characterId">The character that did the mining  (required).</param>
        /// <param name="lastUpdated">last_updated string (required).</param>
        /// <param name="quantity">quantity integer (required).</param>
        /// <param name="recordedCorporationId">The corporation id of the character at the time data was recorded.  (required).</param>
        /// <param name="typeId">type_id integer (required).</param>
        public GetCorporationCorporationIdMiningObserversObserverId200Ok(int? characterId = default(int?), DateTime? lastUpdated = default(DateTime?), long? quantity = default(long?), int? recordedCorporationId = default(int?), int? typeId = default(int?))
        {
            // to ensure "characterId" is required (not null)
            if (characterId == null)
            {
                throw new InvalidDataException("characterId is a required property for GetCorporationCorporationIdMiningObserversObserverId200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = characterId;
            }
            // to ensure "lastUpdated" is required (not null)
            if (lastUpdated == null)
            {
                throw new InvalidDataException("lastUpdated is a required property for GetCorporationCorporationIdMiningObserversObserverId200Ok and cannot be null");
            }
            else
            {
                this.LastUpdated = lastUpdated;
            }
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new InvalidDataException("quantity is a required property for GetCorporationCorporationIdMiningObserversObserverId200Ok and cannot be null");
            }
            else
            {
                this.Quantity = quantity;
            }
            // to ensure "recordedCorporationId" is required (not null)
            if (recordedCorporationId == null)
            {
                throw new InvalidDataException("recordedCorporationId is a required property for GetCorporationCorporationIdMiningObserversObserverId200Ok and cannot be null");
            }
            else
            {
                this.RecordedCorporationId = recordedCorporationId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCorporationCorporationIdMiningObserversObserverId200Ok and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
        }
        
        /// <summary>
        /// The character that did the mining 
        /// </summary>
        /// <value>The character that did the mining </value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// last_updated string
        /// </summary>
        /// <value>last_updated string</value>
        [DataMember(Name="last_updated", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? LastUpdated { get; set; }

        /// <summary>
        /// quantity integer
        /// </summary>
        /// <value>quantity integer</value>
        [DataMember(Name="quantity", EmitDefaultValue=false)]
        public long? Quantity { get; set; }

        /// <summary>
        /// The corporation id of the character at the time data was recorded. 
        /// </summary>
        /// <value>The corporation id of the character at the time data was recorded. </value>
        [DataMember(Name="recorded_corporation_id", EmitDefaultValue=false)]
        public int? RecordedCorporationId { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        /// <value>type_id integer</value>
        [DataMember(Name="type_id", EmitDefaultValue=false)]
        public int? TypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCorporationCorporationIdMiningObserversObserverId200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  LastUpdated: ").Append(LastUpdated).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  RecordedCorporationId: ").Append(RecordedCorporationId).Append("\n");
            sb.Append("  TypeId: ").Append(TypeId).Append("\n");
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
            return this.Equals(input as GetCorporationCorporationIdMiningObserversObserverId200Ok);
        }

        /// <summary>
        /// Returns true if GetCorporationCorporationIdMiningObserversObserverId200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCorporationCorporationIdMiningObserversObserverId200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCorporationCorporationIdMiningObserversObserverId200Ok input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.LastUpdated == input.LastUpdated ||
                    (this.LastUpdated != null &&
                    this.LastUpdated.Equals(input.LastUpdated))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.RecordedCorporationId == input.RecordedCorporationId ||
                    (this.RecordedCorporationId != null &&
                    this.RecordedCorporationId.Equals(input.RecordedCorporationId))
                ) && 
                (
                    this.TypeId == input.TypeId ||
                    (this.TypeId != null &&
                    this.TypeId.Equals(input.TypeId))
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
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.LastUpdated != null)
                    hashCode = hashCode * 59 + this.LastUpdated.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.RecordedCorporationId != null)
                    hashCode = hashCode * 59 + this.RecordedCorporationId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}
