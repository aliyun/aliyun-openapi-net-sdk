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
using Aliyun.Acs.vod.Transform;
using Aliyun.Acs.vod.Transform.V20170321;

namespace Aliyun.Acs.vod.Model.V20170321
{
    public class UpdateTranscodeTemplateGroupRequest : RpcAcsRequest<UpdateTranscodeTemplateGroupResponse>
    {
        public UpdateTranscodeTemplateGroupRequest()
            : base("vod", "2017-03-21", "UpdateTranscodeTemplateGroup", "vod", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string transcodeTemplateList;

		private long? resourceOwnerId;

		private string locked;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string transcodeTemplateGroupId;

		private string name;

		public string TranscodeTemplateList
		{
			get
			{
				return transcodeTemplateList;
			}
			set	
			{
				transcodeTemplateList = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeTemplateList", value);
			}
		}

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

		public string Locked
		{
			get
			{
				return locked;
			}
			set	
			{
				locked = value;
				DictionaryUtil.Add(QueryParameters, "Locked", value);
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

		public string TranscodeTemplateGroupId
		{
			get
			{
				return transcodeTemplateGroupId;
			}
			set	
			{
				transcodeTemplateGroupId = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeTemplateGroupId", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

        public override UpdateTranscodeTemplateGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateTranscodeTemplateGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
