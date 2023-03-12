using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EosFauxShell
{
    /// <summary>
    /// Specifies the results for password verification.
    /// taken from: https://github.com/dotnet/aspnetcore/blob/main/src/Identity/Extensions.Core/src/PasswordVerificationResult.cs
    /// </summary>
    public enum PasswordVerificationResult
    {
        /// <summary>
        /// Indicates password verification failed.
        /// </summary>
        Failed = 0,

        /// <summary>
        /// Indicates password verification was successful.
        /// </summary>
        Success = 1,

        /// <summary>
        /// Indicates password verification was successful however the password was encoded using a deprecated algorithm
        /// and should be rehashed and updated.
        /// </summary>
        SuccessRehashNeeded = 2
    }
}
