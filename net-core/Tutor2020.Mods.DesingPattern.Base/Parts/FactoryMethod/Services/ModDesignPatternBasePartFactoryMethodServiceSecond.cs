//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodServiceSecond : ModDesignPatternBasePartFactoryMethodCommonService
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override IModDesignPatternBasePartFactoryMethodCommonProduct CreateProduct()
        {
            return new ModDesignPatternBasePartFactoryMethodProductSecond();
        }

        #endregion Protected methods        
    }
}
