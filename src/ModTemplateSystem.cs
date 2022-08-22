using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModTemplate.src
{
    using Vintagestory.API.Common;
    using Vintagestory.API.Server;
    using Vintagestory.API.Client;

    class ModTemplateSystem : ModSystem
    {
        public override bool ShouldLoad(EnumAppSide forSide)
        {
            return true;
        }

        public override void Start(ICoreAPI api)
        {
            base.Start(api);
            try
            {
                ModConfig file;
                if ((file = api.LoadModConfig<ModConfig>("ModTemplate.json")) == null)
                {
                    api.StoreModConfig<ModConfig>(ModConfig.instance, "ModTemplate.json");
                }
                else ModConfig.instance = file;
            }
            catch
            {
                api.StoreModConfig<ModConfig>(ModConfig.instance, "ModTemplate.json");
            }

            // Register your items and classes here
            // api.RegisterItemClass("my_super_awesome_sword", typeof(ItemAwesomeSword));
        }
    }
}
