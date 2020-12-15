using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern
{
    public class CDBuilder
    {
        public CDType BuildSonyCDType()
        {
            CDType cds = new CDType();
            cds.AddItem(new Sony());
            return cds;
        }

        public CDType BuildSamsungCDType()
        {
            CDType cds = new CDType();
            cds.AddItem(new Samsung());
            return cds;
        }
    }
}
