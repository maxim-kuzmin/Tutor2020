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
            var creators = new IModDesignPatternBasePartAbstractFactoryCommonCreator[]
            {
                new ModDesignPatternBasePartAbstractFactoryTypeFirstCreator(),
                new ModDesignPatternBasePartAbstractFactoryTypeSecondCreator()
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
        protected abstract void UseCreator(IModDesignPatternBasePartAbstractFactoryCommonCreator creator);

        #endregion Protected methods
    }
}
