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
    public class MetastoreListKafkaConsumerGroupResponseUnmarshaller
    {
        public static MetastoreListKafkaConsumerGroupResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListKafkaConsumerGroupResponse metastoreListKafkaConsumerGroupResponse = new MetastoreListKafkaConsumerGroupResponse();

			metastoreListKafkaConsumerGroupResponse.HttpResponse = context.HttpResponse;
			metastoreListKafkaConsumerGroupResponse.RequestId = context.StringValue("MetastoreListKafkaConsumerGroup.RequestId");
			metastoreListKafkaConsumerGroupResponse.TotalCount = context.IntegerValue("MetastoreListKafkaConsumerGroup.TotalCount");
			metastoreListKafkaConsumerGroupResponse.PageNumber = context.IntegerValue("MetastoreListKafkaConsumerGroup.PageNumber");
			metastoreListKafkaConsumerGroupResponse.PageSize = context.IntegerValue("MetastoreListKafkaConsumerGroup.PageSize");

			List<MetastoreListKafkaConsumerGroupResponse.MetastoreListKafkaConsumerGroup_ConsumerGroup> metastoreListKafkaConsumerGroupResponse_consumerGroupList = new List<MetastoreListKafkaConsumerGroupResponse.MetastoreListKafkaConsumerGroup_ConsumerGroup>();
			for (int i = 0; i < context.Length("MetastoreListKafkaConsumerGroup.ConsumerGroupList.Length"); i++) {
				MetastoreListKafkaConsumerGroupResponse.MetastoreListKafkaConsumerGroup_ConsumerGroup consumerGroup = new MetastoreListKafkaConsumerGroupResponse.MetastoreListKafkaConsumerGroup_ConsumerGroup();
				consumerGroup.Id = context.StringValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].Id");
				consumerGroup.DataSourceId = context.StringValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].DataSourceId");
				consumerGroup.ConsumerGroup = context.StringValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].ConsumerGroup");
				consumerGroup.ConsumerType = context.StringValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].ConsumerType");
				consumerGroup.TotalLag = context.LongValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].TotalLag");
				consumerGroup.GmtCreate = context.LongValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].GmtCreate");
				consumerGroup.GmtModified = context.LongValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].GmtModified");
				consumerGroup.PartitionProportion = context.StringValue("MetastoreListKafkaConsumerGroup.ConsumerGroupList["+ i +"].PartitionProportion");

				metastoreListKafkaConsumerGroupResponse_consumerGroupList.Add(consumerGroup);
			}
			metastoreListKafkaConsumerGroupResponse.ConsumerGroupList = metastoreListKafkaConsumerGroupResponse_consumerGroupList;
        
			return metastoreListKafkaConsumerGroupResponse;
        }
    }
}
