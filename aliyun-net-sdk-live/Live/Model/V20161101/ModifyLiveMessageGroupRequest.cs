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
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class ModifyLiveMessageGroupRequest : RpcAcsRequest<ModifyLiveMessageGroupResponse>
    {
        public ModifyLiveMessageGroupRequest()
            : base("live", "2016-11-01", "ModifyLiveMessageGroup", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string groupId;

		private string groupInfo;

		private string dataCenter;

		private bool? modifyInfo;

		private List<string> adminList = new List<string>(){ };

		private string appId;

		private bool? modifyAdmin;

		[JsonProperty(PropertyName = "GroupId")]
		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		[JsonProperty(PropertyName = "GroupInfo")]
		public string GroupInfo
		{
			get
			{
				return groupInfo;
			}
			set	
			{
				groupInfo = value;
				DictionaryUtil.Add(QueryParameters, "GroupInfo", value);
			}
		}

		[JsonProperty(PropertyName = "DataCenter")]
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

		[JsonProperty(PropertyName = "ModifyInfo")]
		public bool? ModifyInfo
		{
			get
			{
				return modifyInfo;
			}
			set	
			{
				modifyInfo = value;
				DictionaryUtil.Add(QueryParameters, "ModifyInfo", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AdminList")]
		public List<string> AdminList
		{
			get
			{
				return adminList;
			}

			set
			{
				adminList = value;
				if(adminList != null)
				{
					for (int depth1 = 0; depth1 < adminList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AdminList." + (depth1 + 1), adminList[depth1]);
					}
				}
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
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "ModifyAdmin")]
		public bool? ModifyAdmin
		{
			get
			{
				return modifyAdmin;
			}
			set	
			{
				modifyAdmin = value;
				DictionaryUtil.Add(QueryParameters, "ModifyAdmin", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyLiveMessageGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyLiveMessageGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
