using System;
using System.Threading.Tasks;

namespace Templating
{
    public interface ITemplate<out TModel>
    {
        TModel Model { get; }
    }

    public class Template<TModel> : ITemplate<TModel>
    {
        public TModel Model { get; }
        
        private IMustacheTemplater Templater { get; }

        public Template(IMustacheTemplater templater, TModel model)
        {
            Templater = templater;
            Model = model;
        }

        public string Render => Templater.RenderTemplate(GetType().Name + ".mustache", Model);
    }
}