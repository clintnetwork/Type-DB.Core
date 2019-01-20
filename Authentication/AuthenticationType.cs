﻿namespace TypeDB
{
    /// <summary>
    /// The AuthenticationType defines the way to access to the TypeDB Instance
    /// </summary>
    public enum AuthenticationType
    {
        /// <summary>
        /// It's the default Authentication Type
        /// </summary>
        Anonymous,

        /// <summary>
        /// This is the standard way to have a login with user:pass
        /// </summary>
        Basic,

        /// <summary>
        /// A Token Authentication Type
        /// </summary>
        Token
    }
}