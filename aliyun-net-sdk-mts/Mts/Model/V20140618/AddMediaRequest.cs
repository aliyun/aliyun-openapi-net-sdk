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
using Aliyun.Acs.Mts.Transform;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class AddMediaRequest : RpcAcsRequest<AddMediaResponse>
    {
        public AddMediaRequest()
            : base("Mts", "2014-06-18", "AddMedia", "mts", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private string description;

		private string title;

		private bool? inputUnbind;

		private string coverURL;

		private long? cateId;

		private string mediaWorkflowId;

		private string mediaWorkflowUserData;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string overrideParams;

		private long? ownerId;

		private string tags;

		private string fileURL;

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

		public string Title
		{
			get
			{
				return title;
			}
			set	
			{
				title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public bool? InputUnbind
		{
			get
			{
				return inputUnbind;
			}
			set	
			{
				inputUnbind = value;
				DictionaryUtil.Add(QueryParameters, "InputUnbind", value.ToString());
			}
		}

		public string CoverURL
		{
			get
			{
				return coverURL;
			}
			set	
			{
				coverURL = value;
				DictionaryUtil.Add(QueryParameters, "CoverURL", value);
			}
		}

		public long? CateId
		{
			get
			{
				return cateId;
			}
			set	
			{
				cateId = value;
				DictionaryUtil.Add(QueryParameters, "CateId", value.ToString());
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

		public string MediaWorkflowUserData
		{
			get
			{
				return mediaWorkflowUserData;
			}
			set	
			{
				mediaWorkflowUserData = value;
				DictionaryUtil.Add(QueryParameters, "MediaWorkflowUserData", value);
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

		public string Tags
		{
			get
			{
				return tags;
			}
			set	
			{
				tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		public string FileURL
		{
			get
			{
				return fileURL;
			}
			set	
			{
				fileURL = value;
				DictionaryUtil.Add(QueryParameters, "FileURL", value);
			}
		}

        public override AddMediaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddMediaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
