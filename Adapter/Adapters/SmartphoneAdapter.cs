using Adapter.Interfaces;
using Adapter.Products;
namespace Adapter.Adapters
{
    public class SmartphoneAdapter : IProduct
    {
        private readonly Smartphone _smartphone;

        public SmartphoneAdapter(Smartphone smartphone)
        {
            _smartphone = smartphone;
        }
        public string GetDescription()
        {
            return _smartphone.GetDescription();
        }

        public string GetModel()
        {
            return _smartphone.GetModel();
        }

        public double GetPrice()
        {
            return _smartphone.GetPrice();
        }
    }
}
