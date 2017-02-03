﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public interface IMovieServicesFactory
    {
        IWebJetWrapperService GetWebJetWrapperService();
        IConfigurationService GetConfigurationService();
    }
}
