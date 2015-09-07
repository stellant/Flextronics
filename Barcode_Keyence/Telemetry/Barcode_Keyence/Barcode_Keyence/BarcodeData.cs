using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Barcode_Keyence
{
    class BarcodeData
    {
        private Byte[] dataBytes;
        public Byte[] DataBytes
        {
                get
                {
                    return dataBytes;
                }
                set
                {
                    dataBytes=value;
                }
        }
        public override string ToString()
        {
            return Encoding.GetEncoding("Shift-JIS").GetString(DataBytes);
        }
    }
}
