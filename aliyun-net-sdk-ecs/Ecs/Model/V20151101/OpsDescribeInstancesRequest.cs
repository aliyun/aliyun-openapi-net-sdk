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
using Aliyun.Acs.Ecs.Transform.V20151101;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20151101
{
    public class OpsDescribeInstancesRequest : RpcAcsRequest<OpsDescribeInstancesResponse>
    {
        public OpsDescribeInstancesRequest()
            : base("Ecs", "2015-11-01", "OpsDescribeInstances")
        {
        }

		private string regionNo;

		private string vpcId;

		private string vswId;

		private string izNo;

		private string netWorkType;

		private string groupId;

		private long? resourceOwnerId;

		private string ecsInstanceIds;

		private string privateIpAddresses;

		private string publicIpAddresses;

		private string ecsInstanceName;

		private string imageId;

		private string status;

		private bool? mountAvailable;

		private bool? ioOptimized;

		private string createTimeFrom;

		private string createTimeTo;

		private int? pageNo;

		private int? pageSize;

		public string RegionNo
		{
			get
			{
				return regionNo;
			}
			set	
			{
				regionNo = value;
				DictionaryUtil.Add(QueryParameters, "RegionNo", value);
			}
		}

		public string VpcId
		{
			get
			{
				return vpcId;
			}
			set	
			{
				vpcId = value;
				DictionaryUtil.Add(QueryParameters, "VpcId", value);
			}
		}

		public string VswId
		{
			get
			{
				return vswId;
			}
			set	
			{
				vswId = value;
				DictionaryUtil.Add(QueryParameters, "VswId", value);
			}
		}

		public string IzNo
		{
			get
			{
				return izNo;
			}
			set	
			{
				izNo = value;
				DictionaryUtil.Add(QueryParameters, "IzNo", value);
			}
		}

		public string NetWorkType
		{
			get
			{
				return netWorkType;
			}
			set	
			{
				netWorkType = value;
				DictionaryUtil.Add(QueryParameters, "NetWorkType", value);
			}
		}

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
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

		public string EcsInstanceIds
		{
			get
			{
				return ecsInstanceIds;
			}
			set	
			{
				ecsInstanceIds = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceIds", value);
			}
		}

		public string PrivateIpAddresses
		{
			get
			{
				return privateIpAddresses;
			}
			set	
			{
				privateIpAddresses = value;
				DictionaryUtil.Add(QueryParameters, "PrivateIpAddresses", value);
			}
		}

		public string PublicIpAddresses
		{
			get
			{
				return publicIpAddresses;
			}
			set	
			{
				publicIpAddresses = value;
				DictionaryUtil.Add(QueryParameters, "PublicIpAddresses", value);
			}
		}

		public string EcsInstanceName
		{
			get
			{
				return ecsInstanceName;
			}
			set	
			{
				ecsInstanceName = value;
				DictionaryUtil.Add(QueryParameters, "EcsInstanceName", value);
			}
		}

		public string ImageId
		{
			get
			{
				return imageId;
			}
			set	
			{
				imageId = value;
				DictionaryUtil.Add(QueryParameters, "ImageId", value);
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

		public bool? MountAvailable
		{
			get
			{
				return mountAvailable;
			}
			set	
			{
				mountAvailable = value;
				DictionaryUtil.Add(QueryParameters, "MountAvailable", value.ToString());
			}
		}

		public bool? IoOptimized
		{
			get
			{
				return ioOptimized;
			}
			set	
			{
				ioOptimized = value;
				DictionaryUtil.Add(QueryParameters, "IoOptimized", value.ToString());
			}
		}

		public string CreateTimeFrom
		{
			get
			{
				return createTimeFrom;
			}
			set	
			{
				createTimeFrom = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeFrom", value);
			}
		}

		public string CreateTimeTo
		{
			get
			{
				return createTimeTo;
			}
			set	
			{
				createTimeTo = value;
				DictionaryUtil.Add(QueryParameters, "CreateTimeTo", value);
			}
		}

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
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

        public override OpsDescribeInstancesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return OpsDescribeInstancesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}