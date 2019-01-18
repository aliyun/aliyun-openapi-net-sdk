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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;
using System.Collections.Generic;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class ListMediaWorkflowExecutionsRequest : RpcAcsRequest<ListMediaWorkflowExecutionsResponse>
    {
        public ListMediaWorkflowExecutionsRequest()
            : base("Mts", "2014-06-18", "ListMediaWorkflowExecutions", "mts", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string inputFileURL;

		private string nextPageToken;

		private string ownerAccount;

		private string action;

		private long? maximumPageSize;

		private string mediaWorkflowId;

		private long? ownerId;

		private string mediaWorkflowName;

		private string accessKeyId;

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

		public string InputFileURL
		{
			get
			{
				return inputFileURL;
			}
			set	
			{
				inputFileURL = value;
				DictionaryUtil.Add(QueryParameters, "InputFileURL", value);
			}
		}

		public string NextPageToken
		{
			get
			{
				return nextPageToken;
			}
			set	
			{
				nextPageToken = value;
				DictionaryUtil.Add(QueryParameters, "NextPageToken", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
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

		public long? MaximumPageSize
		{
			get
			{
				return maximumPageSize;
			}
			set	
			{
				maximumPageSize = value;
				DictionaryUtil.Add(QueryParameters, "MaximumPageSize", value.ToString());
			}
		}

		public string MediaWorkflowId
		{
			get
			{
				return mediaWorkflowId;
			}
			set	
			{
				mediaWorkflowId = value;
				DictionaryUtil.Add(QueryParameters, "MediaWorkflowId", value);
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

		public string MediaWorkflowName
		{
			get
			{
				return mediaWorkflowName;
			}
			set	
			{
				mediaWorkflowName = value;
				DictionaryUtil.Add(QueryParameters, "MediaWorkflowName", value);
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

        public override ListMediaWorkflowExecutionsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ListMediaWorkflowExecutionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}