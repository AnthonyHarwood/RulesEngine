﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System;
using System.Diagnostics.CodeAnalysis;

namespace RulesEngine.Models
{
    [ExcludeFromCodeCoverage]
    public class ReSettings
    {
        public bool EnableExceptionAsErrorMessage { get; set; } = true;
        public Type[] CustomTypes { get; set; }
    }
}
