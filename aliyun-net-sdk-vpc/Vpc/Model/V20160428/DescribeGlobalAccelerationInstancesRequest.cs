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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DescribeGlobalAccelerationInstancesRequest : RpcAcsRequest<DescribeGlobalAccelerationInstancesResponse>
    {
        public DescribeGlobalAccelerationInstancesRequest()
            : base("Vpc", "2016-04-28", "DescribeGlobalAccelerationInstances", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string ipAddress;

		private long? resourceOwnerId;

		private string bandwidthType;

		private bool? includeReservationData;

		private string globalAccelerationInstanceId;

		private int? pageNumber;

		private int? pageSize;

		private string resourceOwnerAccount;

		private string serviceLocation;

		private string ownerAccount;

		private long? ownerId;

		private string serverId;

		private string name;

		private string status;

		public string IpAddress
		{
			get
			{
				return ipAddress;
			}
			set	
			{
				ipAddress = value;
				DictionaryUtil.Add(QueryParameters, "IpAddress", value);
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

		public string BandwidthType
		{
			get
			{
				return bandwidthType;
			}
			set	
			{
				bandwidthType = value;
				DictionaryUtil.Add(QueryParameters, "BandwidthType", value);
			}
		}

		public bool? IncludeReservationData
		{
			get
			{
				return includeReservationData;
			}
			set	
			{
				includeReservationData = value;
				DictionaryUtil.Add(QueryParameters, "IncludeReservationData", value.ToString());
			}
		}

		public string GlobalAccelerationInstanceId
		{
			get
			{
				return globalAccelerationInstanceId;
			}
			set	
			{
				globalAccelerationInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "GlobalAccelerationInstanceId", value);
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

		public string ServiceLocation
		{
			get
			{
				return serviceLocation;
			}
			set	
			{
				serviceLocation = value;
				DictionaryUtil.Add(QueryParameters, "ServiceLocation", value);
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

		public string ServerId
		{
			get
			{
				return serverId;
			}
			set	
			{
				serverId = value;
				DictionaryUtil.Add(QueryParameters, "ServerId", value);
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

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

        public override DescribeGlobalAccelerationInstancesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeGlobalAccelerationInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
