using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clime.Messages
{
    class NewMeasurementAddedMessage
    {
        public NewMeasurementAddedMessage(Guid? v)
        {
            MeasurementAdded = v;
        }
        public Guid? MeasurementAdded { get; private set; }
    }
}
