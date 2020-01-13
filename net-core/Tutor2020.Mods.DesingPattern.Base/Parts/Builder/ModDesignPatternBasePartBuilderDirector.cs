//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Директор.
    /// </summary>
    public class ModDesignPatternBasePartBuilderDirector
    {
        #region Public methods

        /// <summary>
        /// Построить продукт "First".
        /// </summary>
        /// <param name="service">Сервис.</param>
        public void BuildProductFirst(IModDesignPatternBasePartBuilderCommonService service)
        {
            service.Init();

            service.SetFirstName("FirstName");
        }

        /// <summary>
        /// Построить продукт "Second".
        /// </summary>
        /// <param name="service">Сервис.</param>
        public void BuildProductSecond(IModDesignPatternBasePartBuilderCommonService service)
        {
            service.Init();

            service.SetSecondName("SecondName");
        }

        #endregion Public methods
    }
}
