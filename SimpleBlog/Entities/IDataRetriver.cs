using SimpleBlog.ViewModels;

namespace SimpleBlog.Entities
{
    public interface IDataRetriver
    {
        HomePageViewModel Retrive();
    }
}