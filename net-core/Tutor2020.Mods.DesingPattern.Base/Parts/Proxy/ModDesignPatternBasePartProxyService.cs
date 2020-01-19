//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Proxy.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Proxy
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Proxy". Сервис.
    /// </summary>
    public class ModDesignPatternBasePartProxyService : IModDesignPatternBasePartProxyCommonProduct
    {
        #region Properties

        private ModDesignPatternBasePartProxyProduct Product { get; set; }

        /// <inheritdoc/>
        public string Name
        { 
            get
            {
                return $"Proxy: {Product.Name}";
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartProxyService(ModDesignPatternBasePartProxyProduct product)
        {
            Product = product;
        }

        #endregion Constructors
    }
}
