namespace UITable3.Client.Shared
{
    public class NavMenuService
    {
        public bool shouldCollapse { get; set; } = false;
        public string CollapseWidth { get; set; } = "width: 200px";

        public string getCollapsedStyle()
        {
            return (shouldCollapse) ? "width: 100px" : "width: 200px";
        }

        public void SetCollapse(bool _shouldCollapse)
        {
            shouldCollapse = _shouldCollapse;
            CollapseWidth = (shouldCollapse) ? "width: 100px" : "width: 200px";
        }
    }
}
