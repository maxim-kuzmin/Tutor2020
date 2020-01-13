//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartFactoryMethodClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var services = new ModDesignPatternBasePartFactoryMethodCommonService[]
            {
                new ModDesignPatternBasePartFactoryMethodServiceFirst(),
                new ModDesignPatternBasePartFactoryMethodServiceSecond()
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
        protected abstract void UseService(ModDesignPatternBasePartFactoryMethodCommonService service);

        #endregion Protected methods
    }
}
