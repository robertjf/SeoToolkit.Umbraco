﻿using System.Collections.Generic;
using uSeoToolkit.Umbraco.RobotsTxt.Core.Models.Business;

namespace uSeoToolkit.Umbraco.RobotsTxt.Core.Interfaces
{
    public interface IRobotsTxtValidator
    {
        IEnumerable<RobotsTxtValidation> Validate(string content);
    }
}
