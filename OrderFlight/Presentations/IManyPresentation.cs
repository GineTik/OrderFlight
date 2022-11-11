namespace OrderFlight.Presentations
{
    public interface IManyPresentation<TModel>
    {
        void Present(IEnumerable<TModel> models);
    }
}
