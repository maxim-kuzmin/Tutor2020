//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Products;
using Tutor2020.Mods.DesingPattern.Base.Parts.Bridge.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Bridge
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Bridge". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartBridgeClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var products = new IModDesignPatternBasePartBridgeCommonProduct[]
            {
                new ModDesignPatternBasePartBridgeProductFirst(),
                new ModDesignPatternBasePartBridgeProductSecond()
            };

            var services = new ModDesignPatternBasePartBridgeCommonService[]
            {
                new ModDesignPatternBasePartBridgeServiceFirst(products[0]),
                new ModDesignPatternBasePartBridgeServiceSecond(products[0]),
                new ModDesignPatternBasePartBridgeServiceFirst(products[1]),
                new ModDesignPatternBasePartBridgeServiceSecond(products[1])
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
        protected abstract void UseService(ModDesignPatternBasePartBridgeCommonService service);

        #endregion Protected methods
    }
}
