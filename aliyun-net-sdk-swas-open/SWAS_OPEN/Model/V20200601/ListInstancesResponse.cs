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

namespace Aliyun.Acs.SWAS_OPEN.Model.V20200601
{
	public class ListInstancesResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<ListInstances_Instance> instances;

		[JsonProperty(PropertyName = "TotalCount")]
		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "PageSize")]
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

		[JsonProperty(PropertyName = "PageNumber")]
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

		[JsonProperty(PropertyName = "Instances")]
		public List<ListInstances_Instance> Instances
		{
			get
			{
				return instances;
			}
			set	
			{
				instances = value;
			}
		}

		public class ListInstances_Instance
		{

			private string status;

			private string creationTime;

			private string innerIpAddress;

			private string chargeType;

			private string instanceId;

			private string planId;

			private string publicIpAddress;

			private string regionId;

			private string expiredTime;

			private string instanceName;

			private string businessStatus;

			private string ddosStatus;

			private string imageId;

			[JsonProperty(PropertyName = "Status")]
			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			[JsonProperty(PropertyName = "CreationTime")]
			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			[JsonProperty(PropertyName = "InnerIpAddress")]
			public string InnerIpAddress
			{
				get
				{
					return innerIpAddress;
				}
				set	
				{
					innerIpAddress = value;
				}
			}

			[JsonProperty(PropertyName = "ChargeType")]
			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceId")]
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

			[JsonProperty(PropertyName = "PlanId")]
			public string PlanId
			{
				get
				{
					return planId;
				}
				set	
				{
					planId = value;
				}
			}

			[JsonProperty(PropertyName = "PublicIpAddress")]
			public string PublicIpAddress
			{
				get
				{
					return publicIpAddress;
				}
				set	
				{
					publicIpAddress = value;
				}
			}

			[JsonProperty(PropertyName = "RegionId")]
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

			[JsonProperty(PropertyName = "ExpiredTime")]
			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
				}
			}

			[JsonProperty(PropertyName = "InstanceName")]
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

			[JsonProperty(PropertyName = "BusinessStatus")]
			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			[JsonProperty(PropertyName = "DdosStatus")]
			public string DdosStatus
			{
				get
				{
					return ddosStatus;
				}
				set	
				{
					ddosStatus = value;
				}
			}

			[JsonProperty(PropertyName = "ImageId")]
			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}
		}
	}
}
