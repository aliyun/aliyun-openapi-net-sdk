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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateImageRequest : RpcAcsRequest<CreateImageResponse>
    {
        public CreateImageRequest()
            : base("Ecs", "2014-05-26", "CreateImage")
        {
        }

	private long? ownerId;

	private string resourceOwnerAccount;

	private long? resourceOwnerId;

	private string snapshotId;

	private string imageName;

	private string imageVersion;

	private string description;

	private string clientToken;

	private string ownerAccount;

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

	public string SnapshotId
	{
		get
		{
			return snapshotId;
		}
		set	
		{
			snapshotId = value;
			DictionaryUtil.Add(QueryParameters, "SnapshotId", value);
		}
	}

	public string ImageName
	{
		get
		{
			return imageName;
		}
		set	
		{
			imageName = value;
			DictionaryUtil.Add(QueryParameters, "ImageName", value);
		}
	}

	public string ImageVersion
	{
		get
		{
			return imageVersion;
		}
		set	
		{
			imageVersion = value;
			DictionaryUtil.Add(QueryParameters, "ImageVersion", value);
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

	public string ClientToken
	{
		get
		{
			return clientToken;
		}
		set	
		{
			clientToken = value;
			DictionaryUtil.Add(QueryParameters, "ClientToken", value);
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

        public override CreateImageResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateImageResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}