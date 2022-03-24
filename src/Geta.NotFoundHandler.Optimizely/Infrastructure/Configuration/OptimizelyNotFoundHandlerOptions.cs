// Copyright (c) Geta Digital. All rights reserved.
// Licensed under Apache-2.0. See the LICENSE file in the project root for more information

using Geta.NotFoundHandler.Core.Redirects;

namespace Geta.NotFoundHandler.Optimizely.Infrastructure.Configuration
{
    public class OptimizelyNotFoundHandlerOptions
    {
        public static int CurrentDbVersion = 1;

        public bool AutomaticRedirectsEnabled { get; set; }
        public RedirectType AutomaticRedirectType { get; set; } = RedirectType.Permanent;
    }
}
