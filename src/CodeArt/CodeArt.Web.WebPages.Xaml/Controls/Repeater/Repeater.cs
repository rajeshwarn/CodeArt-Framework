﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CodeArt.Web.WebPages.Xaml.Markup;

namespace CodeArt.Web.WebPages.Xaml.Controls
{
    [TemplateCode("Template", "CodeArt.Web.WebPages.Xaml.Controls.Repeater.Template.html,CodeArt.Web.WebPages.Xaml")]
    [TemplateCode("ItemTemplate", "CodeArt.Web.WebPages.Xaml.Controls.Repeater.ItemTemplate.html,CodeArt.Web.WebPages.Xaml")]
    public class Repeater : ItemsControl
    {
        static Repeater()
        {

        }
    }
}