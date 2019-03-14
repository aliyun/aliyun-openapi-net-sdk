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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class DescribeRouteConflictRequest : RpcAcsRequest<DescribeRouteConflictResponse>
    {
        public DescribeRouteConflictRequest()
            : base("Cbn", "2017-09-12", "DescribeRouteConflict", "cbn", "openAPI")
        {
        }

		private string childInstanceId;

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string destinationCidrBlock;

		private int? pageSize;

		private string action;

		private long? ownerId;

		private string childInstanceType;

		private string childInstanceRouteTableId;

		private int? pageNumber;

		private string childInstanceRegionId;

		public string ChildInstanceId
		{
			get
			{
				return childInstanceId;
			}
			set	
			{
				childInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceId", value);
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

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
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

		public string ChildInstanceType
		{
			get
			{
				return childInstanceType;
			}
			set	
			{
				childInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceType", value);
			}
		}

		public string ChildInstanceRouteTableId
		{
			get
			{
				return childInstanceRouteTableId;
			}
			set	
			{
				childInstanceRouteTableId = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceRouteTableId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string ChildInstanceRegionId
		{
			get
			{
				return childInstanceRegionId;
			}
			set	
			{
				childInstanceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceRegionId", value);
			}
		}

        public override DescribeRouteConflictResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRouteConflictResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
