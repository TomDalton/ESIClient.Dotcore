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
    /// character object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdStatsCharacter :  IEquatable<GetCharactersCharacterIdStatsCharacter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStatsCharacter" /> class.
        /// </summary>
        /// <param name="daysOfActivity">days_of_activity integer.</param>
        /// <param name="minutes">minutes integer.</param>
        /// <param name="sessionsStarted">sessions_started integer.</param>
        public GetCharactersCharacterIdStatsCharacter(long? daysOfActivity = default(long?), long? minutes = default(long?), long? sessionsStarted = default(long?))
        {
            this.DaysOfActivity = daysOfActivity;
            this.Minutes = minutes;
            this.SessionsStarted = sessionsStarted;
        }
        
        /// <summary>
        /// days_of_activity integer
        /// </summary>
        /// <value>days_of_activity integer</value>
        [DataMember(Name="days_of_activity", EmitDefaultValue=false)]
        public long? DaysOfActivity { get; set; }

        /// <summary>
        /// minutes integer
        /// </summary>
        /// <value>minutes integer</value>
        [DataMember(Name="minutes", EmitDefaultValue=false)]
        public long? Minutes { get; set; }

        /// <summary>
        /// sessions_started integer
        /// </summary>
        /// <value>sessions_started integer</value>
        [DataMember(Name="sessions_started", EmitDefaultValue=false)]
        public long? SessionsStarted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStatsCharacter {\n");
            sb.Append("  DaysOfActivity: ").Append(DaysOfActivity).Append("\n");
            sb.Append("  Minutes: ").Append(Minutes).Append("\n");
            sb.Append("  SessionsStarted: ").Append(SessionsStarted).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStatsCharacter);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStatsCharacter instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStatsCharacter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStatsCharacter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DaysOfActivity == input.DaysOfActivity ||
                    (this.DaysOfActivity != null &&
                    this.DaysOfActivity.Equals(input.DaysOfActivity))
                ) && 
                (
                    this.Minutes == input.Minutes ||
                    (this.Minutes != null &&
                    this.Minutes.Equals(input.Minutes))
                ) && 
                (
                    this.SessionsStarted == input.SessionsStarted ||
                    (this.SessionsStarted != null &&
                    this.SessionsStarted.Equals(input.SessionsStarted))
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
                if (this.DaysOfActivity != null)
                    hashCode = hashCode * 59 + this.DaysOfActivity.GetHashCode();
                if (this.Minutes != null)
                    hashCode = hashCode * 59 + this.Minutes.GetHashCode();
                if (this.SessionsStarted != null)
                    hashCode = hashCode * 59 + this.SessionsStarted.GetHashCode();
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
