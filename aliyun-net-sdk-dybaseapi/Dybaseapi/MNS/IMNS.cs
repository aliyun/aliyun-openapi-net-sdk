/*
 * Copyright (C) Alibaba Cloud Computing
 * All rights reserved.
 */

using System;
using Aliyun.Acs.Dybaseapi.MNS.Model;

namespace Aliyun.Acs.Dybaseapi.MNS
{
    /// <summary>
    /// Interface for accessing MNS.
    /// </summary>
    public partial interface IMNS : IDisposable
    {

        #region GetNativeQueue

        /// <summary>
        /// Get a native queue object with the specified queueName.
        /// </summary>
        /// 
        /// <param name="queueName">The name of native queue object to be created</param>
        /// 
        /// <returns>A native queue object</returns>
        Queue GetNativeQueue(string queueName);

        #endregion
    }
}
