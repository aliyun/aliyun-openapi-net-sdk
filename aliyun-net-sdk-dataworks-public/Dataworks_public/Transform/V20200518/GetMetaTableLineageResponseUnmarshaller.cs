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
        public static GetMetaTableLineageResponse Unmarshall(UnmarshallerContext context)
        {
			GetMetaTableLineageResponse getMetaTableLineageResponse = new GetMetaTableLineageResponse();

			getMetaTableLineageResponse.HttpResponse = context.HttpResponse;
			getMetaTableLineageResponse.RequestId = context.StringValue("GetMetaTableLineage.RequestId");
			getMetaTableLineageResponse.ErrorCode = context.StringValue("GetMetaTableLineage.ErrorCode");
			getMetaTableLineageResponse.ErrorMessage = context.StringValue("GetMetaTableLineage.ErrorMessage");
			getMetaTableLineageResponse.HttpStatusCode = context.IntegerValue("GetMetaTableLineage.HttpStatusCode");
			getMetaTableLineageResponse.Success = context.BooleanValue("GetMetaTableLineage.Success");

			GetMetaTableLineageResponse.GetMetaTableLineage_Data data = new GetMetaTableLineageResponse.GetMetaTableLineage_Data();
			data.HasNext = context.BooleanValue("GetMetaTableLineage.Data.HasNext");
			data.NextPrimaryKey = context.StringValue("GetMetaTableLineage.Data.NextPrimaryKey");

			List<GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem> data_dataEntityList = new List<GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem>();
			for (int i = 0; i < context.Length("GetMetaTableLineage.Data.DataEntityList.Length"); i++) {
				GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem dataEntityListItem = new GetMetaTableLineageResponse.GetMetaTableLineage_Data.GetMetaTableLineage_DataEntityListItem();
				dataEntityListItem.TableName = context.StringValue("GetMetaTableLineage.Data.DataEntityList["+ i +"].TableName");
				dataEntityListItem.TableGuid = context.StringValue("GetMetaTableLineage.Data.DataEntityList["+ i +"].TableGuid");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			getMetaTableLineageResponse.Data = data;
        
			return getMetaTableLineageResponse;
        }
    }
}
