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
    public class GetMetaColumnLineageResponseUnmarshaller
    {
        public static GetMetaColumnLineageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaColumnLineageResponse getMetaColumnLineageResponse = new GetMetaColumnLineageResponse();

			getMetaColumnLineageResponse.HttpResponse = _ctx.HttpResponse;
			getMetaColumnLineageResponse.RequestId = _ctx.StringValue("GetMetaColumnLineage.RequestId");
			getMetaColumnLineageResponse.ErrorCode = _ctx.StringValue("GetMetaColumnLineage.ErrorCode");
			getMetaColumnLineageResponse.ErrorMessage = _ctx.StringValue("GetMetaColumnLineage.ErrorMessage");
			getMetaColumnLineageResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaColumnLineage.HttpStatusCode");
			getMetaColumnLineageResponse.Success = _ctx.BooleanValue("GetMetaColumnLineage.Success");

			GetMetaColumnLineageResponse.GetMetaColumnLineage_Data data = new GetMetaColumnLineageResponse.GetMetaColumnLineage_Data();
			data.TotalCount = _ctx.LongValue("GetMetaColumnLineage.Data.TotalCount");
			data.PageNum = _ctx.IntegerValue("GetMetaColumnLineage.Data.PageNum");
			data.PageSize = _ctx.IntegerValue("GetMetaColumnLineage.Data.PageSize");

			List<GetMetaColumnLineageResponse.GetMetaColumnLineage_Data.GetMetaColumnLineage_DataEntityListItem> data_dataEntityList = new List<GetMetaColumnLineageResponse.GetMetaColumnLineage_Data.GetMetaColumnLineage_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaColumnLineage.Data.DataEntityList.Length"); i++) {
				GetMetaColumnLineageResponse.GetMetaColumnLineage_Data.GetMetaColumnLineage_DataEntityListItem dataEntityListItem = new GetMetaColumnLineageResponse.GetMetaColumnLineage_Data.GetMetaColumnLineage_DataEntityListItem();
				dataEntityListItem.ColumnName = _ctx.StringValue("GetMetaColumnLineage.Data.DataEntityList["+ i +"].ColumnName");
				dataEntityListItem.ColumnGuid = _ctx.StringValue("GetMetaColumnLineage.Data.DataEntityList["+ i +"].ColumnGuid");
				dataEntityListItem.ClusterId = _ctx.StringValue("GetMetaColumnLineage.Data.DataEntityList["+ i +"].ClusterId");
				dataEntityListItem.DatabaseName = _ctx.StringValue("GetMetaColumnLineage.Data.DataEntityList["+ i +"].DatabaseName");
				dataEntityListItem.TableName = _ctx.StringValue("GetMetaColumnLineage.Data.DataEntityList["+ i +"].TableName");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaColumnLineageResponse.Data = data;
        
			return getMetaColumnLineageResponse;
        }
    }
}
