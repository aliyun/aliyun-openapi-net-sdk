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
    public class UpdateDnsGtmAccessStrategyRequest : RpcAcsRequest<UpdateDnsGtmAccessStrategyResponse>
    {
        public UpdateDnsGtmAccessStrategyRequest()
            : base("Alidns", "2015-01-09", "UpdateDnsGtmAccessStrategy", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string defaultLbaStrategy;

		private string failoverAddrPoolType;

		private string defaultAddrPoolType;

		private int? failoverMaxReturnAddrNum;

		private string failoverLbaStrategy;

		private List<DefaultAddrPool> defaultAddrPools = new List<DefaultAddrPool>(){ };

		private int? failoverMinAvailableAddrNum;

		private int? defaultMaxReturnAddrNum;

		private int? defaultMinAvailableAddrNum;

		private string lang;

		private string lines;

		private string strategyName;

		private string defaultLatencyOptimization;

		private string failoverLatencyOptimization;

		private string strategyId;

		private List<FailoverAddrPool> failoverAddrPools = new List<FailoverAddrPool>(){ };

		public string DefaultLbaStrategy
		{
			get
			{
				return defaultLbaStrategy;
			}
			set	
			{
				defaultLbaStrategy = value;
				DictionaryUtil.Add(QueryParameters, "DefaultLbaStrategy", value);
			}
		}

		public string FailoverAddrPoolType
		{
			get
			{
				return failoverAddrPoolType;
			}
			set	
			{
				failoverAddrPoolType = value;
				DictionaryUtil.Add(QueryParameters, "FailoverAddrPoolType", value);
			}
		}

		public string DefaultAddrPoolType
		{
			get
			{
				return defaultAddrPoolType;
			}
			set	
			{
				defaultAddrPoolType = value;
				DictionaryUtil.Add(QueryParameters, "DefaultAddrPoolType", value);
			}
		}

		public int? FailoverMaxReturnAddrNum
		{
			get
			{
				return failoverMaxReturnAddrNum;
			}
			set	
			{
				failoverMaxReturnAddrNum = value;
				DictionaryUtil.Add(QueryParameters, "FailoverMaxReturnAddrNum", value.ToString());
			}
		}

		public string FailoverLbaStrategy
		{
			get
			{
				return failoverLbaStrategy;
			}
			set	
			{
				failoverLbaStrategy = value;
				DictionaryUtil.Add(QueryParameters, "FailoverLbaStrategy", value);
			}
		}

		public List<DefaultAddrPool> DefaultAddrPools
		{
			get
			{
				return defaultAddrPools;
			}

			set
			{
				defaultAddrPools = value;
				for (int i = 0; i < defaultAddrPools.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DefaultAddrPool." + (i + 1) + ".Id", defaultAddrPools[i].Id);
					DictionaryUtil.Add(QueryParameters,"DefaultAddrPool." + (i + 1) + ".LbaWeight", defaultAddrPools[i].LbaWeight);
				}
			}
		}

		public int? FailoverMinAvailableAddrNum
		{
			get
			{
				return failoverMinAvailableAddrNum;
			}
			set	
			{
				failoverMinAvailableAddrNum = value;
				DictionaryUtil.Add(QueryParameters, "FailoverMinAvailableAddrNum", value.ToString());
			}
		}

		public int? DefaultMaxReturnAddrNum
		{
			get
			{
				return defaultMaxReturnAddrNum;
			}
			set	
			{
				defaultMaxReturnAddrNum = value;
				DictionaryUtil.Add(QueryParameters, "DefaultMaxReturnAddrNum", value.ToString());
			}
		}

		public int? DefaultMinAvailableAddrNum
		{
			get
			{
				return defaultMinAvailableAddrNum;
			}
			set	
			{
				defaultMinAvailableAddrNum = value;
				DictionaryUtil.Add(QueryParameters, "DefaultMinAvailableAddrNum", value.ToString());
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

		public string Lines
		{
			get
			{
				return lines;
			}
			set	
			{
				lines = value;
				DictionaryUtil.Add(QueryParameters, "Lines", value);
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

		public string DefaultLatencyOptimization
		{
			get
			{
				return defaultLatencyOptimization;
			}
			set	
			{
				defaultLatencyOptimization = value;
				DictionaryUtil.Add(QueryParameters, "DefaultLatencyOptimization", value);
			}
		}

		public string FailoverLatencyOptimization
		{
			get
			{
				return failoverLatencyOptimization;
			}
			set	
			{
				failoverLatencyOptimization = value;
				DictionaryUtil.Add(QueryParameters, "FailoverLatencyOptimization", value);
			}
		}

		public string StrategyId
		{
			get
			{
				return strategyId;
			}
			set	
			{
				strategyId = value;
				DictionaryUtil.Add(QueryParameters, "StrategyId", value);
			}
		}

		public List<FailoverAddrPool> FailoverAddrPools
		{
			get
			{
				return failoverAddrPools;
			}

			set
			{
				failoverAddrPools = value;
				for (int i = 0; i < failoverAddrPools.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"FailoverAddrPool." + (i + 1) + ".Id", failoverAddrPools[i].Id);
					DictionaryUtil.Add(QueryParameters,"FailoverAddrPool." + (i + 1) + ".LbaWeight", failoverAddrPools[i].LbaWeight);
				}
			}
		}

		public class DefaultAddrPool
		{

			private string id;

			private int? lbaWeight;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? LbaWeight
			{
				get
				{
					return lbaWeight;
				}
				set	
				{
					lbaWeight = value;
				}
			}
		}

		public class FailoverAddrPool
		{

			private string id;

			private int? lbaWeight;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public int? LbaWeight
			{
				get
				{
					return lbaWeight;
				}
				set	
				{
					lbaWeight = value;
				}
			}
		}

        public override UpdateDnsGtmAccessStrategyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateDnsGtmAccessStrategyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
