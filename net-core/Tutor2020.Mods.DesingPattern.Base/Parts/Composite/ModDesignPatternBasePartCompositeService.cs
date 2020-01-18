//Author Maxim Kuzmin//makc//

using System.Collections.Generic;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Composite
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Composite". Сервис.
    /// </summary>
    public class ModDesignPatternBasePartCompositeService
    {
        #region Properties

        private List<ModDesignPatternBasePartCompositeService> Children { get; set; } =
            new List<ModDesignPatternBasePartCompositeService>();

        private ModDesignPatternBasePartCompositeProduct Product { get; set; }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartCompositeService(ModDesignPatternBasePartCompositeProduct product)
        {
            Product = product;
        }

        #endregion Constructors

        #region Public methods

        /// <summary>
        /// Добавить.
        /// </summary>
        /// <param name="service">Сервис.</param>
        public void Add(ModDesignPatternBasePartCompositeService service)
        {
            Children.Add(service);
        }

        /// <summary>
        /// Получить имя продукта.
        /// </summary>
        /// <returns>Имя продукта.</returns>
        public string GetProductName()
        {
            var result = Product.Name;

            foreach (var child in Children)
            {
                result += ", " + child.GetProductName();
            }

            return result;
        }

        /// <summary>
        /// Удалить.
        /// </summary>
        /// <param name="service">Сервис.</param>
        public void Remove(ModDesignPatternBasePartCompositeService service)
        {
            Children.Remove(service);
        }

        #endregion Public methods
    }
}
