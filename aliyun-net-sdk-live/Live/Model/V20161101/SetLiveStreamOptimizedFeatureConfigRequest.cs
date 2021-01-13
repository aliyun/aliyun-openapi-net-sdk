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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class SetLiveStreamOptimizedFeatureConfigRequest : RpcAcsRequest<SetLiveStreamOptimizedFeatureConfigResponse>
    {
        public SetLiveStreamOptimizedFeatureConfigRequest()
            : base("live", "2016-11-01", "SetLiveStreamOptimizedFeatureConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string configStatus;

		private string configName;

		private string domainName;

		private string configValue;

		private long? ownerId;

		public string ConfigStatus
		{
			get
			{
				return configStatus;
			}
			set	
			{
				configStatus = value;
				DictionaryUtil.Add(QueryParameters, "ConfigStatus", value);
			}
		}

		public string ConfigName
		{
			get
			{
				return configName;
			}
			set	
			{
				configName = value;
				DictionaryUtil.Add(QueryParameters, "ConfigName", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string ConfigValue
		{
			get
			{
				return configValue;
			}
			set	
			{
				configValue = value;
				DictionaryUtil.Add(QueryParameters, "ConfigValue", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

        public override SetLiveStreamOptimizedFeatureConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetLiveStreamOptimizedFeatureConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
