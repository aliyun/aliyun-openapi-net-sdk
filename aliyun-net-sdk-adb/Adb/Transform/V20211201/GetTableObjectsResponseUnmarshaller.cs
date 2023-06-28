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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class GetTableObjectsResponseUnmarshaller
    {
        public static GetTableObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTableObjectsResponse getTableObjectsResponse = new GetTableObjectsResponse();

			getTableObjectsResponse.HttpResponse = _ctx.HttpResponse;
			getTableObjectsResponse.RequestId = _ctx.StringValue("GetTableObjects.RequestId");
			getTableObjectsResponse.PageNumber = _ctx.LongValue("GetTableObjects.PageNumber");
			getTableObjectsResponse.PageSize = _ctx.LongValue("GetTableObjects.PageSize");
			getTableObjectsResponse.TotalCount = _ctx.LongValue("GetTableObjects.TotalCount");

			GetTableObjectsResponse.GetTableObjects_Data data = new GetTableObjectsResponse.GetTableObjects_Data();
			data.PageNumber = _ctx.LongValue("GetTableObjects.Data.PageNumber");
			data.PageSize = _ctx.LongValue("GetTableObjects.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetTableObjects.Data.TotalCount");

			List<GetTableObjectsResponse.GetTableObjects_Data.GetTableObjects_DataObject> data_tableSummaryModels = new List<GetTableObjectsResponse.GetTableObjects_Data.GetTableObjects_DataObject>();
			for (int i = 0; i < _ctx.Length("GetTableObjects.Data.TableSummaryModels.Length"); i++) {
				GetTableObjectsResponse.GetTableObjects_Data.GetTableObjects_DataObject dataObject = new GetTableObjectsResponse.GetTableObjects_Data.GetTableObjects_DataObject();
				dataObject.SchemaName = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].SchemaName");
				dataObject.TableName = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].TableName");
				dataObject.TableType = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].TableType");
				dataObject.TableSize = _ctx.LongValue("GetTableObjects.Data.TableSummaryModels["+ i +"].TableSize");
				dataObject.CreateTime = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].CreateTime");
				dataObject.UpdateTime = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].UpdateTime");
				dataObject.SQL = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].SQL");
				dataObject.Description = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].Description");
				dataObject.Owner = _ctx.StringValue("GetTableObjects.Data.TableSummaryModels["+ i +"].Owner");

				data_tableSummaryModels.Add(dataObject);
			}
			data.TableSummaryModels = data_tableSummaryModels;
			getTableObjectsResponse.Data = data;
        
			return getTableObjectsResponse;
        }
    }
}
