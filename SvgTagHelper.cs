using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace WebApplication1.TagHelpers
{
    public class IconTagHelper : TagHelper
    {
        public string Src { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!String.IsNullOrEmpty(Src))
            {
                output.TagName = "span";
                output.AddClass("icon", HtmlEncoder.Default);
                string file = File.ReadAllText($"wwwroot/lib/bootstrap-icons-1.0.0-alpha4/{this.Src}.svg");
                output.Content.SetHtmlContent(file);
            }
        }
    }

    public class IconLinkTagHelper : TagHelper
    {
        public string Src { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            if (!String.IsNullOrEmpty(Src))
            {
                output.TagName = "a";
                output.AddClass("icon-link", HtmlEncoder.Default);
                string file = File.ReadAllText($"wwwroot/lib/bootstrap-icons-1.0.0-alpha4/{this.Src}.svg");
                output.Content.SetHtmlContent(file);
            }
        }
    }
}
