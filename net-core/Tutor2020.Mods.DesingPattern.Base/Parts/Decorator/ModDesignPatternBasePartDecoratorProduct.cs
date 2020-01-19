//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Decorator
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Decorator". Продукт.
    /// </summary>
    public class ModDesignPatternBasePartDecoratorProduct : IModDesignPatternBasePartDecoratorCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        {
            get
            {
                return "Name";
            }
        }

        #endregion Properties
    }
}
