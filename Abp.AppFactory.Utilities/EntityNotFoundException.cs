using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.AppFactory.Utilities
{
    public class EntityNotFoundException : Exception
    {
        private string field;
        private string value;
        private string entityType;

        public override string Message
        {
            get
            {
                if (field == null && value == null)
                {
                    return $"Entity '{entityType}' not found";
                }
                else if (field == null)
                {
                    return $"Entity '{entityType}' with Id '{value}' not found";
                }
                else
                {
                    return $"Entity '{entityType}' with '{field}' = '{value}' not found";
                }
            }
        }

        public EntityNotFoundException(Type entityType)
        {
            this.entityType = entityType.Name;
        }

        public EntityNotFoundException(Type entityType, long id)
        {
            this.entityType = entityType.Name;
            this.value = id.ToString();
        }

        public EntityNotFoundException(Type entityType, string propertyName, string value)
        {
            this.entityType = entityType.Name;
            this.field = propertyName;
            this.value = value;
        }
    }
}
