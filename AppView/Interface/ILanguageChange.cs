using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppView.Interface
{
    /// <summary>
    /// Interface Language
    /// </summary>
    public interface ILanguageChange
    {
        /// <summary>
        /// language changed
        /// </summary>
        /// <param name="currentCulture">Current Culture</param>
        void LanguageChanged(string currentCulture);
    }
}
