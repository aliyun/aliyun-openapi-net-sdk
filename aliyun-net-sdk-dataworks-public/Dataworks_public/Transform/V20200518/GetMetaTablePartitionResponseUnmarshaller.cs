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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMetaTablePartitionResponseUnmarshaller
    {
        public static GetMetaTablePartitionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTablePartitionResponse getMetaTablePartitionResponse = new GetMetaTablePartitionResponse();

			getMetaTablePartitionResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTablePartitionResponse.RequestId = _ctx.StringValue("GetMetaTablePartition.RequestId");
			getMetaTablePartitionResponse.ErrorCode = _ctx.StringValue("GetMetaTablePartition.ErrorCode");
			getMetaTablePartitionResponse.ErrorMessage = _ctx.StringValue("GetMetaTablePartition.ErrorMessage");
			getMetaTablePartitionResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTablePartition.HttpStatusCode");
			getMetaTablePartitionResponse.Success = _ctx.BooleanValue("GetMetaTablePartition.Success");

			GetMetaTablePartitionResponse.GetMetaTablePartition_Data data = new GetMetaTablePartitionResponse.GetMetaTablePartition_Data();
			data.PageNumber = _ctx.IntegerValue("GetMetaTablePartition.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("GetMetaTablePartition.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetMetaTablePartition.Data.TotalCount");

			List<GetMetaTablePartitionResponse.GetMetaTablePartition_Data.GetMetaTablePartition_DataEntityListItem> data_dataEntityList = new List<GetMetaTablePartitionResponse.GetMetaTablePartition_Data.GetMetaTablePartition_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTablePartition.Data.DataEntityList.Length"); i++) {
				GetMetaTablePartitionResponse.GetMetaTablePartition_Data.GetMetaTablePartition_DataEntityListItem dataEntityListItem = new GetMetaTablePartitionResponse.GetMetaTablePartition_Data.GetMetaTablePartition_DataEntityListItem();
				dataEntityListItem.PartitionGuid = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].PartitionGuid");
				dataEntityListItem.PartitionName = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].PartitionName");
				dataEntityListItem.CreateTime = _ctx.LongValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].CreateTime");
				dataEntityListItem.DataSize = _ctx.LongValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].DataSize");
				dataEntityListItem.RecordCount = _ctx.LongValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].RecordCount");
				dataEntityListItem.ModifiedTime = _ctx.LongValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].ModifiedTime");
				dataEntityListItem.TableGuid = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].TableGuid");
				dataEntityListItem.Comment = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].Comment");
				dataEntityListItem.PartitionType = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].PartitionType");
				dataEntityListItem.PartitionPath = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].PartitionPath");
				dataEntityListItem.PartitionLocation = _ctx.StringValue("GetMetaTablePartition.Data.DataEntityList["+ i +"].PartitionLocation");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaTablePartitionResponse.Data = data;
        
			return getMetaTablePartitionResponse;
        }
    }
}
