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
    public class ModifyCasterProgramRequest : RpcAcsRequest<ModifyCasterProgramResponse>
    {
        public ModifyCasterProgramRequest()
            : base("live", "2016-11-01", "ModifyCasterProgram", "live", "openAPI")
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
				for (int i = 0; i < episodes.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".EpisodeId", episodes[i].EpisodeId);
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".EpisodeType", episodes[i].EpisodeType);
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".EpisodeName", episodes[i].EpisodeName);
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".ResourceId", episodes[i].ResourceId);
					for (int j = 0; j < episodes[i].ComponentIds.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".ComponentId." +(j + 1), episodes[i].ComponentIds[j]);
					}
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".StartTime", episodes[i].StartTime);
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".EndTime", episodes[i].EndTime);
					DictionaryUtil.Add(QueryParameters,"Episode." + (i + 1) + ".SwitchType", episodes[i].SwitchType);
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

			private string episodeId;

			private string episodeType;

			private string episodeName;

			private string resourceId;

			private List<string> componentIds = new List<string>(){ };

			private string startTime;

			private string endTime;

			private string switchType;

			public string EpisodeId
			{
				get
				{
					return episodeId;
				}
				set	
				{
					episodeId = value;
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

        public override ModifyCasterProgramResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterProgramResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
