//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Fasade.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Fasade
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Fasade". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartFasadeClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var service = new ModDesignPatternBasePartFasadeService(
                new ModDesignPatternBasePartFasadeProductFirst(),
                new ModDesignPatternBasePartFasadeProductSecond()
                );

            UseService(service);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать сервис.
        /// </summary>
        /// <param name="service">Сервис.</param>
        protected abstract void UseService(ModDesignPatternBasePartFasadeService service);

        #endregion Protected methods
    }
}
