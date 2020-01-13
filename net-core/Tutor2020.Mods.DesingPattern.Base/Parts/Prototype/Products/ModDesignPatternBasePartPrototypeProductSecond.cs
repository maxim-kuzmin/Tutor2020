//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Prototype.Products
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Prototype". Продукт "Second".
    /// </summary>
    public class ModDesignPatternBasePartPrototypeProductSecond : IModDesignPatternBasePartPrototypeCommonProduct
    {
        #region Properties

        /// <inheritdoc/>
        public string Name
        {
            get
            {
                return $"Second: {SecondName}";
            }
        }

        /// <summary>
        /// Второе имя.
        /// </summary>
        public string SecondName { get; set; }

        #endregion Properties

        /// <summary>
        /// Конструктор.
        /// </summary>
        public ModDesignPatternBasePartPrototypeProductSecond()
            : this(null)
        {
        }

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="source">Источник.</param>
        public ModDesignPatternBasePartPrototypeProductSecond(ModDesignPatternBasePartPrototypeProductSecond source)
        {
            SecondName = source?.SecondName;
        }

        #region Public methods

        /// <inheritdoc/>
        public IModDesignPatternBasePartPrototypeCommonProduct Clone()
        {
            return new ModDesignPatternBasePartPrototypeProductSecond(this);
        }

        #endregion Public methods
    }
}
