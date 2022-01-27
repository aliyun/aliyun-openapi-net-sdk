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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20180601;

namespace Aliyun.Acs.dataworks_public.Model.V20180601
{
    public class SendTaskMetaCallbackRequest : RpcAcsRequest<SendTaskMetaCallbackResponse>
    {
        public SendTaskMetaCallbackRequest()
            : base("dataworks-public", "2018-06-01", "SendTaskMetaCallback")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string code;

		private long? endTime;

		private List<string> resourcess = new List<string>(){ };

		private long? startTime;

		private string type;

		private string connectionInfo;

		private string taskEnvParam;

		private string subType;

		private long? tenantId;

		private string user;

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
				DictionaryUtil.Add(BodyParameters, "Code", value);
			}
		}

		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(BodyParameters, "EndTime", value.ToString());
			}
		}

		public List<string> Resourcess
		{
			get
			{
				return resourcess;
			}

			set
			{
				resourcess = value;
				for (int i = 0; i < resourcess.Count; i++)
				{
					DictionaryUtil.Add(BodyParameters,"Resources." + (i + 1) , resourcess[i]);
				}
			}
		}

		public long? StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(BodyParameters, "StartTime", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public string ConnectionInfo
		{
			get
			{
				return connectionInfo;
			}
			set	
			{
				connectionInfo = value;
				DictionaryUtil.Add(BodyParameters, "ConnectionInfo", value);
			}
		}

		public string TaskEnvParam
		{
			get
			{
				return taskEnvParam;
			}
			set	
			{
				taskEnvParam = value;
				DictionaryUtil.Add(BodyParameters, "TaskEnvParam", value);
			}
		}

		public string SubType
		{
			get
			{
				return subType;
			}
			set	
			{
				subType = value;
				DictionaryUtil.Add(BodyParameters, "SubType", value);
			}
		}

		public long? TenantId
		{
			get
			{
				return tenantId;
			}
			set	
			{
				tenantId = value;
				DictionaryUtil.Add(BodyParameters, "TenantId", value.ToString());
			}
		}

		public string User
		{
			get
			{
				return user;
			}
			set	
			{
				user = value;
				DictionaryUtil.Add(BodyParameters, "User", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SendTaskMetaCallbackResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendTaskMetaCallbackResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
