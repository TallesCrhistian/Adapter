using Adapter.Interfaces;
using Adapter.Products;
namespace Adapter.Adapters
{
    public class TabletAdapter : IProduct
    {
        private readonly Tablet  _tablet;

        public TabletAdapter(Tablet tablet)
        {
            _tablet = tablet;
        }
        public string GetDescription()
        {
            return _tablet.GetDescription();
        }

        public string GetModel()
        {
            return _tablet.GetModel();
        }

        public double GetPrice()
        {
            return _tablet.GetPrice();
        }
    }
}
