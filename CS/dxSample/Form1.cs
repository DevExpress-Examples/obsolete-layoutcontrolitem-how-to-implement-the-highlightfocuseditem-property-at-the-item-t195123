using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraEditors;

namespace dxSample {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            InitLayoutControl();
        }
        private void InitLayoutControl() {
            customLayoutControl1.OptionsView.HighlightFocusedItem = true;
            InitItems();
        }
        private void InitItems() {
            layoutControlGroup1.AddItem("TestItem 0", new TextEdit());
            
            CustomLayoutControlItem item = (CustomLayoutControlItem)layoutControlGroup1.AddItem("TestItem 1 ", new TextEdit());
            item.HighlightFocusedItemEx = false;

            layoutControlGroup1.AddItem("TestItem 2 ", new TextEdit());
        }
    }
}
