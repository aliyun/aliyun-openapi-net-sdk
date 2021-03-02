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
    public class UpdateGtmMonitorRequest : RpcAcsRequest<UpdateGtmMonitorResponse>
    {
        public UpdateGtmMonitorRequest()
            : base("Alidns", "2015-01-09", "UpdateGtmMonitor", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string monitorExtendInfo;

		private string monitorConfigId;

		private int? timeout;

		private int? evaluationCount;

		private string protocolType;

		private int? interval;

		private string lang;

		private List<IspCityNode> ispCityNodes = new List<IspCityNode>(){ };

		public string MonitorExtendInfo
		{
			get
			{
				return monitorExtendInfo;
			}
			set	
			{
				monitorExtendInfo = value;
				DictionaryUtil.Add(QueryParameters, "MonitorExtendInfo", value);
			}
		}

		public string MonitorConfigId
		{
			get
			{
				return monitorConfigId;
			}
			set	
			{
				monitorConfigId = value;
				DictionaryUtil.Add(QueryParameters, "MonitorConfigId", value);
			}
		}

		public int? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		public int? EvaluationCount
		{
			get
			{
				return evaluationCount;
			}
			set	
			{
				evaluationCount = value;
				DictionaryUtil.Add(QueryParameters, "EvaluationCount", value.ToString());
			}
		}

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolType", value);
			}
		}

		public int? Interval
		{
			get
			{
				return interval;
			}
			set	
			{
				interval = value;
				DictionaryUtil.Add(QueryParameters, "Interval", value.ToString());
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

		public List<IspCityNode> IspCityNodes
		{
			get
			{
				return ispCityNodes;
			}

			set
			{
				ispCityNodes = value;
				for (int i = 0; i < ispCityNodes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"IspCityNode." + (i + 1) + ".CityCode", ispCityNodes[i].CityCode);
					DictionaryUtil.Add(QueryParameters,"IspCityNode." + (i + 1) + ".IspCode", ispCityNodes[i].IspCode);
				}
			}
		}

		public class IspCityNode
		{

			private string cityCode;

			private string ispCode;

			public string CityCode
			{
				get
				{
					return cityCode;
				}
				set	
				{
					cityCode = value;
				}
			}

			public string IspCode
			{
				get
				{
					return ispCode;
				}
				set	
				{
					ispCode = value;
				}
			}
		}

        public override UpdateGtmMonitorResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateGtmMonitorResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
