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
    public class ModifyShowListRequest : RpcAcsRequest<ModifyShowListResponse>
    {
        public ModifyShowListRequest()
            : base("live", "2016-11-01", "ModifyShowList", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? repeatTimes;

		private string highPriorityShowStartTime;

		private string casterId;

		private string highPriorityShowId;

		private long? ownerId;

		private string showId;

		private int? spot;

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

		public string HighPriorityShowStartTime
		{
			get
			{
				return highPriorityShowStartTime;
			}
			set	
			{
				highPriorityShowStartTime = value;
				DictionaryUtil.Add(QueryParameters, "HighPriorityShowStartTime", value);
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

		public string HighPriorityShowId
		{
			get
			{
				return highPriorityShowId;
			}
			set	
			{
				highPriorityShowId = value;
				DictionaryUtil.Add(QueryParameters, "HighPriorityShowId", value);
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

		public string ShowId
		{
			get
			{
				return showId;
			}
			set	
			{
				showId = value;
				DictionaryUtil.Add(QueryParameters, "ShowId", value);
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

        public override ModifyShowListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyShowListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
