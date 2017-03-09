using Sdl.Web.Common.Models;
using Sdl.Web.Modules.Vimeo.Models;
using Sdl.Web.Mvc.Configuration;

namespace Sdl.Web.Modules.Vimeo
{	
    public class VimeoAreaRegistration : BaseAreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Vimeo";
            }
        }

        protected override void RegisterAllViewModels()
        {
            // Entity Views
            RegisterViewModel("VimeoPlayer", typeof(VimeoVideo));
           
        }
    }
}