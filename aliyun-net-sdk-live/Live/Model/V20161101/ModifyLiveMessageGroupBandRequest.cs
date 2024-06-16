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
    public class ModifyLiveMessageGroupBandRequest : RpcAcsRequest<ModifyLiveMessageGroupBandResponse>
    {
        public ModifyLiveMessageGroupBandRequest()
            : base("live", "2016-11-01", "ModifyLiveMessageGroupBand", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private bool? bannedAll;

		private string groupId;

		private List<string> exceptUsers = new List<string>(){ };

		private string dataCenter;

		private string appId;

		private List<string> bannnedUsers = new List<string>(){ };

		[JsonProperty(PropertyName = "BannedAll")]
		public bool? BannedAll
		{
			get
			{
				return bannedAll;
			}
			set	
			{
				bannedAll = value;
				DictionaryUtil.Add(QueryParameters, "BannedAll", value.ToString());
			}
		}

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

		[JsonProperty(PropertyName = "ExceptUsers")]
		public List<string> ExceptUsers
		{
			get
			{
				return exceptUsers;
			}

			set
			{
				exceptUsers = value;
				if(exceptUsers != null)
				{
					for (int depth1 = 0; depth1 < exceptUsers.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ExceptUsers." + (depth1 + 1), exceptUsers[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "BannnedUsers")]
		public List<string> BannnedUsers
		{
			get
			{
				return bannnedUsers;
			}

			set
			{
				bannnedUsers = value;
				if(bannnedUsers != null)
				{
					for (int depth1 = 0; depth1 < bannnedUsers.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"BannnedUsers." + (depth1 + 1), bannnedUsers[depth1]);
					}
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ModifyLiveMessageGroupBandResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyLiveMessageGroupBandResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
