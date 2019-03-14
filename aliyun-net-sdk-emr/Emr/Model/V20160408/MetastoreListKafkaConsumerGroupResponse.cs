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
	public class MetastoreListKafkaConsumerGroupResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<MetastoreListKafkaConsumerGroup_ConsumerGroup> consumerGroupList;

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

		public List<MetastoreListKafkaConsumerGroup_ConsumerGroup> ConsumerGroupList
		{
			get
			{
				return consumerGroupList;
			}
			set	
			{
				consumerGroupList = value;
			}
		}

		public class MetastoreListKafkaConsumerGroup_ConsumerGroup
		{

			private string id;

			private string dataSourceId;

			private string consumerGroup;

			private string consumerType;

			private long? totalLag;

			private long? gmtCreate;

			private long? gmtModified;

			private string partitionProportion;

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
		}
	}
}
