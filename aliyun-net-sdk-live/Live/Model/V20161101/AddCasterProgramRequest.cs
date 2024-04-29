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
    public class AddCasterProgramRequest : RpcAcsRequest<AddCasterProgramResponse>
    {
        public AddCasterProgramRequest()
            : base("live", "2016-11-01", "AddCasterProgram", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<Episode> episodes = new List<Episode>(){ };

		private string casterId;

		private long? ownerId;

		public List<Episode> Episodes
		{
			get
			{
				return episodes;
			}

			set
			{
				episodes = value;
				if(episodes != null)
				{
					for (int depth1 = 0; depth1 < episodes.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
						DictionaryUtil.Add(QueryParameters,"Episode." + (depth1 + 1), episodes[depth1]);
					}
				}
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

		public class Episode
		{

			private List<string> componentIds = new List<string>(){ };

			private string endTime;

			private string episodeName;

			private string episodeType;

			private string resourceId;

			private string startTime;

			private string switchType;

			public List<string> ComponentIds
			{
				get
				{
					return componentIds;
				}
				set	
				{
					componentIds = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public string EpisodeName
			{
				get
				{
					return episodeName;
				}
				set	
				{
					episodeName = value;
				}
			}

			public string EpisodeType
			{
				get
				{
					return episodeType;
				}
				set	
				{
					episodeType = value;
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

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string SwitchType
			{
				get
				{
					return switchType;
				}
				set	
				{
					switchType = value;
				}
			}
		}

        public override AddCasterProgramResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCasterProgramResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
