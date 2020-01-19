//Author Maxim Kuzmin//makc//

using System.Collections.Concurrent;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Lightweight
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Lightweight". Фабрика.
    /// </summary>
    public class ModDesignPatternBasePartLightweightFactory
    {
        #region Properties

        private ConcurrentDictionary<string, ModDesignPatternBasePartLightweightService> Services { get; } =
            new ConcurrentDictionary<string, ModDesignPatternBasePartLightweightService>();

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Получить сервис.
        /// </summary>
        /// <param name="state">Состояние.</param>
        /// <returns>Сервис.</returns>
        public ModDesignPatternBasePartLightweightService GetService(ModDesignPatternBasePartLightweightState state)
        {            
            return Services.GetOrAdd(state.Name, key => new ModDesignPatternBasePartLightweightService(state));
        }

        #endregion Public methods
    }
}
