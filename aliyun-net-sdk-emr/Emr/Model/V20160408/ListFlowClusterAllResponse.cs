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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListFlowClusterAllResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListFlowClusterAll_ClusterInfo> clusters;

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

		public List<ListFlowClusterAll_ClusterInfo> Clusters
		{
			get
			{
				return clusters;
			}
			set	
			{
				clusters = value;
			}
		}

		public class ListFlowClusterAll_ClusterInfo
		{

			private string id;

			private string name;

			private string type;

			private long? createTime;

			private int? runningTime;

			private string status;

			private string chargeType;

			private long? expiredTime;

			private int? period;

			private bool? hasUncompletedOrder;

			private string orderList;

			private string createResource;

			private string k8sClusterId;

			private ListFlowClusterAll_OrderTaskInfo orderTaskInfo;

			private ListFlowClusterAll_FailReason failReason;

			public string Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
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

			public long? CreateTime
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

			public int? RunningTime
			{
				get
				{
					return runningTime;
				}
				set	
				{
					runningTime = value;
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

			public long? ExpiredTime
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

			public int? Period
			{
				get
				{
					return period;
				}
				set	
				{
					period = value;
				}
			}

			public bool? HasUncompletedOrder
			{
				get
				{
					return hasUncompletedOrder;
				}
				set	
				{
					hasUncompletedOrder = value;
				}
			}

			public string OrderList
			{
				get
				{
					return orderList;
				}
				set	
				{
					orderList = value;
				}
			}

			public string CreateResource
			{
				get
				{
					return createResource;
				}
				set	
				{
					createResource = value;
				}
			}

			public string K8sClusterId
			{
				get
				{
					return k8sClusterId;
				}
				set	
				{
					k8sClusterId = value;
				}
			}

			public ListFlowClusterAll_OrderTaskInfo OrderTaskInfo
			{
				get
				{
					return orderTaskInfo;
				}
				set	
				{
					orderTaskInfo = value;
				}
			}

			public ListFlowClusterAll_FailReason FailReason
			{
				get
				{
					return failReason;
				}
				set	
				{
					failReason = value;
				}
			}

			public class ListFlowClusterAll_OrderTaskInfo
			{

				private int? targetCount;

				private int? currentCount;

				private string orderIdList;

				public int? TargetCount
				{
					get
					{
						return targetCount;
					}
					set	
					{
						targetCount = value;
					}
				}

				public int? CurrentCount
				{
					get
					{
						return currentCount;
					}
					set	
					{
						currentCount = value;
					}
				}

				public string OrderIdList
				{
					get
					{
						return orderIdList;
					}
					set	
					{
						orderIdList = value;
					}
				}
			}

			public class ListFlowClusterAll_FailReason
			{

				private string errorCode;

				private string errorMsg;

				private string requestId;

				public string ErrorCode
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

				public string ErrorMsg
				{
					get
					{
						return errorMsg;
					}
					set	
					{
						errorMsg = value;
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
			}
		}
	}
}
