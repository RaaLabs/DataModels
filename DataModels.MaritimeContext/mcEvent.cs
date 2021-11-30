// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    public class mcEvent
    {
        public EventData EventData { get; set; }
        public Equipment Equipment { get; set; }
        public Asset Asset { get; set; }
        public Reading Reading { get; set; }
        public Source Source { get; set; }
    }
}