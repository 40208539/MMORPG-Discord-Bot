﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMORPGDiscordBot
{
    //Item types
    enum Item
    {
        Wood,
        Ore,
        Gold
    }
    //Item object
    class ItemObject
    {
        public Item item { get; private set; }
        public int amount { get; set; }
    }
}