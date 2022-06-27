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
    public class AddCasterEpisodeGroupRequest : RpcAcsRequest<AddCasterEpisodeGroupResponse>
    {
        public AddCasterEpisodeGroupRequest()
            : base("live", "2016-11-01", "AddCasterEpisodeGroup", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string clientToken;

		private string startTime;

		private string sideOutputUrl;

		private List<Item> items = new List<Item>(){ };

		private string domainName;

		private long? ownerId;

		private int? repeatNum;

		private string callbackUrl;

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string StartTime
		{
			get
			{
				return startTime;
			}
			set	
			{
				startTime = value;
				DictionaryUtil.Add(QueryParameters, "StartTime", value);
			}
		}

		public string SideOutputUrl
		{
			get
			{
				return sideOutputUrl;
			}
			set	
			{
				sideOutputUrl = value;
				DictionaryUtil.Add(QueryParameters, "SideOutputUrl", value);
			}
		}

		public List<Item> Items
		{
			get
			{
				return items;
			}

			set
			{
				items = value;
				for (int i = 0; i < items.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Item." + (i + 1) + ".ItemName", items[i].ItemName);
					DictionaryUtil.Add(QueryParameters,"Item." + (i + 1) + ".VodUrl", items[i].VodUrl);
				}
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public int? RepeatNum
		{
			get
			{
				return repeatNum;
			}
			set	
			{
				repeatNum = value;
				DictionaryUtil.Add(QueryParameters, "RepeatNum", value.ToString());
			}
		}

		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

		public class Item
		{

			private string itemName;

			private string vodUrl;

			public string ItemName
			{
				get
				{
					return itemName;
				}
				set	
				{
					itemName = value;
				}
			}

			public string VodUrl
			{
				get
				{
					return vodUrl;
				}
				set	
				{
					vodUrl = value;
				}
			}
		}

        public override AddCasterEpisodeGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCasterEpisodeGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
