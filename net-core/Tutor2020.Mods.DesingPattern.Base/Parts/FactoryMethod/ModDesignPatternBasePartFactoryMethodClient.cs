//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Creators;

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
            var creators = new ModDesignPatternBasePartFactoryMethodCreator[]
            {
                new ModDesignPatternBasePartFactoryMethodCreatorFirst(),
                new ModDesignPatternBasePartFactoryMethodCreatorSecond()
            };

            foreach (var creator in creators)
            {
                UseCreator(creator);
            }
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать создателя.
        /// </summary>
        /// <param name="creator">Создатель.</param>
        protected abstract void UseCreator(ModDesignPatternBasePartFactoryMethodCreator creator);

        #endregion Protected methods
    }
}
