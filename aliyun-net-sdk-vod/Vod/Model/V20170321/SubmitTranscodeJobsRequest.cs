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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;
using System.Collections.Generic;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class SubmitTranscodeJobsRequest : RpcAcsRequest<SubmitTranscodeJobsResponse>
    {
        public SubmitTranscodeJobsRequest()
            : base("vod", "2017-03-21", "SubmitTranscodeJobs")
        {
        }

		private long? resourceOwnerId;

		private string templateGroupId;

		private string resourceOwnerAccount;

		private string action;

		private string videoId;

		private string overrideParams;

		private long? ownerId;

		private string encryptConfig;

		private string accessKeyId;

		private string pipelineId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TemplateGroupId
		{
			get
			{
				return templateGroupId;
			}
			set	
			{
				templateGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TemplateGroupId", value);
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
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

		public string VideoId
		{
			get
			{
				return videoId;
			}
			set	
			{
				videoId = value;
				DictionaryUtil.Add(QueryParameters, "VideoId", value);
			}
		}

		public string OverrideParams
		{
			get
			{
				return overrideParams;
			}
			set	
			{
				overrideParams = value;
				DictionaryUtil.Add(QueryParameters, "OverrideParams", value);
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

		public string EncryptConfig
		{
			get
			{
				return encryptConfig;
			}
			set	
			{
				encryptConfig = value;
				DictionaryUtil.Add(QueryParameters, "EncryptConfig", value);
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

		public string PipelineId
		{
			get
			{
				return pipelineId;
			}
			set	
			{
				pipelineId = value;
				DictionaryUtil.Add(QueryParameters, "PipelineId", value);
			}
		}

        public override SubmitTranscodeJobsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SubmitTranscodeJobsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}