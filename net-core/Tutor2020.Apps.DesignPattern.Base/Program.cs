//Author Maxim Kuzmin//makc//

using System;
using Tutor2020.Apps.DesignPattern.Base.App.Parts.AbstractFactory;
using Tutor2020.Apps.DesignPattern.Base.App.Parts.FactoryMethod;

namespace Tutor2020.Apps.DesignPattern.Base
{
    /// <summary>
    /// Программа.
    /// </summary>
    class Program
    {
        #region Private methods

        static void Main(string[] args)
        {
            Run("AbstractFactory", new AppPartAbstractFactoryClient().Run);
            Run("FactoryMethod", new AppPartFactoryMethodClient().Run);
        }

        static void Run(string title, Action action)
        {
            Console.WriteLine();
            Console.WriteLine(title);
            Console.WriteLine("----------------");

            action.Invoke();
        }
        
        #endregion Private methods
    }
}
