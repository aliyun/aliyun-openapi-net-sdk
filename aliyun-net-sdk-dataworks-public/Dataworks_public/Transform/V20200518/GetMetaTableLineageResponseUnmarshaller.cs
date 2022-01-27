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
    public class GetMetaTableLineageResponseUnmarshaller
    {
        public static GetMetaTableLineageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMetaTableLineageResponse getMetaTableLineageResponse = new GetMetaTableLineageResponse();

			getMetaTableLineageResponse.HttpResponse = _ctx.HttpResponse;
			getMetaTableLineageResponse.HttpStatusCode = _ctx.IntegerValue("GetMetaTableLineage.HttpStatusCode");
			getMetaTableLineageResponse.ErrorMessage = _ctx.StringValue("GetMetaTableLineage.ErrorMessage");
			getMetaTableLineageResponse.RequestId = _ctx.StringValue("GetMetaTableLineage.RequestId");
			getMetaTableLineageResponse.Success = _ctx.BooleanValue("GetMetaTableLineage.Success");
			getMetaTableLineageResponse.ErrorCode = _ctx.StringValue("GetMetaTableLineage.ErrorCode");

			GetMetaTableLineageResponse.GetMetaTableLineage_Data data = new GetMetaTableLineageResponse.GetMetaTableLineage_Data();
			data.NextPrimaryKey = _ctx.StringValue("GetMetaTableLineage.Data.NextPrimaryKey");
			data.HasNext = _ctx.BooleanValue("GetMetaTableLineage.Data.HasNext");

			List<GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem> data_dataEntityList = new List<GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("GetMetaTableLineage.Data.DataEntityList.Length"); i++) {
				GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem dataEntityListItem = new GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem();
				dataEntityListItem.TableName = _ctx.StringValue("GetMetaTableLineage.Data.DataEntityList["+ i +"].TableName");
				dataEntityListItem.TableGuid = _ctx.StringValue("GetMetaTableLineage.Data.DataEntityList["+ i +"].TableGuid");
				dataEntityListItem.CreateTimestamp = _ctx.LongValue("GetMetaTableLineage.Data.DataEntityList["+ i +"].CreateTimestamp");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaTableLineageResponse.Data = data;
        
			return getMetaTableLineageResponse;
        }
    }
}
