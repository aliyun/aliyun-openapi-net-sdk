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
	public class MetastoreDescribeKafkaConsumerGroupResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string dataSourceId;

		private string consumerGroup;

		private string consumerType;

		private long? totalLag;

		private string partitionProportion;

		private long? gmtCreate;

		private long? gmtModified;

		private List<MetastoreDescribeKafkaConsumerGroup_Partition> partitionList;

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

		public string DataSourceId
		{
			get
			{
				return dataSourceId;
			}
			set	
			{
				dataSourceId = value;
			}
		}

		public string ConsumerGroup
		{
			get
			{
				return consumerGroup;
			}
			set	
			{
				consumerGroup = value;
			}
		}

		public string ConsumerType
		{
			get
			{
				return consumerType;
			}
			set	
			{
				consumerType = value;
			}
		}

		public long? TotalLag
		{
			get
			{
				return totalLag;
			}
			set	
			{
				totalLag = value;
			}
		}

		public string PartitionProportion
		{
			get
			{
				return partitionProportion;
			}
			set	
			{
				partitionProportion = value;
			}
		}

		public long? GmtCreate
		{
			get
			{
				return gmtCreate;
			}
			set	
			{
				gmtCreate = value;
			}
		}

		public long? GmtModified
		{
			get
			{
				return gmtModified;
			}
			set	
			{
				gmtModified = value;
			}
		}

		public List<MetastoreDescribeKafkaConsumerGroup_Partition> PartitionList
		{
			get
			{
				return partitionList;
			}
			set	
			{
				partitionList = value;
			}
		}

		public class MetastoreDescribeKafkaConsumerGroup_Partition
		{

			private string dataSourceId;

			private string consumerGroupId;

			private int? partitionId;

			private long? consumerOffset;

			private long? logEndOffset;

			private long? lag;

			private string consumerInstanceOwner;

			private long? gmtCreate;

			private long? gmtModified;

			public string DataSourceId
			{
				get
				{
					return dataSourceId;
				}
				set	
				{
					dataSourceId = value;
				}
			}

			public string ConsumerGroupId
			{
				get
				{
					return consumerGroupId;
				}
				set	
				{
					consumerGroupId = value;
				}
			}

			public int? PartitionId
			{
				get
				{
					return partitionId;
				}
				set	
				{
					partitionId = value;
				}
			}

			public long? ConsumerOffset
			{
				get
				{
					return consumerOffset;
				}
				set	
				{
					consumerOffset = value;
				}
			}

			public long? LogEndOffset
			{
				get
				{
					return logEndOffset;
				}
				set	
				{
					logEndOffset = value;
				}
			}

			public long? Lag
			{
				get
				{
					return lag;
				}
				set	
				{
					lag = value;
				}
			}

			public string ConsumerInstanceOwner
			{
				get
				{
					return consumerInstanceOwner;
				}
				set	
				{
					consumerInstanceOwner = value;
				}
			}

			public long? GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public long? GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}
		}
	}
}
