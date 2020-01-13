//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Common;
using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Products;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Сервис "Second".
    /// </summary>
    public class ModDesignPatternBasePartBuilderServiceSecond : IModDesignPatternBasePartBuilderCommonService
    {
        #region Properties

        public ModDesignPatternBasePartBuilderProductSecond Result { get; private set; }

        #endregion Properties

        #region Public methods

        /// <inheritdoc/>
        public void Init()
        {
            Result = new ModDesignPatternBasePartBuilderProductSecond();
        }

        /// <inheritdoc/>
        public void SetFirstName(string firstName)
        {
        }

        /// <inheritdoc/>
        public void SetSecondName(string secondName)
        {
            Result.SecondName = secondName;
        }

        #endregion Public methods        
    }
}
