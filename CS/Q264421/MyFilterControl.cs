using System;
using System.Drawing;
using System.Reflection;
using DevExpress.XtraEditors;
using DevExpress.Utils.Drawing;
using System.Collections.Generic;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Filtering;

namespace DXSample {
    public class MyFilterControl :FilterControl {
        protected override WinFilterTreeNodeModel CreateModel() {
            return new MyWinFilterTreeNodeModel(this);
        }
    }

    public class MyFilterControlLabelInfo :FilterControlLabelInfo {
        public MyFilterControlLabelInfo(Node node) : base(node) { }

        public override void Paint(ControlGraphicsInfoArgs info) {
            ViewInfo.Calculate(info.Graphics);
            ViewInfo.TopLine = 0;
            for (int i = 0; i < ViewInfo.Count; ++i) {
                FilterLabelInfoTextViewInfo textViewInfo = (FilterLabelInfoTextViewInfo)ViewInfo[i];
                NodeEditableElement nodeElement = textViewInfo.InfoText.Tag as NodeEditableElement;
                ElementType elementType = null == nodeElement ? ElementType.None : nodeElement.ElementType;
                if (elementType == ElementType.Property) {
                    textViewInfo.InfoText.Text = textViewInfo.InfoText.Text.Trim('[', ']');
                }
                ViewInfo.Calculate(info.Graphics);
                ViewInfo[i].Draw(info.Cache, info.ViewInfo.Appearance.GetFont(), ViewInfo[i].InfoText.Color, info.ViewInfo.Appearance.GetStringFormat());
            }
        }
      
    }

    public class MyWinFilterTreeNodeModel :WinFilterTreeNodeModel {
        public MyWinFilterTreeNodeModel(FilterControl control) : base(control) { }

        public override void OnVisualChange(FilterChangedActionInternal action, Node node) {
            if (action == FilterChangedActionInternal.NodeAdded)
                ((Dictionary<Node, FilterControlLabelInfo>)typeof(WinFilterTreeNodeModel).GetField("labels",
                    BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this))[node] =
                    new MyFilterControlLabelInfo(node);
            else if (action == FilterChangedActionInternal.RootNodeReplaced) {
                Dictionary<Node, FilterControlLabelInfo> labels =
                    (Dictionary<Node, FilterControlLabelInfo>)typeof(WinFilterTreeNodeModel).GetField("labels",
                    BindingFlags.Instance | BindingFlags.NonPublic).GetValue(this);
                labels.Clear();
                RecursiveVisitor(RootNode, child => {
                    var info = new MyFilterControlLabelInfo(child);
                    info.Clear();
                    info.CreateLabelInfoTexts();
                    labels[child] = info;
                });
            } else base.OnVisualChange(action, node);
        }
    }
}