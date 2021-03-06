﻿using MoviesAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAPI.Services
{
    public interface IConfigurationService
    {
        IDictionary<string, IProvider> ProvidersDictionary { get; }
        string BaseAddress { get; }
        string AccessToken { get; }
    }
}
