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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class DescribeAccessPointsResponse : AcsResponse
	{

		private string requestId;

		private int? pageNumber;

		private int? pageSize;

		private int? totalCount;

		private List<DescribeAccessPoints_AccessPointType> accessPointSet;

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

		public List<DescribeAccessPoints_AccessPointType> AccessPointSet
		{
			get
			{
				return accessPointSet;
			}
			set	
			{
				accessPointSet = value;
			}
		}

		public class DescribeAccessPoints_AccessPointType
		{

			private string status;

			private string type;

			private string hostOperator;

			private string description;

			private string attachedRegionNo;

			private string name;

			private string accessPointId;

			private string location;

			private List<DescribeAccessPoints_AccessPointFeatureModel> accessPointFeatureModels;

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

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string HostOperator
			{
				get
				{
					return hostOperator;
				}
				set	
				{
					hostOperator = value;
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

			public string AttachedRegionNo
			{
				get
				{
					return attachedRegionNo;
				}
				set	
				{
					attachedRegionNo = value;
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

			public string AccessPointId
			{
				get
				{
					return accessPointId;
				}
				set	
				{
					accessPointId = value;
				}
			}

			public string Location
			{
				get
				{
					return location;
				}
				set	
				{
					location = value;
				}
			}

			public List<DescribeAccessPoints_AccessPointFeatureModel> AccessPointFeatureModels
			{
				get
				{
					return accessPointFeatureModels;
				}
				set	
				{
					accessPointFeatureModels = value;
				}
			}

			public class DescribeAccessPoints_AccessPointFeatureModel
			{

				private string featureValue;

				private string featureKey;

				public string FeatureValue
				{
					get
					{
						return featureValue;
					}
					set	
					{
						featureValue = value;
					}
				}

				public string FeatureKey
				{
					get
					{
						return featureKey;
					}
					set	
					{
						featureKey = value;
					}
				}
			}
		}
	}
}
