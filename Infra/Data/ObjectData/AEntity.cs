using System;
using System.ComponentModel.DataAnnotations;

namespace Nomadwork.Infra.Data.ObjectData
{
    public abstract class AEntity
    {
        [Key]
        public long Id { get; set; }

        public bool Active { get; set; } = true;

        public DateTime LastUpdate { get; set; } = DateTime.Now;
    }
}