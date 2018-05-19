using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using DevExpress.Skins;
using DevExpress.Utils.Drawing;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Painting;

namespace dxSample {
    internal class CustomLayoutControlItemSkinPainter : LayoutControlItemSkinPainter {
        protected override void PatchImageIndexCore(DevExpress.XtraLayout.ViewInfo.BaseLayoutItemViewInfo e, SkinElementInfo info, LayoutControlItem controlItem) {
            info.Bounds = GetPaintBounds(e);
            info.ImageIndex = -1;
            if (e.OwnerILayoutControl.OptionsView.DrawItemBorders) {
                info.ImageIndex = 0;
            }
            if (e.State == ObjectState.Hot && (e.OwnerILayoutControl.OptionsView.AllowHotTrack)) {
                info.ImageIndex = 1;
            }
            if (controlItem != null && controlItem.Control != null) {
                bool highlightFocusedItemEx = (controlItem as CustomLayoutControlItem).HighlightFocusedItemEx;
                if ((controlItem.Control.ContainsFocus || IsPopupOpen(controlItem.Control)) && highlightFocusedItemEx) {
                    info.ImageIndex = 2;
                }
                if (!controlItem.Control.Enabled && (highlightFocusedItemEx)) {
                    info.ImageIndex = 3;
                }
            } else {
                if (e.OwnerILayoutControl.EnableCustomizationMode) {
                    info.ImageIndex = 3;
                }
            }
            if (info.ImageIndex > 0 && !(e.OwnerILayoutControl.OptionsView.DrawItemBorders)) {
                Rectangle rect = info.Bounds;
                rect.Inflate(-1, -1);
                info.Bounds = rect;
            }
            PatchImageIndex(info, e);
            if (info.ImageIndex >= 0) {
                ObjectPainter.DrawObject(e.Cache, SkinElementPainter.Default, info);
            }
        }
    }
}
