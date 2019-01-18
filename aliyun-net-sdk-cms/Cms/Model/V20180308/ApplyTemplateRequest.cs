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
using Aliyun.Acs.Cms.Transform;
using Aliyun.Acs.Cms.Transform.V20180308;
using System.Collections.Generic;

namespace Aliyun.Acs.Cms.Model.V20180308
{
    public class ApplyTemplateRequest : RpcAcsRequest<ApplyTemplateResponse>
    {
        public ApplyTemplateRequest()
            : base("Cms", "2018-03-08", "ApplyTemplate", "cms", "openAPI")
        {
        }

		private long? enableStartTime;

		private string applyMode;

		private string templateIds;

		private long? enableEndTime;

		private long? groupId;

		private long? notifyLevel;

		private long? silenceTime;

		public long? EnableStartTime
		{
			get
			{
				return enableStartTime;
			}
			set	
			{
				enableStartTime = value;
				DictionaryUtil.Add(QueryParameters, "EnableStartTime", value.ToString());
			}
		}

		public string ApplyMode
		{
			get
			{
				return applyMode;
			}
			set	
			{
				applyMode = value;
				DictionaryUtil.Add(QueryParameters, "ApplyMode", value);
			}
		}

		public string TemplateIds
		{
			get
			{
				return templateIds;
			}
			set	
			{
				templateIds = value;
				DictionaryUtil.Add(QueryParameters, "TemplateIds", value);
			}
		}

		public long? EnableEndTime
		{
			get
			{
				return enableEndTime;
			}
			set	
			{
				enableEndTime = value;
				DictionaryUtil.Add(QueryParameters, "EnableEndTime", value.ToString());
			}
		}

		public long? GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value.ToString());
			}
		}

		public long? NotifyLevel
		{
			get
			{
				return notifyLevel;
			}
			set	
			{
				notifyLevel = value;
				DictionaryUtil.Add(QueryParameters, "NotifyLevel", value.ToString());
			}
		}

		public long? SilenceTime
		{
			get
			{
				return silenceTime;
			}
			set	
			{
				silenceTime = value;
				DictionaryUtil.Add(QueryParameters, "SilenceTime", value.ToString());
			}
		}

        public override ApplyTemplateResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ApplyTemplateResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}