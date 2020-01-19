//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Proxy.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Proxy
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Proxy". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartProxyClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var product0 = new ModDesignPatternBasePartProxyProduct
            {
                Name = "Name0"
            };

            var service0 = new ModDesignPatternBasePartProxyService(product0);

            var product1 = new ModDesignPatternBasePartProxyProduct
            {
                Name = "Name1"
            };

            var service1 = new ModDesignPatternBasePartProxyService(product1);

            var products = new IModDesignPatternBasePartProxyCommonProduct[]
            {
                product0,
                service0,
                product1,
                service1
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
        protected abstract void UseProduct(IModDesignPatternBasePartProxyCommonProduct product);

        #endregion Protected methods
    }
}
