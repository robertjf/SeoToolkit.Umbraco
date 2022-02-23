﻿using System.Collections.Generic;
using uSeoToolkit.Umbraco.RobotsTxt.Core.Models.Business;

namespace uSeoToolkit.Umbraco.RobotsTxt.Core.Interfaces
{
    public interface IRobotsTxtService
    {
        string GetContent();
        void SetContent(string content);

        IEnumerable<RobotsTxtValidation> Validate(string content);
    }
}
