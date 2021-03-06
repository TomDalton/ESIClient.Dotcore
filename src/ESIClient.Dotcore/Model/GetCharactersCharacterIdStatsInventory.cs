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
    /// inventory object
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdStatsInventory :  IEquatable<GetCharactersCharacterIdStatsInventory>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdStatsInventory" /> class.
        /// </summary>
        /// <param name="abandonLootQuantity">abandon_loot_quantity integer.</param>
        /// <param name="trashItemQuantity">trash_item_quantity integer.</param>
        public GetCharactersCharacterIdStatsInventory(long? abandonLootQuantity = default(long?), long? trashItemQuantity = default(long?))
        {
            this.AbandonLootQuantity = abandonLootQuantity;
            this.TrashItemQuantity = trashItemQuantity;
        }
        
        /// <summary>
        /// abandon_loot_quantity integer
        /// </summary>
        /// <value>abandon_loot_quantity integer</value>
        [DataMember(Name="abandon_loot_quantity", EmitDefaultValue=false)]
        public long? AbandonLootQuantity { get; set; }

        /// <summary>
        /// trash_item_quantity integer
        /// </summary>
        /// <value>trash_item_quantity integer</value>
        [DataMember(Name="trash_item_quantity", EmitDefaultValue=false)]
        public long? TrashItemQuantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCharactersCharacterIdStatsInventory {\n");
            sb.Append("  AbandonLootQuantity: ").Append(AbandonLootQuantity).Append("\n");
            sb.Append("  TrashItemQuantity: ").Append(TrashItemQuantity).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdStatsInventory);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdStatsInventory instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdStatsInventory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdStatsInventory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AbandonLootQuantity == input.AbandonLootQuantity ||
                    (this.AbandonLootQuantity != null &&
                    this.AbandonLootQuantity.Equals(input.AbandonLootQuantity))
                ) && 
                (
                    this.TrashItemQuantity == input.TrashItemQuantity ||
                    (this.TrashItemQuantity != null &&
                    this.TrashItemQuantity.Equals(input.TrashItemQuantity))
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
                if (this.AbandonLootQuantity != null)
                    hashCode = hashCode * 59 + this.AbandonLootQuantity.GetHashCode();
                if (this.TrashItemQuantity != null)
                    hashCode = hashCode * 59 + this.TrashItemQuantity.GetHashCode();
                return hashCode;
            }
        }
    }

}
