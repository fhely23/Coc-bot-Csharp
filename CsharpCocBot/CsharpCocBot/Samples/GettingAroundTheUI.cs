﻿namespace CoC.Bot.Samples
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using ViewModels;

    internal static class GettingAroundTheUI
    {
        /// <summary>
        /// Uses the values in UI.
        /// </summary>
        /// <param name="vm">The MainViewModel.</param>
        internal static void UseValuesInUI(MainViewModel vm)
        {
            vm.Output = "Starting: Getting Around the UI Sample...";

            vm.Output = string.Format("Attack Weak Base Settings: Attack their King is {0}", vm.IsAttackTheirKing);

            if (vm.IsAttackTheirKing)
                vm.Output = "I'm sorry but we don't want you to attack their King";

            vm.IsAttackTheirKing = false; // I don't think we should change an User's value in the UI, but we can

            vm.Output = string.Format("Attack Weak Base Settings: Attack their King is {0}", vm.IsAttackTheirKing);

            vm.Output = "Ending: Getting Around the UI Sample...";
        }
    }
}