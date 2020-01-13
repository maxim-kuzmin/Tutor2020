//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartBuilderClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var director = new ModDesignPatternBasePartBuilderDirector();

            var serviceFirst = new ModDesignPatternBasePartBuilderServiceFirst();

            director.BuildProductFirst(serviceFirst);

            UseServiceFirst(serviceFirst);

            var serviceSecond = new ModDesignPatternBasePartBuilderServiceSecond();

            director.BuildProductSecond(serviceSecond);

            UseServiceSecond(serviceSecond);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать сервис "First".
        /// </summary>
        /// <param name="service">Сервис.</param>
        protected abstract void UseServiceFirst(ModDesignPatternBasePartBuilderServiceFirst service);

        /// <summary>
        /// Использовать сервис "Second".
        /// </summary>
        /// <param name="service">Сервис.</param>
        protected abstract void UseServiceSecond(ModDesignPatternBasePartBuilderServiceSecond service);

        #endregion Protected methods
    }
}
