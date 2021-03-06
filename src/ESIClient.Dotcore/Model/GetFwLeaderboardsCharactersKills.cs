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
    /// Top 100 rankings of pilots by number of kills from yesterday, last week and in total.
    /// </summary>
    [DataContract]
    public partial class GetFwLeaderboardsCharactersKills :  IEquatable<GetFwLeaderboardsCharactersKills>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCharactersKills" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetFwLeaderboardsCharactersKills() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetFwLeaderboardsCharactersKills" /> class.
        /// </summary>
        /// <param name="activeTotal">Top 100 ranking of pilots active in faction warfare by total kills. A pilot is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days. (required).</param>
        /// <param name="lastWeek">Top 100 ranking of pilots by kills in the past week (required).</param>
        /// <param name="yesterday">Top 100 ranking of pilots by kills in the past day (required).</param>
        public GetFwLeaderboardsCharactersKills(List<GetFwLeaderboardsCharactersActiveTotalActiveTotal> activeTotal = default(List<GetFwLeaderboardsCharactersActiveTotalActiveTotal>), List<GetFwLeaderboardsCharactersLastWeekLastWeek> lastWeek = default(List<GetFwLeaderboardsCharactersLastWeekLastWeek>), List<GetFwLeaderboardsCharactersYesterdayYesterday> yesterday = default(List<GetFwLeaderboardsCharactersYesterdayYesterday>))
        {
            // to ensure "activeTotal" is required (not null)
            if (activeTotal == null)
            {
                throw new InvalidDataException("activeTotal is a required property for GetFwLeaderboardsCharactersKills and cannot be null");
            }
            else
            {
                this.ActiveTotal = activeTotal;
            }
            // to ensure "lastWeek" is required (not null)
            if (lastWeek == null)
            {
                throw new InvalidDataException("lastWeek is a required property for GetFwLeaderboardsCharactersKills and cannot be null");
            }
            else
            {
                this.LastWeek = lastWeek;
            }
            // to ensure "yesterday" is required (not null)
            if (yesterday == null)
            {
                throw new InvalidDataException("yesterday is a required property for GetFwLeaderboardsCharactersKills and cannot be null");
            }
            else
            {
                this.Yesterday = yesterday;
            }
        }
        
        /// <summary>
        /// Top 100 ranking of pilots active in faction warfare by total kills. A pilot is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.
        /// </summary>
        /// <value>Top 100 ranking of pilots active in faction warfare by total kills. A pilot is considered \&quot;active\&quot; if they have participated in faction warfare in the past 14 days.</value>
        [DataMember(Name="active_total", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCharactersActiveTotalActiveTotal> ActiveTotal { get; set; }

        /// <summary>
        /// Top 100 ranking of pilots by kills in the past week
        /// </summary>
        /// <value>Top 100 ranking of pilots by kills in the past week</value>
        [DataMember(Name="last_week", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCharactersLastWeekLastWeek> LastWeek { get; set; }

        /// <summary>
        /// Top 100 ranking of pilots by kills in the past day
        /// </summary>
        /// <value>Top 100 ranking of pilots by kills in the past day</value>
        [DataMember(Name="yesterday", EmitDefaultValue=false)]
        public List<GetFwLeaderboardsCharactersYesterdayYesterday> Yesterday { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetFwLeaderboardsCharactersKills {\n");
            sb.Append("  ActiveTotal: ").Append(ActiveTotal).Append("\n");
            sb.Append("  LastWeek: ").Append(LastWeek).Append("\n");
            sb.Append("  Yesterday: ").Append(Yesterday).Append("\n");
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
            return this.Equals(input as GetFwLeaderboardsCharactersKills);
        }

        /// <summary>
        /// Returns true if GetFwLeaderboardsCharactersKills instances are equal
        /// </summary>
        /// <param name="input">Instance of GetFwLeaderboardsCharactersKills to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetFwLeaderboardsCharactersKills input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ActiveTotal == input.ActiveTotal ||
                    this.ActiveTotal != null &&
                    this.ActiveTotal.SequenceEqual(input.ActiveTotal)
                ) && 
                (
                    this.LastWeek == input.LastWeek ||
                    this.LastWeek != null &&
                    this.LastWeek.SequenceEqual(input.LastWeek)
                ) && 
                (
                    this.Yesterday == input.Yesterday ||
                    this.Yesterday != null &&
                    this.Yesterday.SequenceEqual(input.Yesterday)
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
                if (this.ActiveTotal != null)
                    hashCode = hashCode * 59 + this.ActiveTotal.GetHashCode();
                if (this.LastWeek != null)
                    hashCode = hashCode * 59 + this.LastWeek.GetHashCode();
                if (this.Yesterday != null)
                    hashCode = hashCode * 59 + this.Yesterday.GetHashCode();
                return hashCode;
            }
        }
    }

}
