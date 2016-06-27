using ebay.Enums;
using ebay.Utilities;
using ebay.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ebay.ViewModelBuilders
{
    public class TemplateViewModelBuilder : ViewModelBuilder<Template>
    {
        public override Template Build(string productName)
        {
            var template = new Template();
            template.NameKey = productName;
            template.Title = FileReaderService.GetTextFromFile(productName, TemplateSections.Title);
            template.Part1 = FileReaderService.GetTextFromFile(productName, TemplateSections.Part1);
            template.DividerText1 = FileReaderService.GetTextFromFile(productName, TemplateSections.Divider);
            template.Part2 = FileReaderService.GetTextFromFile(productName, TemplateSections.Part2);
            template.Images = FileReaderService.GetImages(productName).ToList();
            return template;
        }
    }
}