//Author Maxim Kuzmin//makc//

using Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Common;

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Iterator.Services
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Iterator". Сервис "First".
    /// </summary>
    public class ModDesignPatternBasePartIteratorServiceFirst : ModDesignPatternBasePartIteratorCommonService
    {
        #region Constructors

        /// <inheritdoc/>
        public ModDesignPatternBasePartIteratorServiceFirst(ModDesignPatternBasePartIteratorCollection collection)
            : base(collection)
        {
        }

        #endregion Constructors

        #region Public methods

        /// <inheritdoc/>
        public sealed override bool MoveNext()
        {
            CurrentIndex++;

            return base.MoveNext();
        }

        /// <inheritdoc/>
        public sealed override void Reset()
        {
            CurrentIndex = -1;
        }

        #endregion Public methods
    }
}
