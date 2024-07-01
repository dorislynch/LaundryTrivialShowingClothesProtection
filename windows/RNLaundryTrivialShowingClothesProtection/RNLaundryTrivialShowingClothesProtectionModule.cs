using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Laundry.Trivial.Showing.Clothes.Protection.RNLaundryTrivialShowingClothesProtection
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNLaundryTrivialShowingClothesProtectionModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNLaundryTrivialShowingClothesProtectionModule"/>.
        /// </summary>
        internal RNLaundryTrivialShowingClothesProtectionModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNLaundryTrivialShowingClothesProtection";
            }
        }
    }
}
