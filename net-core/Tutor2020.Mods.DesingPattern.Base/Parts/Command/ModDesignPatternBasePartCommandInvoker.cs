//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Command.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Command
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Command". Вызыватель.
    /// </summary>
    public class ModDesignPatternBasePartCommandInvoker
    {
        #region Properties

        private IModDesignPatternBasePartCommandCommonService CommandFirst { get; set; }

        private IModDesignPatternBasePartCommandCommonService CommandSecond { get; set; }

        #endregion Properties

        #region Public methods

        /// <summary>
        /// Вызвать.
        /// </summary>
        public void Invoke()
        {
            CommandFirst?.Execute();
            CommandSecond?.Execute();
        }

        /// <summary>
        /// Установить команду "First".
        /// </summary>
        /// <param name="command">Команда.</param>
        public ModDesignPatternBasePartCommandInvoker SetCommandFirst(IModDesignPatternBasePartCommandCommonService command)
        {
            CommandFirst = command;

            return this;
        }

        /// <summary>
        /// Установить команду "Second".
        /// </summary>
        /// <param name="command">Команда.</param>
        public ModDesignPatternBasePartCommandInvoker SetCommandSecond(IModDesignPatternBasePartCommandCommonService command)
        {
            CommandSecond = command;

            return this;
        }

        #endregion Public methods
    }
}
