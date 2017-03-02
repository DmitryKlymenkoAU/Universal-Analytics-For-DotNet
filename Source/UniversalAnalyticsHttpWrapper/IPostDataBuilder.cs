﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UniversalAnalyticsHttpWrapper
{
    internal interface IPostDataBuilder
    {
        string BuildPostDataString(string measurementProtocolVersion, IUniversalAnalyticsEvent analyticsEvent);
        IEnumerable<KeyValuePair<string, string>> BuildPostDataCollection(string measurementProtocolVersion, IUniversalAnalyticsEvent analyticsEvent);
    }
}
