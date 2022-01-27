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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeExposedStatisticsDetailResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeExposedStatisticsDetail_StatisticsDetail> statisticsDetails;

		private DescribeExposedStatisticsDetail_PageInfo pageInfo;

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

		public List<DescribeExposedStatisticsDetail_StatisticsDetail> StatisticsDetails
		{
			get
			{
				return statisticsDetails;
			}
			set	
			{
				statisticsDetails = value;
			}
		}

		public DescribeExposedStatisticsDetail_PageInfo PageInfo
		{
			get
			{
				return pageInfo;
			}
			set	
			{
				pageInfo = value;
			}
		}

		public class DescribeExposedStatisticsDetail_StatisticsDetail
		{

			private string exposureComponent;

			private string exposureType;

			private string exposureTypeId;

			private string exposurePort;

			private string exposureIp;

			private string exposureTypeInstanceName;

			private int? exposedCount;

			private string regionId;

			public string ExposureComponent
			{
				get
				{
					return exposureComponent;
				}
				set	
				{
					exposureComponent = value;
				}
			}

			public string ExposureType
			{
				get
				{
					return exposureType;
				}
				set	
				{
					exposureType = value;
				}
			}

			public string ExposureTypeId
			{
				get
				{
					return exposureTypeId;
				}
				set	
				{
					exposureTypeId = value;
				}
			}

			public string ExposurePort
			{
				get
				{
					return exposurePort;
				}
				set	
				{
					exposurePort = value;
				}
			}

			public string ExposureIp
			{
				get
				{
					return exposureIp;
				}
				set	
				{
					exposureIp = value;
				}
			}

			public string ExposureTypeInstanceName
			{
				get
				{
					return exposureTypeInstanceName;
				}
				set	
				{
					exposureTypeInstanceName = value;
				}
			}

			public int? ExposedCount
			{
				get
				{
					return exposedCount;
				}
				set	
				{
					exposedCount = value;
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
		}

		public class DescribeExposedStatisticsDetail_PageInfo
		{

			private int? count;

			private int? pageSize;

			private int? totalCount;

			private int? currentPage;

			public int? Count
			{
				get
				{
					return count;
				}
				set	
				{
					count = value;
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

			public int? CurrentPage
			{
				get
				{
					return currentPage;
				}
				set	
				{
					currentPage = value;
				}
			}
		}
	}
}
