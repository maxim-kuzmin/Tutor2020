//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodServiceFirst : ModDesignPatternBasePartFactoryMethodCommonService
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override IModDesignPatternBasePartFactoryMethodCommonProduct CreateProduct()
        {
            return new ModDesignPatternBasePartFactoryMethodProductFirst();
        }

        #endregion Protected methods        
    }
}
