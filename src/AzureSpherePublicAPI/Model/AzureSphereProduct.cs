﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureSpherePublicAPI
{
    public class AzureSphereProduct
    {
        public string Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }

        internal AzureSphereProduct(JToken json)
        {
            Id = json.Value<string>("Id");
            Name = json.Value<string>("Name");
            Description = json.Value<string>("Description");
        }

    }
}
