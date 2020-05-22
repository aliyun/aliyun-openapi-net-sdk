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
using Aliyun.Acs.fnf;
using Aliyun.Acs.fnf.Transform;
using Aliyun.Acs.fnf.Transform.V20190315;

namespace Aliyun.Acs.fnf.Model.V20190315
{
    public class UpdateScheduleRequest : RpcAcsRequest<UpdateScheduleResponse>
    {
        public UpdateScheduleRequest()
            : base("fnf", "2019-03-15", "UpdateSchedule")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string scheduleName;

		private string cronExpression;

		private string payload;

		private string requestId;

		private bool? enable;

		private string description;

		private string flowName;

		public string ScheduleName
		{
			get
			{
				return scheduleName;
			}
			set	
			{
				scheduleName = value;
				DictionaryUtil.Add(BodyParameters, "ScheduleName", value);
			}
		}

		public string CronExpression
		{
			get
			{
				return cronExpression;
			}
			set	
			{
				cronExpression = value;
				DictionaryUtil.Add(BodyParameters, "CronExpression", value);
			}
		}

		public string Payload
		{
			get
			{
				return payload;
			}
			set	
			{
				payload = value;
				DictionaryUtil.Add(BodyParameters, "Payload", value);
			}
		}

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
				DictionaryUtil.Add(QueryParameters, "RequestId", value);
			}
		}

		public bool? Enable
		{
			get
			{
				return enable;
			}
			set	
			{
				enable = value;
				DictionaryUtil.Add(BodyParameters, "Enable", value.ToString());
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(BodyParameters, "Description", value);
			}
		}

		public string FlowName
		{
			get
			{
				return flowName;
			}
			set	
			{
				flowName = value;
				DictionaryUtil.Add(BodyParameters, "FlowName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override UpdateScheduleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateScheduleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
