using LwsAuthUI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace LwsAuthUI.Models
{
    public class LeeApplicationRoleManager : RoleManager<IdentityRole>
    {
        public LeeApplicationRoleManager(IRoleStore<IdentityRole, string> store) : base(store)
        {
        }
        public static LeeApplicationRoleManager Create(IdentityFactoryOptions<LeeApplicationRoleManager> options, IOwinContext context)
        {
            var roleStore = new RoleStore<IdentityRole>(context.Get<ApplicationDbContext>());
            return new LeeApplicationRoleManager(roleStore);
        }
    }
}