﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeArt.AppSetting;
using CodeArt.Web.WebPages.Xaml;
using CodeArt.Web.WebPages.Xaml.Markup;
using CodeArt.Concurrent;

namespace CodeArt.Web.XamlControls.Metronic
{
    public class DatetimeRuleCodeConverter : RuleCodeConverter
    {

        protected override void FillRulesCode(object d, StringBuilder code)
        {
            var tb = d as Datetime;
            if (tb.Required) code.Append("required:true,");
        }

        protected override void FillMessagesCode(object d, StringBuilder code)
        {
            var tb = d as Datetime;
            var label = tb.Label;
            if (tb.Required) code.AppendFormat("required:'{0}',", string.Format(Strings.FieldRequired, label));
        }

        public readonly static DatetimeRuleCodeConverter Instance = new DatetimeRuleCodeConverter();
    }
}