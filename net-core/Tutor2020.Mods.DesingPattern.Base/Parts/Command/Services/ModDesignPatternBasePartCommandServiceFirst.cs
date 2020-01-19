//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Command.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Command.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Command". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartCommandServiceFirst : IModDesignPatternBasePartCommandCommonService
    {
        #region Properties

        private ModDesignPatternBasePartCommandProduct Product { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartCommandServiceFirst(ModDesignPatternBasePartCommandProduct product)
        {
            Product = product;
        }

        #endregion Constructors

        #region Methods

        /// <inheritdoc/>
        public void Execute()
        {
            Product.Name += ": First";
        }

        #endregion Methods
    }
}
