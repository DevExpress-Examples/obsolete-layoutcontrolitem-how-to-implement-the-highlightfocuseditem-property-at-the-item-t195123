using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraLayout;

namespace dxSample {
    internal class CustomLayoutControl : LayoutControl {
        protected override void CreateILayoutControlImplementor() {
            base.CreateILayoutControlImplementor();
        }
        protected override LayoutControlImplementor CreateILayoutControlImplementorCore() {
            return new CustomLayoutControlImplementor(this);
        }
    }
}
