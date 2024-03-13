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
    public class CreateLiveMessageAppRequest : RpcAcsRequest<CreateLiveMessageAppResponse>
    {
        public CreateLiveMessageAppRequest()
            : base("live", "2016-11-01", "CreateLiveMessageApp", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string dataCenter;

		private int? msgLifeCycle;

		private string appName;

		private int? auditType;

		private string auditUrl;

		private string eventCallbackUrl;

		public string DataCenter
		{
			get
			{
				return dataCenter;
			}
			set	
			{
				dataCenter = value;
				DictionaryUtil.Add(QueryParameters, "DataCenter", value);
			}
		}

		public int? MsgLifeCycle
		{
			get
			{
				return msgLifeCycle;
			}
			set	
			{
				msgLifeCycle = value;
				DictionaryUtil.Add(QueryParameters, "MsgLifeCycle", value.ToString());
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public int? AuditType
		{
			get
			{
				return auditType;
			}
			set	
			{
				auditType = value;
				DictionaryUtil.Add(QueryParameters, "AuditType", value.ToString());
			}
		}

		public string AuditUrl
		{
			get
			{
				return auditUrl;
			}
			set	
			{
				auditUrl = value;
				DictionaryUtil.Add(QueryParameters, "AuditUrl", value);
			}
		}

		public string EventCallbackUrl
		{
			get
			{
				return eventCallbackUrl;
			}
			set	
			{
				eventCallbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "EventCallbackUrl", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateLiveMessageAppResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateLiveMessageAppResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
