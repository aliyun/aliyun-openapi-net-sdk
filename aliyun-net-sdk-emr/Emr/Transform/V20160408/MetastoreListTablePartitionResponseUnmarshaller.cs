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
    public class MetastoreListTablePartitionResponseUnmarshaller
    {
        public static MetastoreListTablePartitionResponse Unmarshall(UnmarshallerContext context)
        {
			MetastoreListTablePartitionResponse metastoreListTablePartitionResponse = new MetastoreListTablePartitionResponse();

			metastoreListTablePartitionResponse.HttpResponse = context.HttpResponse;
			metastoreListTablePartitionResponse.RequestId = context.StringValue("MetastoreListTablePartition.RequestId");
			metastoreListTablePartitionResponse.TotalCount = context.IntegerValue("MetastoreListTablePartition.TotalCount");
			metastoreListTablePartitionResponse.PageNumber = context.IntegerValue("MetastoreListTablePartition.PageNumber");
			metastoreListTablePartitionResponse.PageSize = context.IntegerValue("MetastoreListTablePartition.PageSize");

			List<MetastoreListTablePartitionResponse.MetastoreListTablePartition_Partition> metastoreListTablePartitionResponse_partitionList = new List<MetastoreListTablePartitionResponse.MetastoreListTablePartition_Partition>();
			for (int i = 0; i < context.Length("MetastoreListTablePartition.PartitionList.Length"); i++) {
				MetastoreListTablePartitionResponse.MetastoreListTablePartition_Partition partition = new MetastoreListTablePartitionResponse.MetastoreListTablePartition_Partition();
				partition.DatabaseId = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].DatabaseId");
				partition.TableId = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].TableId");
				partition.PartitionName = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].PartitionName");
				partition.PartitionType = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].PartitionType");
				partition.PartitionComment = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].PartitionComment");
				partition.Location = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].Location");
				partition.PartitionPath = context.StringValue("MetastoreListTablePartition.PartitionList["+ i +"].PartitionPath");
				partition.BucketNum = context.IntegerValue("MetastoreListTablePartition.PartitionList["+ i +"].BucketNum");
				partition.GmtCreate = context.LongValue("MetastoreListTablePartition.PartitionList["+ i +"].GmtCreate");
				partition.GmtModified = context.LongValue("MetastoreListTablePartition.PartitionList["+ i +"].GmtModified");

				metastoreListTablePartitionResponse_partitionList.Add(partition);
			}
			metastoreListTablePartitionResponse.PartitionList = metastoreListTablePartitionResponse_partitionList;
        
			return metastoreListTablePartitionResponse;
        }
    }
}
