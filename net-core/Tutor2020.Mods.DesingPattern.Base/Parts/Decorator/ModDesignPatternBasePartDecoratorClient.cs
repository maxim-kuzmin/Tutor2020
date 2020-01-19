//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Decorator
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Decorator". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartDecoratorClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var product0 = new ModDesignPatternBasePartDecoratorProduct
            {
                Name = "Name0"
            };

            var product1 = new ModDesignPatternBasePartDecoratorProduct
            {
                Name = "Name1"
            };

            var service0 = new ModDesignPatternBasePartDecoratorCommonService(product0);
            var service0First = new ModDesignPatternBasePartDecoratorServiceFirst(service0);
            var service0FirstSecond = new ModDesignPatternBasePartDecoratorServiceSecond(service0First);

            var service1 = new ModDesignPatternBasePartDecoratorCommonService(product1);
            var service1First = new ModDesignPatternBasePartDecoratorServiceFirst(service1);
            var service1FirstSecond = new ModDesignPatternBasePartDecoratorServiceSecond(service1First);

            var products = new IModDesignPatternBasePartDecoratorCommonProduct[]
            {
                product0,
                product1,
                service0,
                service0First,
                service0FirstSecond,
                service1,
                service1First,
                service1FirstSecond
            };

            foreach (var product in products)
            {
                UseProduct(product);
            }
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать продукт.
        /// </summary>
        /// <param name="service">Продукт.</param>
        protected abstract void UseProduct(IModDesignPatternBasePartDecoratorCommonProduct product);

        #endregion Protected methods
    }
}
