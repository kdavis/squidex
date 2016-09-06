﻿// ==========================================================================
//  IModelSchemaProvider.cs
//  PinkParrot Headless CMS
// ==========================================================================
//  Copyright (c) PinkParrot Group
//  All rights reserved.
// ==========================================================================

using System;
using System.Threading.Tasks;

namespace PinkParrot.Read.Services
{
    public interface IModelSchemaProvider
    {
        Task<Guid?> FindSchemaIdByNameAsync(Guid tenantId, string name);
    }
}
