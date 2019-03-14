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
	public class MetastoreDescribeKafkaTopicResponse : AcsResponse
	{

		private string requestId;

		private string id;

		private string dataSourceId;

		private string topicName;

		private int? numPartitions;

		private int? replicationFactor;

		private long? gmtCreate;

		private long? gmtModified;

		private int? brokerTotal;

		private int? numUsingBrokers;

		private string brokersLeaderSkewPercentage;

		private string underReplicatedPercentage;

		private string preferredReplicasPercentage;

		private List<MetastoreDescribeKafkaTopic_AdvancedConfig> advancedConfigList;

		private List<MetastoreDescribeKafkaTopic_Summary> summaryList;

		private List<MetastoreDescribeKafkaTopic_Distribution> distributionList;

		private MetastoreDescribeKafkaTopic_Cluster cluster;

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

		public int? BrokerTotal
		{
			get
			{
				return brokerTotal;
			}
			set	
			{
				brokerTotal = value;
			}
		}

		public int? NumUsingBrokers
		{
			get
			{
				return numUsingBrokers;
			}
			set	
			{
				numUsingBrokers = value;
			}
		}

		public string BrokersLeaderSkewPercentage
		{
			get
			{
				return brokersLeaderSkewPercentage;
			}
			set	
			{
				brokersLeaderSkewPercentage = value;
			}
		}

		public string UnderReplicatedPercentage
		{
			get
			{
				return underReplicatedPercentage;
			}
			set	
			{
				underReplicatedPercentage = value;
			}
		}

		public string PreferredReplicasPercentage
		{
			get
			{
				return preferredReplicasPercentage;
			}
			set	
			{
				preferredReplicasPercentage = value;
			}
		}

		public List<MetastoreDescribeKafkaTopic_AdvancedConfig> AdvancedConfigList
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

		public List<MetastoreDescribeKafkaTopic_Summary> SummaryList
		{
			get
			{
				return summaryList;
			}
			set	
			{
				summaryList = value;
			}
		}

		public List<MetastoreDescribeKafkaTopic_Distribution> DistributionList
		{
			get
			{
				return distributionList;
			}
			set	
			{
				distributionList = value;
			}
		}

		public MetastoreDescribeKafkaTopic_Cluster Cluster
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

		public class MetastoreDescribeKafkaTopic_AdvancedConfig
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

		public class MetastoreDescribeKafkaTopic_Summary
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

		public class MetastoreDescribeKafkaTopic_Distribution
		{

			private int? partition;

			private long? offset;

			private int? leader;

			private bool? preferredLeader;

			private bool? underReplicated;

			private long? logEndOffset;

			private List<string> isrList;

			private List<string> replicaList;

			public int? Partition
			{
				get
				{
					return partition;
				}
				set	
				{
					partition = value;
				}
			}

			public long? Offset
			{
				get
				{
					return offset;
				}
				set	
				{
					offset = value;
				}
			}

			public int? Leader
			{
				get
				{
					return leader;
				}
				set	
				{
					leader = value;
				}
			}

			public bool? PreferredLeader
			{
				get
				{
					return preferredLeader;
				}
				set	
				{
					preferredLeader = value;
				}
			}

			public bool? UnderReplicated
			{
				get
				{
					return underReplicated;
				}
				set	
				{
					underReplicated = value;
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

			public List<string> IsrList
			{
				get
				{
					return isrList;
				}
				set	
				{
					isrList = value;
				}
			}

			public List<string> ReplicaList
			{
				get
				{
					return replicaList;
				}
				set	
				{
					replicaList = value;
				}
			}
		}

		public class MetastoreDescribeKafkaTopic_Cluster
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
