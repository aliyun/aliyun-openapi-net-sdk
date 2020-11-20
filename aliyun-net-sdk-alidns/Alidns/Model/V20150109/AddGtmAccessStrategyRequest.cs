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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class AddGtmAccessStrategyRequest : RpcAcsRequest<AddGtmAccessStrategyResponse>
    {
        public AddGtmAccessStrategyRequest()
            : base("Alidns", "2015-01-09", "AddGtmAccessStrategy", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string defaultAddrPoolId;

		private string failoverAddrPoolId;

		private string strategyName;

		private string accessLines;

		private string instanceId;

		private string lang;

		public string DefaultAddrPoolId
		{
			get
			{
				return defaultAddrPoolId;
			}
			set	
			{
				defaultAddrPoolId = value;
				DictionaryUtil.Add(QueryParameters, "DefaultAddrPoolId", value);
			}
		}

		public string FailoverAddrPoolId
		{
			get
			{
				return failoverAddrPoolId;
			}
			set	
			{
				failoverAddrPoolId = value;
				DictionaryUtil.Add(QueryParameters, "FailoverAddrPoolId", value);
			}
		}

		public string StrategyName
		{
			get
			{
				return strategyName;
			}
			set	
			{
				strategyName = value;
				DictionaryUtil.Add(QueryParameters, "StrategyName", value);
			}
		}

		public string AccessLines
		{
			get
			{
				return accessLines;
			}
			set	
			{
				accessLines = value;
				DictionaryUtil.Add(QueryParameters, "AccessLines", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

        public override AddGtmAccessStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddGtmAccessStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
