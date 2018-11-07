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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.rtc.Transform;
using Aliyun.Acs.rtc.Transform.V20180111;
using System.Collections.Generic;

namespace Aliyun.Acs.rtc.Model.V20180111
{
    public class UpdateTaskParamRequest : RpcAcsRequest<UpdateTaskParamResponse>
    {
        public UpdateTaskParamRequest()
            : base("rtc", "2018-01-11", "UpdateTaskParam", "rtc", "openAPI")
        {
        }

		private List<MixPanes> mixPaness;

		private string action;

		private long? taskId;

		private long? ownerId;

		private long? templateId;

		private string appId;

		private string channelId;

		public List<MixPanes> MixPaness
		{
			get
			{
				return mixPaness;
			}

			set
			{
				mixPaness = value;
				for (int i = 0; i < mixPaness.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MixPanes." + (i + 1) + ".PaneId", mixPaness[i].PaneId);
					DictionaryUtil.Add(QueryParameters,"MixPanes." + (i + 1) + ".UserId", mixPaness[i].UserId);
					DictionaryUtil.Add(QueryParameters,"MixPanes." + (i + 1) + ".SourceType", mixPaness[i].SourceType);
				}
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

		public long? TaskId
		{
			get
			{
				return taskId;
			}
			set	
			{
				taskId = value;
				DictionaryUtil.Add(QueryParameters, "TaskId", value.ToString());
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

		public long? TemplateId
		{
			get
			{
				return templateId;
			}
			set	
			{
				templateId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateId", value.ToString());
			}
		}

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

		public string ChannelId
		{
			get
			{
				return channelId;
			}
			set	
			{
				channelId = value;
				DictionaryUtil.Add(QueryParameters, "ChannelId", value);
			}
		}

		public class MixPanes
		{

			private int? paneId;

			private string userId;

			private string sourceType;

			public int? PaneId
			{
				get
				{
					return paneId;
				}
				set	
				{
					paneId = value;
				}
			}

			public string UserId
			{
				get
				{
					return userId;
				}
				set	
				{
					userId = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
				}
			}
		}

        public override UpdateTaskParamResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateTaskParamResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}