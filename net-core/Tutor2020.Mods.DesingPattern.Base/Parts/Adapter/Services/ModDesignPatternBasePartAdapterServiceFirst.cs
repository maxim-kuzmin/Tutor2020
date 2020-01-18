//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Adapter". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartAdapterServiceFirst : IModDesignPatternBasePartAdapterCommonService
    {
        #region Properties

        private ModDesignPatternBasePartAdapterProductFirst Product { get; set; }

        /// <inheritdoc/>
        public string Name 
        { 
            get
            {
                return Product.FirstName;
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartAdapterServiceFirst(ModDesignPatternBasePartAdapterProductFirst product)
        {
            Product = product;
        }

        #endregion Constructors
    }
}
