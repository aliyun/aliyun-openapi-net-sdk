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
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Model.V20180731
{
	public class CreateOrganizationResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private CreateOrganization_Result result;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public int? ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		public CreateOrganization_Result Result
		{
			get
			{
				return result;
			}
			set	
			{
				result = value;
			}
		}

		public class CreateOrganization_Result
		{

			private string organizationId;

			private string name;

			private string regionId;

			private string zoneId;

			private string codeName;

			private string domain;

			private string description;

			private string ownerBid;

			private int? ownerUid;

			private string ownerName;

			private int? peerCount;

			private int? userCount;

			private int? consortiumCount;

			private string specName;

			private string requestId;

			private string createTime;

			private string clusterState;

			private string serviceState;

			public string OrganizationId
			{
				get
				{
					return organizationId;
				}
				set	
				{
					organizationId = value;
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
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
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
				}
			}

			public string CodeName
			{
				get
				{
					return codeName;
				}
				set	
				{
					codeName = value;
				}
			}

			public string Domain
			{
				get
				{
					return domain;
				}
				set	
				{
					domain = value;
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
				}
			}

			public string OwnerBid
			{
				get
				{
					return ownerBid;
				}
				set	
				{
					ownerBid = value;
				}
			}

			public int? OwnerUid
			{
				get
				{
					return ownerUid;
				}
				set	
				{
					ownerUid = value;
				}
			}

			public string OwnerName
			{
				get
				{
					return ownerName;
				}
				set	
				{
					ownerName = value;
				}
			}

			public int? PeerCount
			{
				get
				{
					return peerCount;
				}
				set	
				{
					peerCount = value;
				}
			}

			public int? UserCount
			{
				get
				{
					return userCount;
				}
				set	
				{
					userCount = value;
				}
			}

			public int? ConsortiumCount
			{
				get
				{
					return consortiumCount;
				}
				set	
				{
					consortiumCount = value;
				}
			}

			public string SpecName
			{
				get
				{
					return specName;
				}
				set	
				{
					specName = value;
				}
			}

			public string RequestId
			{
				get
				{
					return requestId;
				}
				set	
				{
					requestId = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string ClusterState
			{
				get
				{
					return clusterState;
				}
				set	
				{
					clusterState = value;
				}
			}

			public string ServiceState
			{
				get
				{
					return serviceState;
				}
				set	
				{
					serviceState = value;
				}
			}
		}
	}
}