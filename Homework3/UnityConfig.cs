using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3 {
    public static class UnityConfig {
        public static IUnityContainer RegisterInstances() {
            IUnityContainer container = new UnityContainer();

            container.RegisterType<IPreferenceProvider,
                PreferencesDialogPreferenceProvider>();

            return container;
        }
    }
}
