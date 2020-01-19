//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Command.Services;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Command
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Command". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartCommandClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var receiver = new ModDesignPatternBasePartCommandReceiver();

            var product = new ModDesignPatternBasePartCommandProduct
            {
                Name = "Name"
            };

            new ModDesignPatternBasePartCommandInvoker().SetCommandFirst(
                new ModDesignPatternBasePartCommandServiceFirst(product)
                ).SetCommandSecond(
                new ModDesignPatternBasePartCommandServiceSecond(product, receiver)
                ).Invoke();

            UseProduct(product);
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать продукт.
        /// </summary>
        /// <param name="service">Продукт.</param>
        protected abstract void UseProduct(ModDesignPatternBasePartCommandProduct product);

        #endregion Protected methods
    }
}
