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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class SendFileRequest : RpcAcsRequest<SendFileResponse>
    {
        public SendFileRequest()
            : base("Ecs", "2014-05-26", "SendFile", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ecs.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string description;

		private long? timeout;

		private string content;

		private string fileOwner;

		private bool? overwrite;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string fileMode;

		private long? ownerId;

		private string contentType;

		private List<string> instanceIds = new List<string>(){ };

		private string name;

		private string fileGroup;

		private string targetDir;

		[JsonProperty(PropertyName = "ResourceOwnerId")]
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

		[JsonProperty(PropertyName = "Description")]
		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		[JsonProperty(PropertyName = "Timeout")]
		public long? Timeout
		{
			get
			{
				return timeout;
			}
			set	
			{
				timeout = value;
				DictionaryUtil.Add(QueryParameters, "Timeout", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "Content")]
		public string Content
		{
			get
			{
				return content;
			}
			set	
			{
				content = value;
				DictionaryUtil.Add(QueryParameters, "Content", value);
			}
		}

		[JsonProperty(PropertyName = "FileOwner")]
		public string FileOwner
		{
			get
			{
				return fileOwner;
			}
			set	
			{
				fileOwner = value;
				DictionaryUtil.Add(QueryParameters, "FileOwner", value);
			}
		}

		[JsonProperty(PropertyName = "Overwrite")]
		public bool? Overwrite
		{
			get
			{
				return overwrite;
			}
			set	
			{
				overwrite = value;
				DictionaryUtil.Add(QueryParameters, "Overwrite", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ResourceOwnerAccount")]
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

		[JsonProperty(PropertyName = "OwnerAccount")]
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

		[JsonProperty(PropertyName = "FileMode")]
		public string FileMode
		{
			get
			{
				return fileMode;
			}
			set	
			{
				fileMode = value;
				DictionaryUtil.Add(QueryParameters, "FileMode", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
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

		[JsonProperty(PropertyName = "ContentType")]
		public string ContentType
		{
			get
			{
				return contentType;
			}
			set	
			{
				contentType = value;
				DictionaryUtil.Add(QueryParameters, "ContentType", value);
			}
		}

		[JsonProperty(PropertyName = "InstanceId")]
		public List<string> InstanceIds
		{
			get
			{
				return instanceIds;
			}

			set
			{
				instanceIds = value;
			}
		}

		[JsonProperty(PropertyName = "Name")]
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

		[JsonProperty(PropertyName = "FileGroup")]
		public string FileGroup
		{
			get
			{
				return fileGroup;
			}
			set	
			{
				fileGroup = value;
				DictionaryUtil.Add(QueryParameters, "FileGroup", value);
			}
		}

		[JsonProperty(PropertyName = "TargetDir")]
		public string TargetDir
		{
			get
			{
				return targetDir;
			}
			set	
			{
				targetDir = value;
				DictionaryUtil.Add(QueryParameters, "TargetDir", value);
			}
		}

        public override SendFileResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SendFileResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
