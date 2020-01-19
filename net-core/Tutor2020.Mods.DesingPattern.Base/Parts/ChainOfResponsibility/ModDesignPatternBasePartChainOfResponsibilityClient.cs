//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.ChainOfResponsibility
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "ChainOfResponsibility". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartChainOfResponsibilityClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var service = new ModDesignPatternBasePartChainOfResponsibilityCommonService();
            var serviceFirst = new ModDesignPatternBasePartChainOfResponsibilityServiceFirst();
            var serviceSecond = new ModDesignPatternBasePartChainOfResponsibilityServiceSecond();

            service.SetNextService(serviceFirst).SetNextService(serviceSecond);

            var product = new ModDesignPatternBasePartChainOfResponsibilityProduct
            {
                Name = "Name"
            };

            service.HandleProduct(product);

            UseProduct(product);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать продукт.
        /// </summary>
        /// <param name="service">Продукт.</param>
        protected abstract void UseProduct(ModDesignPatternBasePartChainOfResponsibilityProduct product);

        #endregion Protected methods
    }
}
