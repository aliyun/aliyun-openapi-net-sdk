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

namespace Aliyun.Acs.Cassandra.Model.V20190101
{
	public class DescribeClustersResponse : AcsResponse
	{

		private string requestId;

		private long? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeClusters_Cluster> clusters;

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

		public long? TotalCount
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

		public List<DescribeClusters_Cluster> Clusters
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

		public class DescribeClusters_Cluster
		{

			private string clusterId;

			private string clusterName;

			private string status;

			private string payType;

			private string createdTime;

			private string expireTime;

			private string majorVersion;

			private string minorVersion;

			private int? dataCenterCount;

			private string lockMode;

			private bool? autoRenewal;

			private int? autoRenewPeriod;

			private List<DescribeClusters_Tag> tags;

			public string ClusterId
			{
				get
				{
					return clusterId;
				}
				set	
				{
					clusterId = value;
				}
			}

			public string ClusterName
			{
				get
				{
					return clusterName;
				}
				set	
				{
					clusterName = value;
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

			public string PayType
			{
				get
				{
					return payType;
				}
				set	
				{
					payType = value;
				}
			}

			public string CreatedTime
			{
				get
				{
					return createdTime;
				}
				set	
				{
					createdTime = value;
				}
			}

			public string ExpireTime
			{
				get
				{
					return expireTime;
				}
				set	
				{
					expireTime = value;
				}
			}

			public string MajorVersion
			{
				get
				{
					return majorVersion;
				}
				set	
				{
					majorVersion = value;
				}
			}

			public string MinorVersion
			{
				get
				{
					return minorVersion;
				}
				set	
				{
					minorVersion = value;
				}
			}

			public int? DataCenterCount
			{
				get
				{
					return dataCenterCount;
				}
				set	
				{
					dataCenterCount = value;
				}
			}

			public string LockMode
			{
				get
				{
					return lockMode;
				}
				set	
				{
					lockMode = value;
				}
			}

			public bool? AutoRenewal
			{
				get
				{
					return autoRenewal;
				}
				set	
				{
					autoRenewal = value;
				}
			}

			public int? AutoRenewPeriod
			{
				get
				{
					return autoRenewPeriod;
				}
				set	
				{
					autoRenewPeriod = value;
				}
			}

			public List<DescribeClusters_Tag> Tags
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

			public class DescribeClusters_Tag
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
		}
	}
}
