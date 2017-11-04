using Serenity;
using Serenity.ComponentModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace Enterprise
{
    public partial class BSToggleEditorAttribute : CustomEditorAttribute
    {
        public const string Key = "Enterprise.BSToggleEditor";

        public BSToggleEditorAttribute()
            : base(Key)
        {
        }

        public Double Height
        {
            get { return GetOption<Double>("height"); }
            set { SetOption("height", value); }
        }

        public Boolean HideLabel
        {
            get { return GetOption<Boolean>("hideLabel"); }
            set { SetOption("hideLabel", value); }
        }

        public String Off
        {
            get { return GetOption<String>("off"); }
            set { SetOption("off", value); }
        }

        public String Offstyle
        {
            get { return GetOption<String>("offstyle"); }
            set { SetOption("offstyle", value); }
        }

        public String On
        {
            get { return GetOption<String>("on"); }
            set { SetOption("on", value); }
        }

        public String Onstyle
        {
            get { return GetOption<String>("onstyle"); }
            set { SetOption("onstyle", value); }
        }

        public object Size
        {
            get { return GetOption<object>("size"); }
            set { SetOption("size", value); }
        }

        public String Style
        {
            get { return GetOption<String>("style"); }
            set { SetOption("style", value); }
        }

        public Double Width
        {
            get { return GetOption<Double>("width"); }
            set { SetOption("width", value); }
        }
    }
}

