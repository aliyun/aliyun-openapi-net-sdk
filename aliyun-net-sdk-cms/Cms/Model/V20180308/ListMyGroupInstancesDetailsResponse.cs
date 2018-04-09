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

namespace Aliyun.Acs.Cms.Model.V20180308
{
	public class ListMyGroupInstancesDetailsResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private int? errorCode;

		private string errorMessage;

		private int? pageNumber;

		private int? pageSize;

		private int? total;

		private List<ListMyGroupInstancesDetails_Resource> resources;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
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
			}
		}

		public int? Total
		{
			get
			{
				return total;
			}
			set	
			{
				total = value;
			}
		}

		public List<ListMyGroupInstancesDetails_Resource> Resources
		{
			get
			{
				return resources;
			}
			set	
			{
				resources = value;
			}
		}

		public class ListMyGroupInstancesDetails_Resource
		{

			private long? aliUid;

			private string instanceName;

			private string instanceId;

			private string desc;

			private string networkType;

			private string category;

			private List<ListMyGroupInstancesDetails_Tag> tags;

			private ListMyGroupInstancesDetails_Region region;

			private ListMyGroupInstancesDetails_Vpc vpc;

			public long? AliUid
			{
				get
				{
					return aliUid;
				}
				set	
				{
					aliUid = value;
				}
			}

			public string InstanceName
			{
				get
				{
					return instanceName;
				}
				set	
				{
					instanceName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string Desc
			{
				get
				{
					return desc;
				}
				set	
				{
					desc = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string Category
			{
				get
				{
					return category;
				}
				set	
				{
					category = value;
				}
			}

			public List<ListMyGroupInstancesDetails_Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public ListMyGroupInstancesDetails_Region Region
			{
				get
				{
					return region;
				}
				set	
				{
					region = value;
				}
			}

			public ListMyGroupInstancesDetails_Vpc Vpc
			{
				get
				{
					return vpc;
				}
				set	
				{
					vpc = value;
				}
			}

			public class ListMyGroupInstancesDetails_Tag
			{

				private string key;

				private string _value;

				public string Key
				{
					get
					{
						return key;
					}
					set	
					{
						key = value;
					}
				}

				public string _Value
				{
					get
					{
						return _value;
					}
					set	
					{
						_value = value;
					}
				}
			}

			public class ListMyGroupInstancesDetails_Region
			{

				private string regionId;

				private string availabilityZone;

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

				public string AvailabilityZone
				{
					get
					{
						return availabilityZone;
					}
					set	
					{
						availabilityZone = value;
					}
				}
			}

			public class ListMyGroupInstancesDetails_Vpc
			{

				private string vpcInstanceId;

				private string vswitchInstanceId;

				public string VpcInstanceId
				{
					get
					{
						return vpcInstanceId;
					}
					set	
					{
						vpcInstanceId = value;
					}
				}

				public string VswitchInstanceId
				{
					get
					{
						return vswitchInstanceId;
					}
					set	
					{
						vswitchInstanceId = value;
					}
				}
			}
		}
	}
}