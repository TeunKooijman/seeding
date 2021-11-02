using Stubble.Core;
using Stubble.Core.Builders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Templating
{
    public interface IMustacheTemplater
    {
        Task<string> RenderFileAsync<TModel>(string templatePath, TModel model);
        Task<string> RenderTemplateAsync<TModel>(string template, TModel model);
        string RenderTemplate<TModel>(string template, TModel model);
    }

    public class MustacheTemplater : IMustacheTemplater
    {
        public async Task<string> RenderFileAsync<TModel>(string templatePath, TModel model)
        {
            using(StreamReader reader = new StreamReader(templatePath))
            {
                return await RenderTemplateAsync(await reader.ReadToEndAsync(), model);
            }
        }

        public Task<string> RenderTemplateAsync<TModel>(string template, TModel model)
        {
            StubbleVisitorRenderer stubble = new StubbleBuilder().Build();
            return Task.FromResult(stubble.Render(template, model));
        }

        public string RenderTemplate<TModel>(string template, TModel model)
        {
            StubbleVisitorRenderer stubble = new StubbleBuilder().Build();
            return stubble.Render(template, model);
        }
    }
}
