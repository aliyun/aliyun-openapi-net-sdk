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
using Aliyun.Acs.Dds.Transform;
using Aliyun.Acs.Dds.Transform.V20151201;

namespace Aliyun.Acs.Dds.Model.V20151201
{
    public class DescribeAvailabilityZonesRequest : RpcAcsRequest<DescribeAvailabilityZonesResponse>
    {
        public DescribeAvailabilityZonesRequest()
            : base("Dds", "2015-12-01", "DescribeAvailabilityZones", "dds", "openAPI")
        {
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string storageType;

		private string resourceGroupId;

		private string securityToken;

		private string excludeZoneId;

		private string excludeSecondaryZoneId;

		private string instanceChargeType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string mongoType;

		private long? ownerId;

		private string storageSupport;

		private string dbType;

		private string acceptLanguage;

		private string zoneId;

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

		public string StorageType
		{
			get
			{
				return storageType;
			}
			set	
			{
				storageType = value;
				DictionaryUtil.Add(QueryParameters, "StorageType", value);
			}
		}

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string ExcludeZoneId
		{
			get
			{
				return excludeZoneId;
			}
			set	
			{
				excludeZoneId = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeZoneId", value);
			}
		}

		public string ExcludeSecondaryZoneId
		{
			get
			{
				return excludeSecondaryZoneId;
			}
			set	
			{
				excludeSecondaryZoneId = value;
				DictionaryUtil.Add(QueryParameters, "ExcludeSecondaryZoneId", value);
			}
		}

		public string InstanceChargeType
		{
			get
			{
				return instanceChargeType;
			}
			set	
			{
				instanceChargeType = value;
				DictionaryUtil.Add(QueryParameters, "InstanceChargeType", value);
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

		public string MongoType
		{
			get
			{
				return mongoType;
			}
			set	
			{
				mongoType = value;
				DictionaryUtil.Add(QueryParameters, "MongoType", value);
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

		public string StorageSupport
		{
			get
			{
				return storageSupport;
			}
			set	
			{
				storageSupport = value;
				DictionaryUtil.Add(QueryParameters, "StorageSupport", value);
			}
		}

		public string DbType
		{
			get
			{
				return dbType;
			}
			set	
			{
				dbType = value;
				DictionaryUtil.Add(QueryParameters, "DbType", value);
			}
		}

		public string AcceptLanguage
		{
			get
			{
				return acceptLanguage;
			}
			set	
			{
				acceptLanguage = value;
				DictionaryUtil.Add(QueryParameters, "AcceptLanguage", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeAvailabilityZonesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeAvailabilityZonesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
