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
	public class GetHdfsCapacityStatisticInfoResponse : AcsResponse
	{

		private string requestId;

		private List<GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity> hdfsCapacityList;

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

		public List<GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity> HdfsCapacityList
		{
			get
			{
				return hdfsCapacityList;
			}
			set	
			{
				hdfsCapacityList = value;
			}
		}

		public class GetHdfsCapacityStatisticInfo_ClusterStatHdfsCapacity
		{

			private long? capacityTotal;

			private long? capacityTotalGB;

			private long? capacityUsed;

			private long? capacityUsedGB;

			private long? capacityRemaining;

			private long? capacityRemainingGB;

			private long? capacityUsedNonDfs;

			private string clusterBizId;

			private string dateTime;

			public long? CapacityTotal
			{
				get
				{
					return capacityTotal;
				}
				set	
				{
					capacityTotal = value;
				}
			}

			public long? CapacityTotalGB
			{
				get
				{
					return capacityTotalGB;
				}
				set	
				{
					capacityTotalGB = value;
				}
			}

			public long? CapacityUsed
			{
				get
				{
					return capacityUsed;
				}
				set	
				{
					capacityUsed = value;
				}
			}

			public long? CapacityUsedGB
			{
				get
				{
					return capacityUsedGB;
				}
				set	
				{
					capacityUsedGB = value;
				}
			}

			public long? CapacityRemaining
			{
				get
				{
					return capacityRemaining;
				}
				set	
				{
					capacityRemaining = value;
				}
			}

			public long? CapacityRemainingGB
			{
				get
				{
					return capacityRemainingGB;
				}
				set	
				{
					capacityRemainingGB = value;
				}
			}

			public long? CapacityUsedNonDfs
			{
				get
				{
					return capacityUsedNonDfs;
				}
				set	
				{
					capacityUsedNonDfs = value;
				}
			}

			public string ClusterBizId
			{
				get
				{
					return clusterBizId;
				}
				set	
				{
					clusterBizId = value;
				}
			}

			public string DateTime
			{
				get
				{
					return dateTime;
				}
				set	
				{
					dateTime = value;
				}
			}
		}
	}
}
