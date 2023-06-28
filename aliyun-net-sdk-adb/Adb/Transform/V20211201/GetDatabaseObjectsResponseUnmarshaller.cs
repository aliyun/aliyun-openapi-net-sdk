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
    public class GetDatabaseObjectsResponseUnmarshaller
    {
        public static GetDatabaseObjectsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDatabaseObjectsResponse getDatabaseObjectsResponse = new GetDatabaseObjectsResponse();

			getDatabaseObjectsResponse.HttpResponse = _ctx.HttpResponse;
			getDatabaseObjectsResponse.RequestId = _ctx.StringValue("GetDatabaseObjects.RequestId");
			getDatabaseObjectsResponse.PageNumber = _ctx.LongValue("GetDatabaseObjects.PageNumber");
			getDatabaseObjectsResponse.PageSize = _ctx.LongValue("GetDatabaseObjects.PageSize");
			getDatabaseObjectsResponse.TotalCount = _ctx.LongValue("GetDatabaseObjects.TotalCount");

			GetDatabaseObjectsResponse.GetDatabaseObjects_Data data = new GetDatabaseObjectsResponse.GetDatabaseObjects_Data();
			data.PageNumber = _ctx.LongValue("GetDatabaseObjects.Data.PageNumber");
			data.PageSize = _ctx.LongValue("GetDatabaseObjects.Data.PageSize");
			data.TotalCount = _ctx.LongValue("GetDatabaseObjects.Data.TotalCount");

			List<GetDatabaseObjectsResponse.GetDatabaseObjects_Data.GetDatabaseObjects_DataObject> data_databaseSummaryModels = new List<GetDatabaseObjectsResponse.GetDatabaseObjects_Data.GetDatabaseObjects_DataObject>();
			for (int i = 0; i < _ctx.Length("GetDatabaseObjects.Data.DatabaseSummaryModels.Length"); i++) {
				GetDatabaseObjectsResponse.GetDatabaseObjects_Data.GetDatabaseObjects_DataObject dataObject = new GetDatabaseObjectsResponse.GetDatabaseObjects_Data.GetDatabaseObjects_DataObject();
				dataObject.Owner = _ctx.StringValue("GetDatabaseObjects.Data.DatabaseSummaryModels["+ i +"].Owner");
				dataObject.SchemaName = _ctx.StringValue("GetDatabaseObjects.Data.DatabaseSummaryModels["+ i +"].SchemaName");
				dataObject.Description = _ctx.StringValue("GetDatabaseObjects.Data.DatabaseSummaryModels["+ i +"].Description");
				dataObject.CreateTime = _ctx.StringValue("GetDatabaseObjects.Data.DatabaseSummaryModels["+ i +"].CreateTime");
				dataObject.UpdateTime = _ctx.StringValue("GetDatabaseObjects.Data.DatabaseSummaryModels["+ i +"].UpdateTime");

				data_databaseSummaryModels.Add(dataObject);
			}
			data.DatabaseSummaryModels = data_databaseSummaryModels;
			getDatabaseObjectsResponse.Data = data;
        
			return getDatabaseObjectsResponse;
        }
    }
}
