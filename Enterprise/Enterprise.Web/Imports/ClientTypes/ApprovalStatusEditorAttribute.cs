using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Enterprise
{
    public partial class ApprovalStatusEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Enterprise.ApprovalStatusEditor";

        public ApprovalStatusEditorAttribute()
            : base(Key)
        {
        }
    }
}

