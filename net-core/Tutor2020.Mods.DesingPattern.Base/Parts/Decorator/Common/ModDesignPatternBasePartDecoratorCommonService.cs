//Author Maxim Kuzmin//makc//

using System.Collections.Generic;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Decorator.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Decorator". Общее. Сервис.
    /// </summary>
    public class ModDesignPatternBasePartDecoratorCommonService : IModDesignPatternBasePartDecoratorCommonProduct
    {
        #region Properties

        private IModDesignPatternBasePartDecoratorCommonProduct Product { get; set; }

        /// <inheritdoc/>
        public virtual string Name
        { 
            get
            {
                return $"Decorator: {Product.Name}";
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartDecoratorCommonService(IModDesignPatternBasePartDecoratorCommonProduct product)
        {
            Product = product;
        }

        #endregion Constructors
    }
}
