using System;
using System.Collections.Generic;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace $safeprojectname$.CustomAttributes
{
    public class DisplayNameLocalizableAttribute : DisplayNameAttribute
    {
        private PropertyInfo _nameProperty;
        private Type _resourceType;

        public DisplayNameLocalizableAttribute(string key, Type resource) : base(key)
        {
            NameResourceType = resource;
        }

        private Type NameResourceType
        {
            get { return _resourceType; }
            set
            {
                _resourceType = value;
                _nameProperty = _resourceType.GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public).Single(x => x.Name == DisplayName);
            }
        }

        public override string DisplayName
        {
            get
            {
                if (_nameProperty == null)
                {
                    return base.DisplayName;
                }
                return (string)_nameProperty.GetValue(_nameProperty.DeclaringType, null);
            }
        }
    }
}
