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
    /// Extra information for different type of transaction
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdWalletJournalExtraInfo :  IEquatable<GetCharactersCharacterIdWalletJournalExtraInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdWalletJournalExtraInfo" /> class.
        /// </summary>
        /// <param name="locationId">location_id integer.</param>
        /// <param name="transactionId">transaction_id integer.</param>
        /// <param name="npcName">npc_name string.</param>
        /// <param name="npcId">npc_id integer.</param>
        /// <param name="destroyedShipTypeId">destroyed_ship_type_id integer.</param>
        /// <param name="characterId">character_id integer.</param>
        /// <param name="corporationId">corporation_id integer.</param>
        /// <param name="allianceId">alliance_id integer.</param>
        /// <param name="jobId">job_id integer.</param>
        /// <param name="contractId">contract_id integer.</param>
        /// <param name="systemId">system_id integer.</param>
        /// <param name="planetId">planet_id integer.</param>
        public GetCharactersCharacterIdWalletJournalExtraInfo(long? locationId = default(long?), long? transactionId = default(long?), string npcName = default(string), int? npcId = default(int?), int? destroyedShipTypeId = default(int?), int? characterId = default(int?), int? corporationId = default(int?), int? allianceId = default(int?), int? jobId = default(int?), int? contractId = default(int?), int? systemId = default(int?), int? planetId = default(int?))
        {
            this.LocationId = locationId;
            this.TransactionId = transactionId;
            this.NpcName = npcName;
            this.NpcId = npcId;
            this.DestroyedShipTypeId = destroyedShipTypeId;
            this.CharacterId = characterId;
            this.CorporationId = corporationId;
            this.AllianceId = allianceId;
            this.JobId = jobId;
            this.ContractId = contractId;
            this.SystemId = systemId;
            this.PlanetId = planetId;
        }
        
        /// <summary>
        /// location_id integer
        /// </summary>
        /// <value>location_id integer</value>
        [DataMember(Name="location_id", EmitDefaultValue=false)]
        public long? LocationId { get; set; }

        /// <summary>
        /// transaction_id integer
        /// </summary>
        /// <value>transaction_id integer</value>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public long? TransactionId { get; set; }

        /// <summary>
        /// npc_name string
        /// </summary>
        /// <value>npc_name string</value>
        [DataMember(Name="npc_name", EmitDefaultValue=false)]
        public string NpcName { get; set; }

        /// <summary>
        /// npc_id integer
        /// </summary>
        /// <value>npc_id integer</value>
        [DataMember(Name="npc_id", EmitDefaultValue=false)]
        public int? NpcId { get; set; }

        /// <summary>
        /// destroyed_ship_type_id integer
        /// </summary>
        /// <value>destroyed_ship_type_id integer</value>
        [DataMember(Name="destroyed_ship_type_id", EmitDefaultValue=false)]
        public int? DestroyedShipTypeId { get; set; }

        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        /// <value>corporation_id integer</value>
        [DataMember(Name="corporation_id", EmitDefaultValue=false)]
        public int? CorporationId { get; set; }

        /// <summary>
        /// alliance_id integer
        /// </summary>
        /// <value>alliance_id integer</value>
        [DataMember(Name="alliance_id", EmitDefaultValue=false)]
        public int? AllianceId { get; set; }

        /// <summary>
        /// job_id integer
        /// </summary>
        /// <value>job_id integer</value>
        [DataMember(Name="job_id", EmitDefaultValue=false)]
        public int? JobId { get; set; }

        /// <summary>
        /// contract_id integer
        /// </summary>
        /// <value>contract_id integer</value>
        [DataMember(Name="contract_id", EmitDefaultValue=false)]
        public int? ContractId { get; set; }

        /// <summary>
        /// system_id integer
        /// </summary>
        /// <value>system_id integer</value>
        [DataMember(Name="system_id", EmitDefaultValue=false)]
        public int? SystemId { get; set; }

        /// <summary>
        /// planet_id integer
        /// </summary>
        /// <value>planet_id integer</value>
        [DataMember(Name="planet_id", EmitDefaultValue=false)]
        public int? PlanetId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdWalletJournalExtraInfo {\n");
            sb.Append("  LocationId: ").Append(LocationId).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  NpcName: ").Append(NpcName).Append("\n");
            sb.Append("  NpcId: ").Append(NpcId).Append("\n");
            sb.Append("  DestroyedShipTypeId: ").Append(DestroyedShipTypeId).Append("\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  CorporationId: ").Append(CorporationId).Append("\n");
            sb.Append("  AllianceId: ").Append(AllianceId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  ContractId: ").Append(ContractId).Append("\n");
            sb.Append("  SystemId: ").Append(SystemId).Append("\n");
            sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdWalletJournalExtraInfo);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdWalletJournalExtraInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdWalletJournalExtraInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdWalletJournalExtraInfo input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LocationId == input.LocationId ||
                    (this.LocationId != null &&
                    this.LocationId.Equals(input.LocationId))
                ) && 
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) && 
                (
                    this.NpcName == input.NpcName ||
                    (this.NpcName != null &&
                    this.NpcName.Equals(input.NpcName))
                ) && 
                (
                    this.NpcId == input.NpcId ||
                    (this.NpcId != null &&
                    this.NpcId.Equals(input.NpcId))
                ) && 
                (
                    this.DestroyedShipTypeId == input.DestroyedShipTypeId ||
                    (this.DestroyedShipTypeId != null &&
                    this.DestroyedShipTypeId.Equals(input.DestroyedShipTypeId))
                ) && 
                (
                    this.CharacterId == input.CharacterId ||
                    (this.CharacterId != null &&
                    this.CharacterId.Equals(input.CharacterId))
                ) && 
                (
                    this.CorporationId == input.CorporationId ||
                    (this.CorporationId != null &&
                    this.CorporationId.Equals(input.CorporationId))
                ) && 
                (
                    this.AllianceId == input.AllianceId ||
                    (this.AllianceId != null &&
                    this.AllianceId.Equals(input.AllianceId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.ContractId == input.ContractId ||
                    (this.ContractId != null &&
                    this.ContractId.Equals(input.ContractId))
                ) && 
                (
                    this.SystemId == input.SystemId ||
                    (this.SystemId != null &&
                    this.SystemId.Equals(input.SystemId))
                ) && 
                (
                    this.PlanetId == input.PlanetId ||
                    (this.PlanetId != null &&
                    this.PlanetId.Equals(input.PlanetId))
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
                if (this.LocationId != null)
                    hashCode = hashCode * 59 + this.LocationId.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                if (this.NpcName != null)
                    hashCode = hashCode * 59 + this.NpcName.GetHashCode();
                if (this.NpcId != null)
                    hashCode = hashCode * 59 + this.NpcId.GetHashCode();
                if (this.DestroyedShipTypeId != null)
                    hashCode = hashCode * 59 + this.DestroyedShipTypeId.GetHashCode();
                if (this.CharacterId != null)
                    hashCode = hashCode * 59 + this.CharacterId.GetHashCode();
                if (this.CorporationId != null)
                    hashCode = hashCode * 59 + this.CorporationId.GetHashCode();
                if (this.AllianceId != null)
                    hashCode = hashCode * 59 + this.AllianceId.GetHashCode();
                if (this.JobId != null)
                    hashCode = hashCode * 59 + this.JobId.GetHashCode();
                if (this.ContractId != null)
                    hashCode = hashCode * 59 + this.ContractId.GetHashCode();
                if (this.SystemId != null)
                    hashCode = hashCode * 59 + this.SystemId.GetHashCode();
                if (this.PlanetId != null)
                    hashCode = hashCode * 59 + this.PlanetId.GetHashCode();
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
