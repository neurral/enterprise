
namespace Enterprise.Columns
{
    using Serenity.ComponentModel;
    using Serenity.Data.Mapping;
    using System;

    public class TemplateColumns
    {
        [EditLink, Width(90), OneWay, NotMapped]
        public String LabelAction { get; set; }
    }
}