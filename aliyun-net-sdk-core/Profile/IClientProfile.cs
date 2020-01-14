/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;

namespace Aliyun.Acs.Core.Profile
{
    public interface IClientProfile
    {
        string DefaultClientName { get; set; }
        ISigner GetSigner();

        string GetRegionId();

        FormatType GetFormat();

        Credential GetCredential();

        List<Endpoint> GetEndpoints(string product, string regionId, string serviceCode, string endpointType);

        void SetLocationConfig(string regionId, string product, string endpoint);

        void SetCredentialsProvider(AlibabaCloudCredentialsProvider credentialsProvider);

        void AddEndpoint(string endpointName, string regionId, string product, string domain,
            bool isNeverExpire = false);

    }
}
