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
    public partial class GetCharactersCharacterIdAttributesOk :  IEquatable<GetCharactersCharacterIdAttributesOk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdAttributesOk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdAttributesOk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdAttributesOk" /> class.
        /// </summary>
        /// <param name="charisma">charisma integer (required).</param>
        /// <param name="intelligence">intelligence integer (required).</param>
        /// <param name="memory">memory integer (required).</param>
        /// <param name="perception">perception integer (required).</param>
        /// <param name="willpower">willpower integer (required).</param>
        /// <param name="bonusRemaps">Number of available bonus character neural remaps.</param>
        /// <param name="lastRemapDate">Datetime of last neural remap, including usage of bonus remaps.</param>
        /// <param name="accruedRemapCooldownDate">Neural remapping cooldown after a character uses remap accrued over time.</param>
        public GetCharactersCharacterIdAttributesOk(int? charisma = default(int?), int? intelligence = default(int?), int? memory = default(int?), int? perception = default(int?), int? willpower = default(int?), int? bonusRemaps = default(int?), DateTime? lastRemapDate = default(DateTime?), DateTime? accruedRemapCooldownDate = default(DateTime?))
        {
            // to ensure "charisma" is required (not null)
            if (charisma == null)
            {
                throw new InvalidDataException("charisma is a required property for GetCharactersCharacterIdAttributesOk and cannot be null");
            }
            else
            {
                this.Charisma = charisma;
            }
            // to ensure "intelligence" is required (not null)
            if (intelligence == null)
            {
                throw new InvalidDataException("intelligence is a required property for GetCharactersCharacterIdAttributesOk and cannot be null");
            }
            else
            {
                this.Intelligence = intelligence;
            }
            // to ensure "memory" is required (not null)
            if (memory == null)
            {
                throw new InvalidDataException("memory is a required property for GetCharactersCharacterIdAttributesOk and cannot be null");
            }
            else
            {
                this.Memory = memory;
            }
            // to ensure "perception" is required (not null)
            if (perception == null)
            {
                throw new InvalidDataException("perception is a required property for GetCharactersCharacterIdAttributesOk and cannot be null");
            }
            else
            {
                this.Perception = perception;
            }
            // to ensure "willpower" is required (not null)
            if (willpower == null)
            {
                throw new InvalidDataException("willpower is a required property for GetCharactersCharacterIdAttributesOk and cannot be null");
            }
            else
            {
                this.Willpower = willpower;
            }
            this.BonusRemaps = bonusRemaps;
            this.LastRemapDate = lastRemapDate;
            this.AccruedRemapCooldownDate = accruedRemapCooldownDate;
        }
        
        /// <summary>
        /// charisma integer
        /// </summary>
        /// <value>charisma integer</value>
        [DataMember(Name="charisma", EmitDefaultValue=false)]
        public int? Charisma { get; set; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        /// <value>intelligence integer</value>
        [DataMember(Name="intelligence", EmitDefaultValue=false)]
        public int? Intelligence { get; set; }

        /// <summary>
        /// memory integer
        /// </summary>
        /// <value>memory integer</value>
        [DataMember(Name="memory", EmitDefaultValue=false)]
        public int? Memory { get; set; }

        /// <summary>
        /// perception integer
        /// </summary>
        /// <value>perception integer</value>
        [DataMember(Name="perception", EmitDefaultValue=false)]
        public int? Perception { get; set; }

        /// <summary>
        /// willpower integer
        /// </summary>
        /// <value>willpower integer</value>
        [DataMember(Name="willpower", EmitDefaultValue=false)]
        public int? Willpower { get; set; }

        /// <summary>
        /// Number of available bonus character neural remaps
        /// </summary>
        /// <value>Number of available bonus character neural remaps</value>
        [DataMember(Name="bonus_remaps", EmitDefaultValue=false)]
        public int? BonusRemaps { get; set; }

        /// <summary>
        /// Datetime of last neural remap, including usage of bonus remaps
        /// </summary>
        /// <value>Datetime of last neural remap, including usage of bonus remaps</value>
        [DataMember(Name="last_remap_date", EmitDefaultValue=false)]
        public DateTime? LastRemapDate { get; set; }

        /// <summary>
        /// Neural remapping cooldown after a character uses remap accrued over time
        /// </summary>
        /// <value>Neural remapping cooldown after a character uses remap accrued over time</value>
        [DataMember(Name="accrued_remap_cooldown_date", EmitDefaultValue=false)]
        public DateTime? AccruedRemapCooldownDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdAttributesOk {\n");
            sb.Append("  Charisma: ").Append(Charisma).Append("\n");
            sb.Append("  Intelligence: ").Append(Intelligence).Append("\n");
            sb.Append("  Memory: ").Append(Memory).Append("\n");
            sb.Append("  Perception: ").Append(Perception).Append("\n");
            sb.Append("  Willpower: ").Append(Willpower).Append("\n");
            sb.Append("  BonusRemaps: ").Append(BonusRemaps).Append("\n");
            sb.Append("  LastRemapDate: ").Append(LastRemapDate).Append("\n");
            sb.Append("  AccruedRemapCooldownDate: ").Append(AccruedRemapCooldownDate).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdAttributesOk);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdAttributesOk instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdAttributesOk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdAttributesOk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Charisma == input.Charisma ||
                    (this.Charisma != null &&
                    this.Charisma.Equals(input.Charisma))
                ) && 
                (
                    this.Intelligence == input.Intelligence ||
                    (this.Intelligence != null &&
                    this.Intelligence.Equals(input.Intelligence))
                ) && 
                (
                    this.Memory == input.Memory ||
                    (this.Memory != null &&
                    this.Memory.Equals(input.Memory))
                ) && 
                (
                    this.Perception == input.Perception ||
                    (this.Perception != null &&
                    this.Perception.Equals(input.Perception))
                ) && 
                (
                    this.Willpower == input.Willpower ||
                    (this.Willpower != null &&
                    this.Willpower.Equals(input.Willpower))
                ) && 
                (
                    this.BonusRemaps == input.BonusRemaps ||
                    (this.BonusRemaps != null &&
                    this.BonusRemaps.Equals(input.BonusRemaps))
                ) && 
                (
                    this.LastRemapDate == input.LastRemapDate ||
                    (this.LastRemapDate != null &&
                    this.LastRemapDate.Equals(input.LastRemapDate))
                ) && 
                (
                    this.AccruedRemapCooldownDate == input.AccruedRemapCooldownDate ||
                    (this.AccruedRemapCooldownDate != null &&
                    this.AccruedRemapCooldownDate.Equals(input.AccruedRemapCooldownDate))
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
                if (this.Charisma != null)
                    hashCode = hashCode * 59 + this.Charisma.GetHashCode();
                if (this.Intelligence != null)
                    hashCode = hashCode * 59 + this.Intelligence.GetHashCode();
                if (this.Memory != null)
                    hashCode = hashCode * 59 + this.Memory.GetHashCode();
                if (this.Perception != null)
                    hashCode = hashCode * 59 + this.Perception.GetHashCode();
                if (this.Willpower != null)
                    hashCode = hashCode * 59 + this.Willpower.GetHashCode();
                if (this.BonusRemaps != null)
                    hashCode = hashCode * 59 + this.BonusRemaps.GetHashCode();
                if (this.LastRemapDate != null)
                    hashCode = hashCode * 59 + this.LastRemapDate.GetHashCode();
                if (this.AccruedRemapCooldownDate != null)
                    hashCode = hashCode * 59 + this.AccruedRemapCooldownDate.GetHashCode();
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
