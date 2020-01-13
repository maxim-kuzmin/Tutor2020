//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartBuilderServiceFirst : IModDesignPatternBasePartBuilderCommonService
    {
        #region Properties

        public ModDesignPatternBasePartBuilderProductFirst Result { get; private set; }

        #endregion Properties

        #region Public methods

        /// <inheritdoc/>
        public void Init()
        {
            Result = new ModDesignPatternBasePartBuilderProductFirst();
        }

        /// <inheritdoc/>
        public void SetFirstName(string firstName)
        {
            Result.FirstName = firstName;
        }

        /// <inheritdoc/>
        public void SetSecondName(string secondName)
        {
        }

        #endregion Public methods        
    }
}
