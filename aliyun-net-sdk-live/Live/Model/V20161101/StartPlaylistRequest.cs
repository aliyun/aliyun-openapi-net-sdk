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
    public class StartPlaylistRequest : RpcAcsRequest<StartPlaylistResponse>
    {
        public StartPlaylistRequest()
            : base("live", "2016-11-01", "StartPlaylist", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string resumeMode;

		private string startItemId;

		private string programId;

		private int? offset;

		private long? ownerId;

		public string ResumeMode
		{
			get
			{
				return resumeMode;
			}
			set	
			{
				resumeMode = value;
				DictionaryUtil.Add(QueryParameters, "ResumeMode", value);
			}
		}

		public string StartItemId
		{
			get
			{
				return startItemId;
			}
			set	
			{
				startItemId = value;
				DictionaryUtil.Add(QueryParameters, "StartItemId", value);
			}
		}

		public string ProgramId
		{
			get
			{
				return programId;
			}
			set	
			{
				programId = value;
				DictionaryUtil.Add(QueryParameters, "ProgramId", value);
			}
		}

		public int? Offset
		{
			get
			{
				return offset;
			}
			set	
			{
				offset = value;
				DictionaryUtil.Add(QueryParameters, "Offset", value.ToString());
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

        public override StartPlaylistResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return StartPlaylistResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
