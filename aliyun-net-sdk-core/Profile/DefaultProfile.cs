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

using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Auth;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Regions;
using Aliyun.Acs.Core.Regions.Endpoints;
using Aliyun.Acs.Core.Regions.Location;

namespace Aliyun.Acs.Core.Profile
{
    public class DefaultProfile : IClientProfile
    {
        private static DefaultProfile _profile;

        private static Credential _credential;
        private readonly EndpointResolve endpointResolve;
        private readonly ICredentialProvider iCredentialProvider;
        private readonly string regionId;
        public FormatType acceptFormat;
        private LocationConfig locationConfig;

        private DefaultProfile()
        {
            endpointResolve = new EndpointResolve();
            locationConfig = new LocationConfig();
        }

        private DefaultProfile(string regionId) : this()
        {
            this.regionId = regionId;
        }

        private DefaultProfile(string region, Credential creden) : this()
        {
            _credential = creden;
            regionId = region;
        }

        private DefaultProfile(string region, ICredentialProvider icredential) : this()
        {
            iCredentialProvider = icredential;
            regionId = region;
        }

        public string DefaultClientName { get; set; }

        public string GetRegionId()
        {
            return regionId;
        }

        public FormatType GetFormat()
        {
            return acceptFormat;
        }

        public Credential GetCredential()
        {
            if (null == _credential && null != iCredentialProvider)
            {
                _credential = iCredentialProvider.Fresh();
            }

            return _credential;
        }

        [Obsolete]
        public ISigner GetSigner()
        {
            return null;
        }

        public void SetLocationConfig(string regionId, string product, string endpoint)
        {
            locationConfig = LocationConfig.createLocationConfig(regionId, product, endpoint);
        }

        public List<Endpoint> GetEndpoints(string product, string regionId, string serviceCode, string endpointType)
        {
            return endpointResolve.Resolve(product, regionId, serviceCode, endpointType, _credential, locationConfig);
        }

        public List<Endpoint> GetEndpoints(string regionId, string product)
        {
            return endpointResolve.GetEndpoints(regionId, product);
        }

        public void AddEndpoint(string endpointName, string regionId, string product, string domain,
            bool isNeverExpire = false)
        {
            EndpointUserConfig.AddEndpoint(product, regionId, domain);
            endpointResolve.AddEndpoint(endpointName, regionId, product, domain, isNeverExpire);
        }

        public void SetCredentialsProvider(AlibabaCloudCredentialsProvider credentialsProvider)
        {
            if (_credential != null)
            {
                return;
            }

            _credential = new CredentialsBackupCompatibilityAdaptor(credentialsProvider);
        }

        public static DefaultProfile GetProfile()
        {
            if (null == _profile)
            {
                _profile = new DefaultProfile();
            }

            return _profile;
        }

        public static DefaultProfile GetProfile(string regionId)
        {
            return new DefaultProfile(regionId);
        }

        public static DefaultProfile GetProfile(string regionId, ICredentialProvider icredential)
        {
            _profile = new DefaultProfile(regionId, icredential);
            return _profile;
        }

        public static DefaultProfile GetProfile(string regionId, string accessKeyId, string secret)
        {
            var credential = new Credential(accessKeyId, secret);
            _profile = new DefaultProfile(regionId, credential);
            return _profile;
        }

        public static void ClearProfile()
        {
            _profile = null;
        }
    }
}
