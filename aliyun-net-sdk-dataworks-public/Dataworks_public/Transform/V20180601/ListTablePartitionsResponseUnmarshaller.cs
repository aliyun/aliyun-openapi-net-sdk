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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class ListTablePartitionsResponseUnmarshaller
    {
        public static ListTablePartitionsResponse Unmarshall(UnmarshallerContext context)
        {
			ListTablePartitionsResponse listTablePartitionsResponse = new ListTablePartitionsResponse();

			listTablePartitionsResponse.HttpResponse = context.HttpResponse;
			listTablePartitionsResponse.ErrorCode = context.StringValue("ListTablePartitions.ErrorCode");
			listTablePartitionsResponse.ErrorMessage = context.StringValue("ListTablePartitions.ErrorMessage");
			listTablePartitionsResponse.RequestId = context.StringValue("ListTablePartitions.RequestId");

			ListTablePartitionsResponse.ListTablePartitions_Data data = new ListTablePartitionsResponse.ListTablePartitions_Data();
			data.PageSize = context.IntegerValue("ListTablePartitions.Data.PageSize");
			data.TotalCount = context.IntegerValue("ListTablePartitions.Data.TotalCount");

			List<ListTablePartitionsResponse.ListTablePartitions_Data.ListTablePartitions_TablePartitions> data_pagedData = new List<ListTablePartitionsResponse.ListTablePartitions_Data.ListTablePartitions_TablePartitions>();
			for (int i = 0; i < context.Length("ListTablePartitions.Data.PagedData.Length"); i++) {
				ListTablePartitionsResponse.ListTablePartitions_Data.ListTablePartitions_TablePartitions tablePartitions = new ListTablePartitionsResponse.ListTablePartitions_Data.ListTablePartitions_TablePartitions();
				tablePartitions.GmtCreate = context.LongValue("ListTablePartitions.Data.PagedData["+ i +"].GmtCreate");
				tablePartitions.GmtModified = context.LongValue("ListTablePartitions.Data.PagedData["+ i +"].GmtModified");
				tablePartitions.Location = context.StringValue("ListTablePartitions.Data.PagedData["+ i +"].Location");
				tablePartitions.PartitionName = context.StringValue("ListTablePartitions.Data.PagedData["+ i +"].PartitionName");
				tablePartitions.PartitionPath = context.StringValue("ListTablePartitions.Data.PagedData["+ i +"].PartitionPath");
				tablePartitions.PartitionType = context.StringValue("ListTablePartitions.Data.PagedData["+ i +"].PartitionType");
				tablePartitions.PartitionComment = context.StringValue("ListTablePartitions.Data.PagedData["+ i +"].PartitionComment");

				data_pagedData.Add(tablePartitions);
			}
			data.PagedData = data_pagedData;
			listTablePartitionsResponse.Data = data;
        
			return listTablePartitionsResponse;
        }
    }
}
