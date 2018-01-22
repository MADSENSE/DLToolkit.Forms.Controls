[assembly: Xamarin.Forms.Platform.UWP.ExportRenderer(typeof(DLToolkit.Forms.Controls.FlowListView), typeof(DLToolkitControlsSamples.UWP.Renderers.FlowListViewCellRenderer))]
namespace DLToolkitControlsSamples.UWP.Renderers
{
    using Xamarin.Forms.Platform.UWP;

    public class FlowListViewCellRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);

            if (List != null)
            {
                List.SelectionMode = Windows.UI.Xaml.Controls.ListViewSelectionMode.None;
                List.IsItemClickEnabled = false;
            }
        }
    }
}