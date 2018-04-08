﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
    public interface ISettingsService
    {
        AppSettings GetSettings();
        bool Load(AppSettings settings);
        bool Save(AppSettings settings);
    }
}
