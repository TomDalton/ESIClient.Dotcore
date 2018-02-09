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
    /// planet object
    /// </summary>
    [DataContract]
    public partial class GetUniverseSystemsSystemIdPlanet :  IEquatable<GetUniverseSystemsSystemIdPlanet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseSystemsSystemIdPlanet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetUniverseSystemsSystemIdPlanet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetUniverseSystemsSystemIdPlanet" /> class.
        /// </summary>
        /// <param name="planetId">planet_id integer (required).</param>
        /// <param name="moons">moons array.</param>
        public GetUniverseSystemsSystemIdPlanet(int? planetId = default(int?), List<int?> moons = default(List<int?>))
        {
            // to ensure "planetId" is required (not null)
            if (planetId == null)
            {
                throw new InvalidDataException("planetId is a required property for GetUniverseSystemsSystemIdPlanet and cannot be null");
            }
            else
            {
                this.PlanetId = planetId;
            }
            this.Moons = moons;
        }
        
        /// <summary>
        /// planet_id integer
        /// </summary>
        /// <value>planet_id integer</value>
        [DataMember(Name="planet_id", EmitDefaultValue=false)]
        public int? PlanetId { get; set; }

        /// <summary>
        /// moons array
        /// </summary>
        /// <value>moons array</value>
        [DataMember(Name="moons", EmitDefaultValue=false)]
        public List<int?> Moons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetUniverseSystemsSystemIdPlanet {\n");
            sb.Append("  PlanetId: ").Append(PlanetId).Append("\n");
            sb.Append("  Moons: ").Append(Moons).Append("\n");
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
            return this.Equals(input as GetUniverseSystemsSystemIdPlanet);
        }

        /// <summary>
        /// Returns true if GetUniverseSystemsSystemIdPlanet instances are equal
        /// </summary>
        /// <param name="input">Instance of GetUniverseSystemsSystemIdPlanet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetUniverseSystemsSystemIdPlanet input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlanetId == input.PlanetId ||
                    (this.PlanetId != null &&
                    this.PlanetId.Equals(input.PlanetId))
                ) && 
                (
                    this.Moons == input.Moons ||
                    this.Moons != null &&
                    this.Moons.SequenceEqual(input.Moons)
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
                if (this.PlanetId != null)
                    hashCode = hashCode * 59 + this.PlanetId.GetHashCode();
                if (this.Moons != null)
                    hashCode = hashCode * 59 + this.Moons.GetHashCode();
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