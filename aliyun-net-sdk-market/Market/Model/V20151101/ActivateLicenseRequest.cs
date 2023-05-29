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

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Market;
using Aliyun.Acs.Market.Transform;
using Aliyun.Acs.Market.Transform.V20151101;

namespace Aliyun.Acs.Market.Model.V20151101
{
    public class ActivateLicenseRequest : RpcAcsRequest<ActivateLicenseResponse>
    {
        public ActivateLicenseRequest()
            : base("Market", "2015-11-01", "ActivateLicense")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Market.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string identification;

		private string licenseCode;

		public string Identification
		{
			get
			{
				return identification;
			}
			set	
			{
				identification = value;
				DictionaryUtil.Add(QueryParameters, "Identification", value);
			}
		}

		public string LicenseCode
		{
			get
			{
				return licenseCode;
			}
			set	
			{
				licenseCode = value;
				DictionaryUtil.Add(QueryParameters, "LicenseCode", value);
			}
		}

        public override ActivateLicenseResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ActivateLicenseResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
