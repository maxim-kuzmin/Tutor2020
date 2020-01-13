//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.First;
using Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory.Types.Second;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.AbstractFactory
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "AbstractFactory". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartAbstractFactoryClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var services = new IModDesignPatternBasePartAbstractFactoryCommonService[]
            {
                new ModDesignPatternBasePartAbstractFactoryTypeFirstService(),
                new ModDesignPatternBasePartAbstractFactoryTypeSecondCreator()
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
        protected abstract void UseService(IModDesignPatternBasePartAbstractFactoryCommonService service);

        #endregion Protected methods
    }
}
