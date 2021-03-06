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
    /// Optional object that is returned if a bookmark was made on a particular item.
    /// </summary>
    [DataContract]
    public partial class GetCharactersCharacterIdBookmarksItem :  IEquatable<GetCharactersCharacterIdBookmarksItem>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarksItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetCharactersCharacterIdBookmarksItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCharactersCharacterIdBookmarksItem" /> class.
        /// </summary>
        /// <param name="itemId">item_id integer (required).</param>
        /// <param name="typeId">type_id integer (required).</param>
        public GetCharactersCharacterIdBookmarksItem(long? itemId = default(long?), int? typeId = default(int?))
        {
            // to ensure "itemId" is required (not null)
            if (itemId == null)
            {
                throw new InvalidDataException("itemId is a required property for GetCharactersCharacterIdBookmarksItem and cannot be null");
            }
            else
            {
                this.ItemId = itemId;
            }
            // to ensure "typeId" is required (not null)
            if (typeId == null)
            {
                throw new InvalidDataException("typeId is a required property for GetCharactersCharacterIdBookmarksItem and cannot be null");
            }
            else
            {
                this.TypeId = typeId;
            }
        }
        
        /// <summary>
        /// item_id integer
        /// </summary>
        /// <value>item_id integer</value>
        [DataMember(Name="item_id", EmitDefaultValue=false)]
        public long? ItemId { get; set; }

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
            sb.Append("class GetCharactersCharacterIdBookmarksItem {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
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
            return this.Equals(input as GetCharactersCharacterIdBookmarksItem);
        }

        /// <summary>
        /// Returns true if GetCharactersCharacterIdBookmarksItem instances are equal
        /// </summary>
        /// <param name="input">Instance of GetCharactersCharacterIdBookmarksItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCharactersCharacterIdBookmarksItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
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
                if (this.ItemId != null)
                    hashCode = hashCode * 59 + this.ItemId.GetHashCode();
                if (this.TypeId != null)
                    hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                return hashCode;
            }
        }
    }

}
