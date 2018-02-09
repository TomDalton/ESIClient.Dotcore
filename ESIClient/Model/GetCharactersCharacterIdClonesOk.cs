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
    public partial class GetCharactersCharacterIdClonesOk :  IEquatable<GetCharactersCharacterIdClonesOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdClonesOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdClonesOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdClonesOk" /> class.
        /// </summary>
        /// <param name="lastCloneJumpDate">last_clone_jump_date string.</param>
        /// <param name="homeLocation">homeLocation.</param>
        /// <param name="lastStationChangeDate">last_station_change_date string.</param>
        /// <param name="jumpClones">jump_clones array (required).</param>
        public GetCharactersCharacterIdClonesOk(DateTime? lastCloneJumpDate = default(DateTime?), GetCharactersCharacterIdClonesHomeLocation homeLocation = default(GetCharactersCharacterIdClonesHomeLocation), DateTime? lastStationChangeDate = default(DateTime?), List<GetCharactersCharacterIdClonesJumpClone> jumpClones = default(List<GetCharactersCharacterIdClonesJumpClone>))
        {
            // to ensure "jumpClones" is required (not null)
            if (jumpClones == null)
            {
                throw new InvalidDataException("jumpClones is a required property for GetCharactersCharacterIdClonesOk and cannot be null");
            }
            else
            {
                this.JumpClones = jumpClones;
            }
            this.LastCloneJumpDate = lastCloneJumpDate;
            this.HomeLocation = homeLocation;
            this.LastStationChangeDate = lastStationChangeDate;
        }
        
        /// <summary>
        /// last_clone_jump_date string
        /// </summary>
        /// <value>last_clone_jump_date string</value>
        [DataMember(Name="last_clone_jump_date", EmitDefaultValue=false)]
        public DateTime? LastCloneJumpDate { get; set; }

        /// <summary>
        /// Gets or Sets HomeLocation
        /// </summary>
        [DataMember(Name="home_location", EmitDefaultValue=false)]
        public GetCharactersCharacterIdClonesHomeLocation HomeLocation { get; set; }

        /// <summary>
        /// last_station_change_date string
        /// </summary>
        /// <value>last_station_change_date string</value>
        [DataMember(Name="last_station_change_date", EmitDefaultValue=false)]
        public DateTime? LastStationChangeDate { get; set; }

        /// <summary>
        /// jump_clones array
        /// </summary>
        /// <value>jump_clones array</value>
        [DataMember(Name="jump_clones", EmitDefaultValue=false)]
        public List<GetCharactersCharacterIdClonesJumpClone> JumpClones { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdClonesOk {\n");
            sb.Append("  LastCloneJumpDate: ").Append(LastCloneJumpDate).Append("\n");
            sb.Append("  HomeLocation: ").Append(HomeLocation).Append("\n");
            sb.Append("  LastStationChangeDate: ").Append(LastStationChangeDate).Append("\n");
            sb.Append("  JumpClones: ").Append(JumpClones).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdClonesOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdClonesOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdClonesOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdClonesOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.LastCloneJumpDate == input.LastCloneJumpDate ||
                    (this.LastCloneJumpDate != null &&
                    this.LastCloneJumpDate.Equals(input.LastCloneJumpDate))
                ) && 
                (
                    this.HomeLocation == input.HomeLocation ||
                    (this.HomeLocation != null &&
                    this.HomeLocation.Equals(input.HomeLocation))
                ) && 
                (
                    this.LastStationChangeDate == input.LastStationChangeDate ||
                    (this.LastStationChangeDate != null &&
                    this.LastStationChangeDate.Equals(input.LastStationChangeDate))
                ) && 
                (
                    this.JumpClones == input.JumpClones ||
                    this.JumpClones != null &&
                    this.JumpClones.SequenceEqual(input.JumpClones)
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
                if (this.LastCloneJumpDate != null)
                    hashCode = hashCode * 59 + this.LastCloneJumpDate.GetHashCode();
                if (this.HomeLocation != null)
                    hashCode = hashCode * 59 + this.HomeLocation.GetHashCode();
                if (this.LastStationChangeDate != null)
                    hashCode = hashCode * 59 + this.LastStationChangeDate.GetHashCode();
                if (this.JumpClones != null)
                    hashCode = hashCode * 59 + this.JumpClones.GetHashCode();
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
