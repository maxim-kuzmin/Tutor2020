//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Decorator". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartDecoratorServiceFirst : ModDesignPatternBasePartDecoratorCommonService
    {
        #region Properties

        /// <inheritdoc/>
        public sealed override string Name 
        { 
            get
            {
                return $"First {base.Name}";
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartDecoratorServiceFirst(IModDesignPatternBasePartDecoratorCommonProduct product)
            : base(product)
        {
        }

        #endregion Constructors
    }
}
