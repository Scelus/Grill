using System;
using System.Collections;

class MeatloafRepository: Repository<Meatloaf> {
     override public int MaxProductQuantity {
         get { return 20; }
     }
}