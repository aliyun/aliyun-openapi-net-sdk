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
using Aliyun.Acs.AIPodcast;
using Aliyun.Acs.AIPodcast.Transform;
using Aliyun.Acs.AIPodcast.Transform.V20250228;

namespace Aliyun.Acs.AIPodcast.Model.V20250228
{
    public class PodcastTaskResultQueryRequest : RoaAcsRequest<PodcastTaskResultQueryResponse>
    {
        public PodcastTaskResultQueryRequest()
            : base("AIPodcast", "2025-02-28", "PodcastTaskResultQuery")
        {
			Protocol = ProtocolType.HTTPS;
			UriPattern = "/podcast/task";
			Method = MethodType.POST;
        }

		private string taskId;

		private string workspaceId;

		public string TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(BodyParameters, "taskId", value);
			}
		}

		public string WorkspaceId
		{
			get
			{
				return workspaceId;
			}
			set	
			{
				workspaceId = value;
				DictionaryUtil.Add(BodyParameters, "workspaceId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override PodcastTaskResultQueryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return PodcastTaskResultQueryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
