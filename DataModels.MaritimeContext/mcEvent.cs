// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    public class mcEvent
    {
        public eventData eventData { get; set; }
        public equipment equipment { get; set; }
        public asset asset { get; set; }
        public reading reading { get; set; }
        public source source { get; set; }
    }
}