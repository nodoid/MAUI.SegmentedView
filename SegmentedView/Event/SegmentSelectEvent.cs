namespace SegmentedView.Event
{
    [Preserve(AllMembers = true)]
    public class SegmentSelectEventArgs : EventArgs
    {
        public int NewValue { get; set; }
    }
}
