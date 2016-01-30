using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Less_4
{
    public class MyControl : Control
    {
        public string Param1 { get; set; }
        public string Param2 { get; set; }
        public string Param3 { get; set; }

        protected override void Render(HtmlTextWriter writer)
        {
            //// Определение атрибута, содержащего ссылку
            //writer.AddAttribute(HtmlTextWriterAttribute.Href, "http://example.com");
            //// Определение стиля атрибута (размер шрифат)
            //writer.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "30");
            //// Открытие тега <a>
            //writer.RenderBeginTag(HtmlTextWriterTag.A);
            //// Вывод статического содержимого на страницу
            //writer.Write("Web Forms");
            //// Закрытие тега <a>
            //writer.RenderEndTag();

            Param1 = "Груша";
            Param2 = "Яблоко";
            Param3 = "Слива";

            writer.RenderBeginTag(HtmlTextWriterTag.Ol);
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.Write(Param1);
            writer.RenderEndTag();
           

            
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.Write(Param2);
            writer.RenderEndTag();
            

           
            writer.RenderBeginTag(HtmlTextWriterTag.Li);
            writer.Write(Param3);
            writer.RenderEndTag();
            writer.RenderEndTag();
        } 

    }
}