//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Products;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Adapter
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Adapter". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartAdapterClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {            
            var services = new IModDesignPatternBasePartAdapterCommonService[]
            {
                new ModDesignPatternBasePartAdapterServiceFirst(new ModDesignPatternBasePartAdapterProductFirst()),
                new ModDesignPatternBasePartAdapterServiceSecond(new ModDesignPatternBasePartAdapterProductSecond())
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
        protected abstract void UseService(IModDesignPatternBasePartAdapterCommonService service);

        #endregion Protected methods
    }
}
