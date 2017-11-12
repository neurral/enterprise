using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Enterprise.Organization
{
    public partial class PersonnelStatusEditorAttribute : LookupEditorBaseAttribute
    {
        public const string Key = "Enterprise.Organization.PersonnelStatusEditor";

        public PersonnelStatusEditorAttribute()
            : base(Key)
        {
        }
    }
}

