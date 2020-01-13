//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.FactoryMethod.Creators
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "FactoryMethod". Создатель "Second".
    /// </summary>
    public class ModDesignPatternBasePartFactoryMethodCreatorSecond : ModDesignPatternBasePartFactoryMethodCreator
    {
        #region Protected methods

        /// <inheritdoc/>
        protected sealed override IModDesignPatternBasePartFactoryMethodProduct CreateProduct()
        {
            return new ModDesignPatternBasePartFactoryMethodProductSecond();
        }

        #endregion Protected methods        
    }
}
