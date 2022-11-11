namespace OrderFlight.Presentations
{
    public interface ISinglePresentation<TModel>
    {
        void Present(TModel model);
    }
}
