//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Prototype". Продукт "First".
    /// </summary>
    public class ModDesignPatternBasePartPrototypeProductFirst : IModDesignPatternBasePartPrototypeCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        {
            get
            {
                return $"First: {FirstName}";
            }
        }

        /// <summary>
        /// Первое имя.
        /// </summary>
        public string FirstName { get; set; }

        #endregion Properties

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ModDesignPatternBasePartPrototypeProductFirst()
            : this(null)
        {
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="source">Источник.</param>
        public ModDesignPatternBasePartPrototypeProductFirst(ModDesignPatternBasePartPrototypeProductFirst source)
        {
            FirstName = source?.FirstName;
        }

        #region Public methods

        /// <inheritdoc/>
        public IModDesignPatternBasePartPrototypeCommonProduct Clone()
        {
            return new ModDesignPatternBasePartPrototypeProductFirst(this);
        }

        #endregion Public methods
    }
}
