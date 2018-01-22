[assembly: Xamarin.Forms.ExportRenderer(typeof(DLToolkit.Forms.Controls.FlowListViewInternalCell), typeof(DLToolkitControlsSamples.Mac.Renderers.FlowListViewCellRenderer))]
namespace DLToolkitControlsSamples.Mac.Renderers
{
    using AppKit;

    using Xamarin.Forms;

    public class FlowListViewCellRenderer : Xamarin.Forms.Platform.MacOS.ViewCellRenderer
    {
        public override NSView GetCell(Cell item, NSView reusableView, NSTableView tv)
        {
            var cell = base.GetCell(item, reusableView, tv);
            // TODO [macOS] Implement: cell.SelectionStyle = AppKit.UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}