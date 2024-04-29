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
    public class AddShowIntoShowListRequest : RpcAcsRequest<AddShowIntoShowListResponse>
    {
        public AddShowIntoShowListRequest()
            : base("live", "2016-11-01", "AddShowIntoShowList", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<long?> showLists = new List<long?>(){ };

		private int? liveInputType;

		private bool? isBatchMode;

		private long? duration;

		private int? repeatTimes;

		private string showName;

		private string resourceId;

		private string casterId;

		private long? ownerId;

		private string resourceType;

		private string resourceUrl;

		private int? spot;

		public List<long?> ShowLists
		{
			get
			{
				return showLists;
			}

			set
			{
				showLists = value;
				if(showLists != null)
				{
					for (int depth1 = 0; depth1 < showLists.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
						DictionaryUtil.Add(QueryParameters,"showList." + (depth1 + 1), showLists[depth1]);
					}
				}
			}
		}

		public int? LiveInputType
		{
			get
			{
				return liveInputType;
			}
			set	
			{
				liveInputType = value;
				DictionaryUtil.Add(QueryParameters, "LiveInputType", value.ToString());
			}
		}

		public bool? IsBatchMode
		{
			get
			{
				return isBatchMode;
			}
			set	
			{
				isBatchMode = value;
				DictionaryUtil.Add(QueryParameters, "isBatchMode", value.ToString());
			}
		}

		public long? Duration
		{
			get
			{
				return duration;
			}
			set	
			{
				duration = value;
				DictionaryUtil.Add(QueryParameters, "Duration", value.ToString());
			}
		}

		public int? RepeatTimes
		{
			get
			{
				return repeatTimes;
			}
			set	
			{
				repeatTimes = value;
				DictionaryUtil.Add(QueryParameters, "RepeatTimes", value.ToString());
			}
		}

		public string ShowName
		{
			get
			{
				return showName;
			}
			set	
			{
				showName = value;
				DictionaryUtil.Add(QueryParameters, "ShowName", value);
			}
		}

		public string ResourceId
		{
			get
			{
				return resourceId;
			}
			set	
			{
				resourceId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceId", value);
			}
		}

		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
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

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
				DictionaryUtil.Add(QueryParameters, "ResourceType", value);
			}
		}

		public string ResourceUrl
		{
			get
			{
				return resourceUrl;
			}
			set	
			{
				resourceUrl = value;
				DictionaryUtil.Add(QueryParameters, "ResourceUrl", value);
			}
		}

		public int? Spot
		{
			get
			{
				return spot;
			}
			set	
			{
				spot = value;
				DictionaryUtil.Add(QueryParameters, "Spot", value.ToString());
			}
		}

		public class ShowList
		{

			private long? duration;

			private int? liveInputType;

			private int? repeatTimes;

			private string resourceId;

			private string resourceType;

			private string resourceUrl;

			private string showName;

			public long? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public int? LiveInputType
			{
				get
				{
					return liveInputType;
				}
				set	
				{
					liveInputType = value;
				}
			}

			public int? RepeatTimes
			{
				get
				{
					return repeatTimes;
				}
				set	
				{
					repeatTimes = value;
				}
			}

			public string ResourceId
			{
				get
				{
					return resourceId;
				}
				set	
				{
					resourceId = value;
				}
			}

			public string ResourceType
			{
				get
				{
					return resourceType;
				}
				set	
				{
					resourceType = value;
				}
			}

			public string ResourceUrl
			{
				get
				{
					return resourceUrl;
				}
				set	
				{
					resourceUrl = value;
				}
			}

			public string ShowName
			{
				get
				{
					return showName;
				}
				set	
				{
					showName = value;
				}
			}
		}

        public override AddShowIntoShowListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddShowIntoShowListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
