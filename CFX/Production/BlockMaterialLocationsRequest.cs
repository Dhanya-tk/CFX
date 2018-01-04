﻿using System;
using System.Collections.Generic;
using System.Text;
using CFX.Structures;

namespace CFX.Production
{
    public class BlockMaterialLocationsRequest : CFXMessage
    {
        public BlockMaterialLocationsRequest()
        {
            Locations = new List<MaterialLocation>();
        }

        public List<MaterialLocation> Locations
        {
            get;
            set;
        }
    }
}
