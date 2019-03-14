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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class MetastoreDescribeKafkaTopicResponseUnmarshaller
    {
        public static MetastoreDescribeKafkaTopicResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeKafkaTopicResponse metastoreDescribeKafkaTopicResponse = new MetastoreDescribeKafkaTopicResponse();

			metastoreDescribeKafkaTopicResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeKafkaTopicResponse.RequestId = context.StringValue("MetastoreDescribeKafkaTopic.RequestId");
			metastoreDescribeKafkaTopicResponse.Id = context.StringValue("MetastoreDescribeKafkaTopic.Id");
			metastoreDescribeKafkaTopicResponse.DataSourceId = context.StringValue("MetastoreDescribeKafkaTopic.DataSourceId");
			metastoreDescribeKafkaTopicResponse.TopicName = context.StringValue("MetastoreDescribeKafkaTopic.TopicName");
			metastoreDescribeKafkaTopicResponse.NumPartitions = context.IntegerValue("MetastoreDescribeKafkaTopic.NumPartitions");
			metastoreDescribeKafkaTopicResponse.ReplicationFactor = context.IntegerValue("MetastoreDescribeKafkaTopic.ReplicationFactor");
			metastoreDescribeKafkaTopicResponse.GmtCreate = context.LongValue("MetastoreDescribeKafkaTopic.GmtCreate");
			metastoreDescribeKafkaTopicResponse.GmtModified = context.LongValue("MetastoreDescribeKafkaTopic.GmtModified");
			metastoreDescribeKafkaTopicResponse.BrokerTotal = context.IntegerValue("MetastoreDescribeKafkaTopic.BrokerTotal");
			metastoreDescribeKafkaTopicResponse.NumUsingBrokers = context.IntegerValue("MetastoreDescribeKafkaTopic.NumUsingBrokers");
			metastoreDescribeKafkaTopicResponse.BrokersLeaderSkewPercentage = context.StringValue("MetastoreDescribeKafkaTopic.BrokersLeaderSkewPercentage");
			metastoreDescribeKafkaTopicResponse.UnderReplicatedPercentage = context.StringValue("MetastoreDescribeKafkaTopic.UnderReplicatedPercentage");
			metastoreDescribeKafkaTopicResponse.PreferredReplicasPercentage = context.StringValue("MetastoreDescribeKafkaTopic.PreferredReplicasPercentage");

			MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Cluster cluster = new MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Cluster();
			cluster.ClusterBizId = context.StringValue("MetastoreDescribeKafkaTopic.Cluster.ClusterBizId");
			cluster.ClusterName = context.StringValue("MetastoreDescribeKafkaTopic.Cluster.ClusterName");
			cluster.ClusterStatus = context.StringValue("MetastoreDescribeKafkaTopic.Cluster.ClusterStatus");
			metastoreDescribeKafkaTopicResponse.Cluster = cluster;

			List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_AdvancedConfig> metastoreDescribeKafkaTopicResponse_advancedConfigList = new List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_AdvancedConfig>();
			for (int i = 0; i < context.Length("MetastoreDescribeKafkaTopic.AdvancedConfigList.Length"); i++) {
				MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_AdvancedConfig advancedConfig = new MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_AdvancedConfig();
				advancedConfig.Key = context.StringValue("MetastoreDescribeKafkaTopic.AdvancedConfigList["+ i +"].Key");
				advancedConfig._Value = context.StringValue("MetastoreDescribeKafkaTopic.AdvancedConfigList["+ i +"].Value");

				metastoreDescribeKafkaTopicResponse_advancedConfigList.Add(advancedConfig);
			}
			metastoreDescribeKafkaTopicResponse.AdvancedConfigList = metastoreDescribeKafkaTopicResponse_advancedConfigList;

			List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Summary> metastoreDescribeKafkaTopicResponse_summaryList = new List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Summary>();
			for (int i = 0; i < context.Length("MetastoreDescribeKafkaTopic.SummaryList.Length"); i++) {
				MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Summary summary = new MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Summary();
				summary.Key = context.StringValue("MetastoreDescribeKafkaTopic.SummaryList["+ i +"].Key");
				summary._Value = context.StringValue("MetastoreDescribeKafkaTopic.SummaryList["+ i +"].Value");

				metastoreDescribeKafkaTopicResponse_summaryList.Add(summary);
			}
			metastoreDescribeKafkaTopicResponse.SummaryList = metastoreDescribeKafkaTopicResponse_summaryList;

			List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Distribution> metastoreDescribeKafkaTopicResponse_distributionList = new List<MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Distribution>();
			for (int i = 0; i < context.Length("MetastoreDescribeKafkaTopic.DistributionList.Length"); i++) {
				MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Distribution distribution = new MetastoreDescribeKafkaTopicResponse.MetastoreDescribeKafkaTopic_Distribution();
				distribution.Partition = context.IntegerValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].Partition");
				distribution.Offset = context.LongValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].Offset");
				distribution.Leader = context.IntegerValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].Leader");
				distribution.PreferredLeader = context.BooleanValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].PreferredLeader");
				distribution.UnderReplicated = context.BooleanValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].UnderReplicated");
				distribution.LogEndOffset = context.LongValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].LogEndOffset");

				List<string> distribution_isrList = new List<string>();
				for (int j = 0; j < context.Length("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].IsrList.Length"); j++) {
					distribution_isrList.Add(context.StringValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].IsrList["+ j +"]"));
				}
				distribution.IsrList = distribution_isrList;

				List<string> distribution_replicaList = new List<string>();
				for (int j = 0; j < context.Length("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].ReplicaList.Length"); j++) {
					distribution_replicaList.Add(context.StringValue("MetastoreDescribeKafkaTopic.DistributionList["+ i +"].ReplicaList["+ j +"]"));
				}
				distribution.ReplicaList = distribution_replicaList;

				metastoreDescribeKafkaTopicResponse_distributionList.Add(distribution);
			}
			metastoreDescribeKafkaTopicResponse.DistributionList = metastoreDescribeKafkaTopicResponse_distributionList;
        
			return metastoreDescribeKafkaTopicResponse;
        }
    }
}
