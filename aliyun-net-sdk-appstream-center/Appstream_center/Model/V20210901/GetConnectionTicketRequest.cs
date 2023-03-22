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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.appstream_center;
using Aliyun.Acs.appstream_center.Transform;
using Aliyun.Acs.appstream_center.Transform.V20210901;

namespace Aliyun.Acs.appstream_center.Model.V20210901
{
    public class GetConnectionTicketRequest : RpcAcsRequest<GetConnectionTicketResponse>
    {
        public GetConnectionTicketRequest()
            : base("appstream-center", "2021-09-01", "GetConnectionTicket")
        {
			Method = MethodType.POST;
        }

		private string bizRegionId;

		private string appStartParam;

		private string productType;

		private string endUserId;

		private string taskId;

		private string appVersion;

		private List<string> appInstanceGroupIdLists = new List<string>(){ };

		private string appId;

		private string appInstanceId;

		[JsonProperty(PropertyName = "BizRegionId")]
		public string BizRegionId
		{
			get
			{
				return bizRegionId;
			}
			set	
			{
				bizRegionId = value;
				DictionaryUtil.Add(BodyParameters, "BizRegionId", value);
			}
		}

		[JsonProperty(PropertyName = "AppStartParam")]
		public string AppStartParam
		{
			get
			{
				return appStartParam;
			}
			set	
			{
				appStartParam = value;
				DictionaryUtil.Add(BodyParameters, "AppStartParam", value);
			}
		}

		[JsonProperty(PropertyName = "ProductType")]
		public string ProductType
		{
			get
			{
				return productType;
			}
			set	
			{
				productType = value;
				DictionaryUtil.Add(BodyParameters, "ProductType", value);
			}
		}

		[JsonProperty(PropertyName = "EndUserId")]
		public string EndUserId
		{
			get
			{
				return endUserId;
			}
			set	
			{
				endUserId = value;
				DictionaryUtil.Add(BodyParameters, "EndUserId", value);
			}
		}

		[JsonProperty(PropertyName = "TaskId")]
		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "TaskId", value);
			}
		}

		[JsonProperty(PropertyName = "AppVersion")]
		public string AppVersion
		{
			get
			{
				return appVersion;
			}
			set	
			{
				appVersion = value;
				DictionaryUtil.Add(BodyParameters, "AppVersion", value);
			}
		}

		[JsonProperty(PropertyName = "AppInstanceGroupIdList")]
		public List<string> AppInstanceGroupIdLists
		{
			get
			{
				return appInstanceGroupIdLists;
			}

			set
			{
				appInstanceGroupIdLists = value;
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(BodyParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "AppInstanceId")]
		public string AppInstanceId
		{
			get
			{
				return appInstanceId;
			}
			set	
			{
				appInstanceId = value;
				DictionaryUtil.Add(BodyParameters, "AppInstanceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetConnectionTicketResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetConnectionTicketResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
