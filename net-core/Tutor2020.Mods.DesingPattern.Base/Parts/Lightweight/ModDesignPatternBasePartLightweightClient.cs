//Author Maxim Kuzmin//makc//

namespace Tutor2020.Mods.DesingPattern.Base.Parts.Lightweight
{
    /// <summary>
    /// Мод "DesingPattern". Основа. Часть "Lightweight". Клиент.
    /// </summary>
    public abstract class ModDesignPatternBasePartLightweightClient
    {
        #region Public methods

        /// <summary>
        /// Запустить.
        /// </summary>
        public void Run()
        {
            var factory = new ModDesignPatternBasePartLightweightFactory();

            var states = new ModDesignPatternBasePartLightweightState[]
            {
                new ModDesignPatternBasePartLightweightState
                {
                    Name = "State1"
                },
                new ModDesignPatternBasePartLightweightState
                {
                    Name = "State2"
                }
            };

            var products = new ModDesignPatternBasePartLightweightProduct[]
            {
                new ModDesignPatternBasePartLightweightProduct
                {
                    Name = "Product1"
                },
                new ModDesignPatternBasePartLightweightProduct
                {
                    Name = "Product2"
                }
            };

            var contexts = new ModDesignPatternBasePartLightweightContext[]
            {
                new ModDesignPatternBasePartLightweightContext(factory, states[0], products[0]),
                new ModDesignPatternBasePartLightweightContext(factory, states[1], products[0]),
                new ModDesignPatternBasePartLightweightContext(factory, states[0], products[1]),
                new ModDesignPatternBasePartLightweightContext(factory, states[1], products[0])
            };

            foreach (var context in contexts)
            {
                UseContext(context);
            }            
        }

        #endregion Public methods

        #region Protected methods

        /// <summary>
        /// Использовать контекст.
        /// </summary>
        /// <param name="context">Контекст.</param>
        protected abstract void UseContext(ModDesignPatternBasePartLightweightContext context);

        #endregion Protected methods
    }
}
