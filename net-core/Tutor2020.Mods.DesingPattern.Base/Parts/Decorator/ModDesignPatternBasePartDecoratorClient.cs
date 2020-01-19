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
            var product = new ModDesignPatternBasePartDecoratorProduct();

            var service1 = new ModDesignPatternBasePartDecoratorCommonService(product);
            var service2 = new ModDesignPatternBasePartDecoratorServiceFirst(service1);
            var service3 = new ModDesignPatternBasePartDecoratorServiceSecond(service2);

            var services = new ModDesignPatternBasePartDecoratorCommonService[]
            {
                service1,
                service2,
                service3
            };

            foreach (var service in services)
            {
                UseService(service);
            }
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать сервис.
        /// </summary>
        /// <param name="service">Сервис.</param>
        protected abstract void UseService(ModDesignPatternBasePartDecoratorCommonService service);

        #endregion Protected methods
    }
}
