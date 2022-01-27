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

namespace Aliyun.Acs.Cbn.Model.V20170912
{
	public class DescribeCenAttachedChildInstancesResponse : AcsResponse
	{

		private int? pageSize;

		private string requestId;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeCenAttachedChildInstances_ChildInstance> childInstances;

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

		public List<DescribeCenAttachedChildInstances_ChildInstance> ChildInstances
		{
			get
			{
				return childInstances;
			}
			set	
			{
				childInstances = value;
			}
		}

		public class DescribeCenAttachedChildInstances_ChildInstance
		{

			private string childInstanceType;

			private string status;

			private string childInstanceRegionId;

			private long? childInstanceOwnerId;

			private string childInstanceId;

			private string cenId;

			private string childInstanceAttachTime;

			public string ChildInstanceType
			{
				get
				{
					return childInstanceType;
				}
				set	
				{
					childInstanceType = value;
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
				}
			}

			public long? ChildInstanceOwnerId
			{
				get
				{
					return childInstanceOwnerId;
				}
				set	
				{
					childInstanceOwnerId = value;
				}
			}

			public string ChildInstanceId
			{
				get
				{
					return childInstanceId;
				}
				set	
				{
					childInstanceId = value;
				}
			}

			public string CenId
			{
				get
				{
					return cenId;
				}
				set	
				{
					cenId = value;
				}
			}

			public string ChildInstanceAttachTime
			{
				get
				{
					return childInstanceAttachTime;
				}
				set	
				{
					childInstanceAttachTime = value;
				}
			}
		}
	}
}
