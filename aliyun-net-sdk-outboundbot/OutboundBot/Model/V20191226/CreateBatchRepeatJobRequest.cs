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
using Aliyun.Acs.OutboundBot.Transform;
using Aliyun.Acs.OutboundBot.Transform.V20191226;

namespace Aliyun.Acs.OutboundBot.Model.V20191226
{
    public class CreateBatchRepeatJobRequest : RpcAcsRequest<CreateBatchRepeatJobResponse>
    {
        public CreateBatchRepeatJobRequest()
            : base("OutboundBot", "2019-12-26", "CreateBatchRepeatJob", "outboundbot", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.OutboundBot.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string description;

		private string scriptId;

		private List<string> callingNumbers = new List<string>(){ };

		private string instanceId;

		private string filterStatus;

		private string strategyJson;

		private string name;

		private string sourceGroupId;

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ScriptId
		{
			get
			{
				return scriptId;
			}
			set	
			{
				scriptId = value;
				DictionaryUtil.Add(QueryParameters, "ScriptId", value);
			}
		}

		public List<string> CallingNumbers
		{
			get
			{
				return callingNumbers;
			}

			set
			{
				callingNumbers = value;
				for (int i = 0; i < callingNumbers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"CallingNumber." + (i + 1) , callingNumbers[i]);
				}
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

		public string FilterStatus
		{
			get
			{
				return filterStatus;
			}
			set	
			{
				filterStatus = value;
				DictionaryUtil.Add(QueryParameters, "FilterStatus", value);
			}
		}

		public string StrategyJson
		{
			get
			{
				return strategyJson;
			}
			set	
			{
				strategyJson = value;
				DictionaryUtil.Add(QueryParameters, "StrategyJson", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string SourceGroupId
		{
			get
			{
				return sourceGroupId;
			}
			set	
			{
				sourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "SourceGroupId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateBatchRepeatJobResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateBatchRepeatJobResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
