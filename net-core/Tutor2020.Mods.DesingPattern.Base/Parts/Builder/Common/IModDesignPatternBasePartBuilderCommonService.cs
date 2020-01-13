//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Builder.Common
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Builder". Общее. Сервис. Интерфейс.
    /// </summary>
    public interface IModDesignPatternBasePartBuilderCommonService
    {
        #region Methods

        /// <summary>
        /// Инициализировать.
        /// </summary>
        void Init();

        /// <summary>
        /// Задать первое имя.
        /// </summary>
        /// <param name="firstName">Первое имя.</param>
        void SetFirstName(string firstName);

        /// <summary>
        /// Задать второе имя.
        /// </summary>
        /// <param name="secondName">Второе имя.</param>
        void SetSecondName(string secondName);

        #endregion Methods
    }
}
