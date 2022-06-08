// Copyright (c) RaaLabs. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace RaaLabs.DataModels.MaritimeContext
{
    public class MaritimeContextEvent
    {
        public EventData EventData { get; set; }
        public Asset Asset { get; set; }
        public Source Source { get; set; }
        public Equipment Equipment { get; set; }
        public VesselReading VesselReading { get; set; }
        public Reading Reading { get; set; }
    }
}