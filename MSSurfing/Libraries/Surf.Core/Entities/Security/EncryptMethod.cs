using System;
using System.Collections.Generic;
using System.Text;

namespace Surf.Core.Entities.Security
{
    public enum EncryptMethod
    {
        None = 0,
        TripleDES = 5,
        Hash = 10,
    }
}
