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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Mts.Transform.V20140618;

namespace Aliyun.Acs.Mts.Model.V20140618
{
    public class AddMediaRequest : RpcAcsRequest<AddMediaResponse>
    {
        public AddMediaRequest()
            : base("Mts", "2014-06-18", "AddMedia")
        {
        }

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _fileURL;

		private string _title;

		private string _description;

		private string _coverURL;

		private string _tags;

		private string _mediaWorkflowId;

		private string _mediaWorkflowUserData;

		private long? _cateId;

		private string _ownerAccount;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string FileURL
		{
			get
			{
				return _fileURL;
			}
			set	
			{
				_fileURL = value;
				DictionaryUtil.Add(QueryParameters, "FileURL", value);
			}
		}

		public string Title
		{
			get
			{
				return _title;
			}
			set	
			{
				_title = value;
				DictionaryUtil.Add(QueryParameters, "Title", value);
			}
		}

		public string Description
		{
			get
			{
				return _description;
			}
			set	
			{
				_description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string CoverURL
		{
			get
			{
				return _coverURL;
			}
			set	
			{
				_coverURL = value;
				DictionaryUtil.Add(QueryParameters, "CoverURL", value);
			}
		}

		public string Tags
		{
			get
			{
				return _tags;
			}
			set	
			{
				_tags = value;
				DictionaryUtil.Add(QueryParameters, "Tags", value);
			}
		}

		public string MediaWorkflowId
		{
			get
			{
				return _mediaWorkflowId;
			}
			set	
			{
				_mediaWorkflowId = value;
				DictionaryUtil.Add(QueryParameters, "MediaWorkflowId", value);
			}
		}

		public string MediaWorkflowUserData
		{
			get
			{
				return _mediaWorkflowUserData;
			}
			set	
			{
				_mediaWorkflowUserData = value;
				DictionaryUtil.Add(QueryParameters, "MediaWorkflowUserData", value);
			}
		}

		public long? CateId
		{
			get
			{
				return _cateId;
			}
			set	
			{
				_cateId = value;
				DictionaryUtil.Add(QueryParameters, "CateId", value.ToString());
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

        public override AddMediaResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return AddMediaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}