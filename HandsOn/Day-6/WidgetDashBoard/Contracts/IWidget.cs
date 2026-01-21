namespace WidgetDashBoard.Contracts
{
    public interface IWidget
    {
        string Title { get; }
        void Refresh();
    }
    //Prevent tight coupling
    //enables multiple widget types
}
