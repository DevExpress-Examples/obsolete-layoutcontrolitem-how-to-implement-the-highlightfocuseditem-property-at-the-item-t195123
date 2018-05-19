using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraLayout.Registrator;

namespace dxSample {
    public class CustomLayoutSkinPaintStyle : LayoutSkinPaintStyle {
        public CustomLayoutSkinPaintStyle(DevExpress.LookAndFeel.ISupportLookAndFeel owner)
            : base(owner) {
        }
        public override DevExpress.XtraLayout.Painting.LayoutControlItemSkinPainter GetControlItemSkinPainter() {
            if (layoutControlItemSkinPainter == null) {
                layoutControlItemSkinPainter = new CustomLayoutControlItemSkinPainter();
            }
            return layoutControlItemSkinPainter;
        }
    }
}
