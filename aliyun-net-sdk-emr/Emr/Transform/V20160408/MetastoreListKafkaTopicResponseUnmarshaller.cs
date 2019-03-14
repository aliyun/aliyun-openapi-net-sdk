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
    public class MetastoreListKafkaTopicResponseUnmarshaller
    {
        public static MetastoreListKafkaTopicResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListKafkaTopicResponse metastoreListKafkaTopicResponse = new MetastoreListKafkaTopicResponse();

			metastoreListKafkaTopicResponse.HttpResponse = context.HttpResponse;
			metastoreListKafkaTopicResponse.RequestId = context.StringValue("MetastoreListKafkaTopic.RequestId");
			metastoreListKafkaTopicResponse.TotalCount = context.IntegerValue("MetastoreListKafkaTopic.TotalCount");
			metastoreListKafkaTopicResponse.PageNumber = context.IntegerValue("MetastoreListKafkaTopic.PageNumber");
			metastoreListKafkaTopicResponse.PageSize = context.IntegerValue("MetastoreListKafkaTopic.PageSize");

			List<MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic> metastoreListKafkaTopicResponse_topicList = new List<MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic>();
			for (int i = 0; i < context.Length("MetastoreListKafkaTopic.TopicList.Length"); i++) {
				MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic topic = new MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic();
				topic.Id = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].Id");
				topic.DataSourceId = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].DataSourceId");
				topic.TopicName = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].TopicName");
				topic.NumPartitions = context.IntegerValue("MetastoreListKafkaTopic.TopicList["+ i +"].NumPartitions");
				topic.ReplicationFactor = context.IntegerValue("MetastoreListKafkaTopic.TopicList["+ i +"].ReplicationFactor");
				topic.GmtCreate = context.LongValue("MetastoreListKafkaTopic.TopicList["+ i +"].GmtCreate");
				topic.GmtModified = context.LongValue("MetastoreListKafkaTopic.TopicList["+ i +"].GmtModified");

				MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_Cluster cluster = new MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_Cluster();
				cluster.ClusterBizId = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].Cluster.ClusterBizId");
				cluster.ClusterName = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].Cluster.ClusterName");
				cluster.ClusterStatus = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].Cluster.ClusterStatus");
				topic.Cluster = cluster;

				List<MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_AdvancedConfig> topic_advancedConfigList = new List<MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_AdvancedConfig>();
				for (int j = 0; j < context.Length("MetastoreListKafkaTopic.TopicList["+ i +"].AdvancedConfigList.Length"); j++) {
					MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_AdvancedConfig advancedConfig = new MetastoreListKafkaTopicResponse.MetastoreListKafkaTopic_Topic.MetastoreListKafkaTopic_AdvancedConfig();
					advancedConfig.Key = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].AdvancedConfigList["+ j +"].Key");
					advancedConfig._Value = context.StringValue("MetastoreListKafkaTopic.TopicList["+ i +"].AdvancedConfigList["+ j +"].Value");

					topic_advancedConfigList.Add(advancedConfig);
				}
				topic.AdvancedConfigList = topic_advancedConfigList;

				metastoreListKafkaTopicResponse_topicList.Add(topic);
			}
			metastoreListKafkaTopicResponse.TopicList = metastoreListKafkaTopicResponse_topicList;
        
			return metastoreListKafkaTopicResponse;
        }
    }
}
