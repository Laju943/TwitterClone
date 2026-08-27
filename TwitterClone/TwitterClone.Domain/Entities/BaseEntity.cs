using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    public class BaseEntity
    {
        public Guid _id;
        private DateTime _createdAt;
        public DateTime? _modifiedAt { get; private set; }
        public Guid _createdBy { get; private set; }
        public Guid? _modifiedBy { get; private set; }

        public BaseEntity(Guid id)
        {
            _id = id;
        }

        public virtual string DescribeRecord()
        {
            return $"BaseEntity:id:{_id},CreatedAt:{_createdAt},ModifiedAt:{_modifiedAt},CreatedBy:{_createdBy},ModifiedBy:{_modifiedBy}";
        }

    }
}
