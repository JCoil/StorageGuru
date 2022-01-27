﻿using Planetbase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ImprovedComponents
{
    public class TechGmRice : Tech
    {
        // Token: 0x06000BA2 RID: 2978 RVA: 0x000412E6 File Offset: 0x0003F4E6
        public TechGmRice()
        {
            load();
            this.mMerchantCategory = MerchantCategory.Food;
            this.mValue = 600;
        }

        public new void load()
        {
            this.initStrings();
            this.mIcon = ResourceUtil.loadIconColor("Components/icon_" + NamingUtils.RicePadTypeName, Color.cyan); 
        }

        public static void RegisterStrings()
        {
            StringList.mStrings.Add("tech_gm_rice", "GM Rice DNA");
            StringList.mStrings.Add("tech_gm_rice_description", "Allows you to grow high-yield GM Rice");
        }
    }
}
