﻿using System.Collections.Generic;

namespace BlazorStyled.Internal
{
    public class Theme
    {
        public IDictionary<string, string> Values { get; set; } = new Dictionary<string, string>();
    }
}
