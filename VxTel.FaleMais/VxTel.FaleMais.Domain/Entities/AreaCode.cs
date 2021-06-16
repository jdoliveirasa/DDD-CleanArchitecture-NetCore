using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace VxTel.FaleMais.Domain.Entities
{
    public class AreaCode
    {
        [Key]
        public int Id { get; set; }

        public string Code { get; set; }
        
        public string Description { get; set; }

        [JsonIgnore]
        public virtual ICollection<ExceedingMinute> OriginAreaCodes { get; set; }

        [JsonIgnore]
        public virtual ICollection<ExceedingMinute> DestinyAreaCodes { get; set; }
    }
}