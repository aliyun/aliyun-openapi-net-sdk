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
    public class ModifyCasterEpisodeRequest : RpcAcsRequest<ModifyCasterEpisodeResponse>
    {
        public ModifyCasterEpisodeRequest()
            : base("live", "2016-11-01", "ModifyCasterEpisode", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string episodeName;

		private string startTime;

		private string resourceId;

		private List<string> componentIds = new List<string>(){ };

		private string casterId;

		private string endTime;

		private long? ownerId;

		private string episodeId;

		private string switchType;

		public string EpisodeName
		{
			get
			{
				return episodeName;
			}
			set	
			{
				episodeName = value;
				DictionaryUtil.Add(QueryParameters, "EpisodeName", value);
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

		public List<string> ComponentIds
		{
			get
			{
				return componentIds;
			}

			set
			{
				componentIds = value;
				for (int i = 0; i < componentIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ComponentId." + (i + 1) , componentIds[i]);
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

		public string EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value);
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

		public string EpisodeId
		{
			get
			{
				return episodeId;
			}
			set	
			{
				episodeId = value;
				DictionaryUtil.Add(QueryParameters, "EpisodeId", value);
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
				DictionaryUtil.Add(QueryParameters, "SwitchType", value);
			}
		}

        public override ModifyCasterEpisodeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterEpisodeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
