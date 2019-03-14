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
    public class MetastoreDescribeKafkaConsumerGroupResponseUnmarshaller
    {
        public static MetastoreDescribeKafkaConsumerGroupResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreDescribeKafkaConsumerGroupResponse metastoreDescribeKafkaConsumerGroupResponse = new MetastoreDescribeKafkaConsumerGroupResponse();

			metastoreDescribeKafkaConsumerGroupResponse.HttpResponse = context.HttpResponse;
			metastoreDescribeKafkaConsumerGroupResponse.RequestId = context.StringValue("MetastoreDescribeKafkaConsumerGroup.RequestId");
			metastoreDescribeKafkaConsumerGroupResponse.Id = context.StringValue("MetastoreDescribeKafkaConsumerGroup.Id");
			metastoreDescribeKafkaConsumerGroupResponse.DataSourceId = context.StringValue("MetastoreDescribeKafkaConsumerGroup.DataSourceId");
			metastoreDescribeKafkaConsumerGroupResponse.ConsumerGroup = context.StringValue("MetastoreDescribeKafkaConsumerGroup.ConsumerGroup");
			metastoreDescribeKafkaConsumerGroupResponse.ConsumerType = context.StringValue("MetastoreDescribeKafkaConsumerGroup.ConsumerType");
			metastoreDescribeKafkaConsumerGroupResponse.TotalLag = context.LongValue("MetastoreDescribeKafkaConsumerGroup.TotalLag");
			metastoreDescribeKafkaConsumerGroupResponse.PartitionProportion = context.StringValue("MetastoreDescribeKafkaConsumerGroup.PartitionProportion");
			metastoreDescribeKafkaConsumerGroupResponse.GmtCreate = context.LongValue("MetastoreDescribeKafkaConsumerGroup.GmtCreate");
			metastoreDescribeKafkaConsumerGroupResponse.GmtModified = context.LongValue("MetastoreDescribeKafkaConsumerGroup.GmtModified");

			List<MetastoreDescribeKafkaConsumerGroupResponse.MetastoreDescribeKafkaConsumerGroup_Partition> metastoreDescribeKafkaConsumerGroupResponse_partitionList = new List<MetastoreDescribeKafkaConsumerGroupResponse.MetastoreDescribeKafkaConsumerGroup_Partition>();
			for (int i = 0; i < context.Length("MetastoreDescribeKafkaConsumerGroup.PartitionList.Length"); i++) {
				MetastoreDescribeKafkaConsumerGroupResponse.MetastoreDescribeKafkaConsumerGroup_Partition partition = new MetastoreDescribeKafkaConsumerGroupResponse.MetastoreDescribeKafkaConsumerGroup_Partition();
				partition.DataSourceId = context.StringValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].DataSourceId");
				partition.ConsumerGroupId = context.StringValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].ConsumerGroupId");
				partition.PartitionId = context.IntegerValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].PartitionId");
				partition.ConsumerOffset = context.LongValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].ConsumerOffset");
				partition.LogEndOffset = context.LongValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].LogEndOffset");
				partition.Lag = context.LongValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].Lag");
				partition.ConsumerInstanceOwner = context.StringValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].ConsumerInstanceOwner");
				partition.GmtCreate = context.LongValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].GmtCreate");
				partition.GmtModified = context.LongValue("MetastoreDescribeKafkaConsumerGroup.PartitionList["+ i +"].GmtModified");

				metastoreDescribeKafkaConsumerGroupResponse_partitionList.Add(partition);
			}
			metastoreDescribeKafkaConsumerGroupResponse.PartitionList = metastoreDescribeKafkaConsumerGroupResponse_partitionList;
        
			return metastoreDescribeKafkaConsumerGroupResponse;
        }
    }
}
