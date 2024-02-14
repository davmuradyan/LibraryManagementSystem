using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem {
    internal abstract class LibraryAbstracts {
        private int _id;
        internal int id {  get { return _id; } set { _id = value; }}
    }
}
