//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Command;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Command
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Command". Получатель.
    /// </summary>
    public class ModDesignPatternBasePartCommandReceiver
    {
        #region Public methods

        /// <summary>
        /// Обработать продукт.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public void HandleProduct(ModDesignPatternBasePartCommandProduct product)
        {
            product.Name += ": Receiver";
        }

        #endregion Public methods
    }
}
