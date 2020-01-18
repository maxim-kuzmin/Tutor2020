//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Adapter.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Adapter". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartAdapterServiceSecond : IModDesignPatternBasePartAdapterCommonService
    {
        #region Properties

        private ModDesignPatternBasePartAdapterProductSecond Product { get; set; }

        /// <inheritdoc/>
        public string Name 
        { 
            get
            {
                return Product.SecondName;
            }
        }

        #endregion Properties

        #region Constructors

        /// <summary>
        /// Конструктор.
        /// </summary>
        /// <param name="product">Продукт.</param>
        public ModDesignPatternBasePartAdapterServiceSecond(ModDesignPatternBasePartAdapterProductSecond product)
        {
            Product = product;
        }

        #endregion Constructors
    }
}
