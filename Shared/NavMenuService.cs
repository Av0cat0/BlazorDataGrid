namespace UITable3.Client.Shared
{
    public class NavMenuService
    {
        public bool shouldCollapse { get; set; } = false;
        public string getCollapsedStyle()
        {
            return (shouldCollapse) ? "width: 100px" : "width: 200px";
        }
    }
}
