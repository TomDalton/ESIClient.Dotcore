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
    public partial class GetFleetsFleetIdMembers200Ok :  IEquatable<GetFleetsFleetIdMembers200Ok>, IValidatableObject
    {
        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        /// <value>Member’s role in fleet</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RoleEnum
        {
            
            /// <summary>
            /// Enum Fleetcommander for value: fleet_commander
            /// </summary>
            [EnumMember(Value = "fleet_commander")]
            Fleetcommander = 1,
            
            /// <summary>
            /// Enum Wingcommander for value: wing_commander
            /// </summary>
            [EnumMember(Value = "wing_commander")]
            Wingcommander = 2,
            
            /// <summary>
            /// Enum Squadcommander for value: squad_commander
            /// </summary>
            [EnumMember(Value = "squad_commander")]
            Squadcommander = 3,
            
            /// <summary>
            /// Enum Squadmember for value: squad_member
            /// </summary>
            [EnumMember(Value = "squad_member")]
            Squadmember = 4
        }

        /// <summary>
        /// Member’s role in fleet
        /// </summary>
        /// <value>Member’s role in fleet</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public RoleEnum Role { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFleetsFleetIdMembers200Ok" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFleetsFleetIdMembers200Ok() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFleetsFleetIdMembers200Ok" /> class.
        /// </summary>
        /// <param name="characterId">character_id integer (required).</param>
        /// <param name="shipTypeId">ship_type_id integer (required).</param>
        /// <param name="wingId">ID of the wing the member is in. If not applicable, will be set to -1 (required).</param>
        /// <param name="squadId">ID of the squad the member is in. If not applicable, will be set to -1 (required).</param>
        /// <param name="role">Member’s role in fleet (required).</param>
        /// <param name="roleName">Localized role names (required).</param>
        /// <param name="joinTime">join_time string (required).</param>
        /// <param name="takesFleetWarp">Whether the member take fleet warps (required).</param>
        /// <param name="solarSystemId">Solar system the member is located in (required).</param>
        /// <param name="stationId">Station in which the member is docked in, if applicable.</param>
        public GetFleetsFleetIdMembers200Ok(int? characterId = default(int?), int? shipTypeId = default(int?), long? wingId = default(long?), long? squadId = default(long?), RoleEnum role = default(RoleEnum), string roleName = default(string), DateTime? joinTime = default(DateTime?), bool? takesFleetWarp = default(bool?), int? solarSystemId = default(int?), long? stationId = default(long?))
        {
            // to ensure "characterId" is required (not null)
            if (characterId == null)
            {
                throw new InvalidDataException("characterId is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.CharacterId = characterId;
            }
            // to ensure "shipTypeId" is required (not null)
            if (shipTypeId == null)
            {
                throw new InvalidDataException("shipTypeId is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.ShipTypeId = shipTypeId;
            }
            // to ensure "wingId" is required (not null)
            if (wingId == null)
            {
                throw new InvalidDataException("wingId is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.WingId = wingId;
            }
            // to ensure "squadId" is required (not null)
            if (squadId == null)
            {
                throw new InvalidDataException("squadId is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.SquadId = squadId;
            }
            // to ensure "role" is required (not null)
            if (role == null)
            {
                throw new InvalidDataException("role is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.Role = role;
            }
            // to ensure "roleName" is required (not null)
            if (roleName == null)
            {
                throw new InvalidDataException("roleName is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.RoleName = roleName;
            }
            // to ensure "joinTime" is required (not null)
            if (joinTime == null)
            {
                throw new InvalidDataException("joinTime is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.JoinTime = joinTime;
            }
            // to ensure "takesFleetWarp" is required (not null)
            if (takesFleetWarp == null)
            {
                throw new InvalidDataException("takesFleetWarp is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.TakesFleetWarp = takesFleetWarp;
            }
            // to ensure "solarSystemId" is required (not null)
            if (solarSystemId == null)
            {
                throw new InvalidDataException("solarSystemId is a required property for GetFleetsFleetIdMembers200Ok and cannot be null");
            }
            else
            {
                this.SolarSystemId = solarSystemId;
            }
            this.StationId = stationId;
        }
        
        /// <summary>
        /// character_id integer
        /// </summary>
        /// <value>character_id integer</value>
        [DataMember(Name="character_id", EmitDefaultValue=false)]
        public int? CharacterId { get; set; }

        /// <summary>
        /// ship_type_id integer
        /// </summary>
        /// <value>ship_type_id integer</value>
        [DataMember(Name="ship_type_id", EmitDefaultValue=false)]
        public int? ShipTypeId { get; set; }

        /// <summary>
        /// ID of the wing the member is in. If not applicable, will be set to -1
        /// </summary>
        /// <value>ID of the wing the member is in. If not applicable, will be set to -1</value>
        [DataMember(Name="wing_id", EmitDefaultValue=false)]
        public long? WingId { get; set; }

        /// <summary>
        /// ID of the squad the member is in. If not applicable, will be set to -1
        /// </summary>
        /// <value>ID of the squad the member is in. If not applicable, will be set to -1</value>
        [DataMember(Name="squad_id", EmitDefaultValue=false)]
        public long? SquadId { get; set; }


        /// <summary>
        /// Localized role names
        /// </summary>
        /// <value>Localized role names</value>
        [DataMember(Name="role_name", EmitDefaultValue=false)]
        public string RoleName { get; set; }

        /// <summary>
        /// join_time string
        /// </summary>
        /// <value>join_time string</value>
        [DataMember(Name="join_time", EmitDefaultValue=false)]
        public DateTime? JoinTime { get; set; }

        /// <summary>
        /// Whether the member take fleet warps
        /// </summary>
        /// <value>Whether the member take fleet warps</value>
        [DataMember(Name="takes_fleet_warp", EmitDefaultValue=false)]
        public bool? TakesFleetWarp { get; set; }

        /// <summary>
        /// Solar system the member is located in
        /// </summary>
        /// <value>Solar system the member is located in</value>
        [DataMember(Name="solar_system_id", EmitDefaultValue=false)]
        public int? SolarSystemId { get; set; }

        /// <summary>
        /// Station in which the member is docked in, if applicable
        /// </summary>
        /// <value>Station in which the member is docked in, if applicable</value>
        [DataMember(Name="station_id", EmitDefaultValue=false)]
        public long? StationId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFleetsFleetIdMembers200Ok {\n");
            sb.Append("  CharacterId: ").Append(CharacterId).Append("\n");
            sb.Append("  ShipTypeId: ").Append(ShipTypeId).Append("\n");
            sb.Append("  WingId: ").Append(WingId).Append("\n");
            sb.Append("  SquadId: ").Append(SquadId).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  JoinTime: ").Append(JoinTime).Append("\n");
            sb.Append("  TakesFleetWarp: ").Append(TakesFleetWarp).Append("\n");
            sb.Append("  SolarSystemId: ").Append(SolarSystemId).Append("\n");
            sb.Append("  StationId: ").Append(StationId).Append("\n");
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
            return this.Equals(input as GetFleetsFleetIdMembers200Ok);
        }

        /// <summary>
        /// Returns true if GetFleetsFleetIdMembers200Ok instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFleetsFleetIdMembers200Ok to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFleetsFleetIdMembers200Ok input)
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
                    this.ShipTypeId == input.ShipTypeId ||
                    (this.ShipTypeId != null &&
                    this.ShipTypeId.Equals(input.ShipTypeId))
                ) && 
                (
                    this.WingId == input.WingId ||
                    (this.WingId != null &&
                    this.WingId.Equals(input.WingId))
                ) && 
                (
                    this.SquadId == input.SquadId ||
                    (this.SquadId != null &&
                    this.SquadId.Equals(input.SquadId))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.RoleName == input.RoleName ||
                    (this.RoleName != null &&
                    this.RoleName.Equals(input.RoleName))
                ) && 
                (
                    this.JoinTime == input.JoinTime ||
                    (this.JoinTime != null &&
                    this.JoinTime.Equals(input.JoinTime))
                ) && 
                (
                    this.TakesFleetWarp == input.TakesFleetWarp ||
                    (this.TakesFleetWarp != null &&
                    this.TakesFleetWarp.Equals(input.TakesFleetWarp))
                ) && 
                (
                    this.SolarSystemId == input.SolarSystemId ||
                    (this.SolarSystemId != null &&
                    this.SolarSystemId.Equals(input.SolarSystemId))
                ) && 
                (
                    this.StationId == input.StationId ||
                    (this.StationId != null &&
                    this.StationId.Equals(input.StationId))
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
                if (this.ShipTypeId != null)
                    hashCode = hashCode * 59 + this.ShipTypeId.GetHashCode();
                if (this.WingId != null)
                    hashCode = hashCode * 59 + this.WingId.GetHashCode();
                if (this.SquadId != null)
                    hashCode = hashCode * 59 + this.SquadId.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.RoleName != null)
                    hashCode = hashCode * 59 + this.RoleName.GetHashCode();
                if (this.JoinTime != null)
                    hashCode = hashCode * 59 + this.JoinTime.GetHashCode();
                if (this.TakesFleetWarp != null)
                    hashCode = hashCode * 59 + this.TakesFleetWarp.GetHashCode();
                if (this.SolarSystemId != null)
                    hashCode = hashCode * 59 + this.SolarSystemId.GetHashCode();
                if (this.StationId != null)
                    hashCode = hashCode * 59 + this.StationId.GetHashCode();
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
