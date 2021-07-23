using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseEntities
    {
        [Key]

        public Guid id { get; set; }

        private DateTime? _creatAt;
        public DateTime? CreatAt
        {
            get { return _creatAt; }
            set { _creatAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime? UpdateAt { get; set; }


    }
}
