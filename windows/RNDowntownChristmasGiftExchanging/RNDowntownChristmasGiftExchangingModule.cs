using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Downtown.Christmas.Gift.Exchanging.RNDowntownChristmasGiftExchanging
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNDowntownChristmasGiftExchangingModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNDowntownChristmasGiftExchangingModule"/>.
        /// </summary>
        internal RNDowntownChristmasGiftExchangingModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNDowntownChristmasGiftExchanging";
            }
        }
    }
}
