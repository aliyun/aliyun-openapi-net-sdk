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
	public class MetastoreListKafkaTopicResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<MetastoreListKafkaTopic_Topic> topicList;

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

		public List<MetastoreListKafkaTopic_Topic> TopicList
		{
			get
			{
				return topicList;
			}
			set	
			{
				topicList = value;
			}
		}

		public class MetastoreListKafkaTopic_Topic
		{

			private string id;

			private string dataSourceId;

			private string topicName;

			private int? numPartitions;

			private int? replicationFactor;

			private long? gmtCreate;

			private long? gmtModified;

			private List<MetastoreListKafkaTopic_AdvancedConfig> advancedConfigList;

			private MetastoreListKafkaTopic_Cluster cluster;

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

			public string TopicName
			{
				get
				{
					return topicName;
				}
				set	
				{
					topicName = value;
				}
			}

			public int? NumPartitions
			{
				get
				{
					return numPartitions;
				}
				set	
				{
					numPartitions = value;
				}
			}

			public int? ReplicationFactor
			{
				get
				{
					return replicationFactor;
				}
				set	
				{
					replicationFactor = value;
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

			public List<MetastoreListKafkaTopic_AdvancedConfig> AdvancedConfigList
			{
				get
				{
					return advancedConfigList;
				}
				set	
				{
					advancedConfigList = value;
				}
			}

			public MetastoreListKafkaTopic_Cluster Cluster
			{
				get
				{
					return cluster;
				}
				set	
				{
					cluster = value;
				}
			}

			public class MetastoreListKafkaTopic_AdvancedConfig
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

			public class MetastoreListKafkaTopic_Cluster
			{

				private string clusterBizId;

				private string clusterName;

				private string clusterStatus;

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

				public string ClusterStatus
				{
					get
					{
						return clusterStatus;
					}
					set	
					{
						clusterStatus = value;
					}
				}
			}
		}
	}
}
