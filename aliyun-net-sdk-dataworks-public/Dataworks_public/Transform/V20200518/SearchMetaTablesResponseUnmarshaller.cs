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
    public class SearchMetaTablesResponseUnmarshaller
    {
        public static SearchMetaTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SearchMetaTablesResponse searchMetaTablesResponse = new SearchMetaTablesResponse();

			searchMetaTablesResponse.HttpResponse = _ctx.HttpResponse;
			searchMetaTablesResponse.RequestId = _ctx.StringValue("SearchMetaTables.RequestId");
			searchMetaTablesResponse.ErrorCode = _ctx.StringValue("SearchMetaTables.ErrorCode");
			searchMetaTablesResponse.ErrorMessage = _ctx.StringValue("SearchMetaTables.ErrorMessage");
			searchMetaTablesResponse.HttpStatusCode = _ctx.IntegerValue("SearchMetaTables.HttpStatusCode");
			searchMetaTablesResponse.Success = _ctx.BooleanValue("SearchMetaTables.Success");

			SearchMetaTablesResponse.SearchMetaTables_Data data = new SearchMetaTablesResponse.SearchMetaTables_Data();
			data.PageNumber = _ctx.IntegerValue("SearchMetaTables.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("SearchMetaTables.Data.PageSize");
			data.TotalCount = _ctx.LongValue("SearchMetaTables.Data.TotalCount");

			List<SearchMetaTablesResponse.SearchMetaTables_Data.SearchMetaTables_DataEntityListItem> data_dataEntityList = new List<SearchMetaTablesResponse.SearchMetaTables_Data.SearchMetaTables_DataEntityListItem>();
			for (int i = 0; i < _ctx.Length("SearchMetaTables.Data.DataEntityList.Length"); i++) {
				SearchMetaTablesResponse.SearchMetaTables_Data.SearchMetaTables_DataEntityListItem dataEntityListItem = new SearchMetaTablesResponse.SearchMetaTables_Data.SearchMetaTables_DataEntityListItem();
				dataEntityListItem.TableName = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].TableName");
				dataEntityListItem.TableGuid = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].TableGuid");
				dataEntityListItem.OwnerId = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].OwnerId");
				dataEntityListItem.TenantId = _ctx.LongValue("SearchMetaTables.Data.DataEntityList["+ i +"].TenantId");
				dataEntityListItem.EnvType = _ctx.IntegerValue("SearchMetaTables.Data.DataEntityList["+ i +"].EnvType");
				dataEntityListItem.EntityType = _ctx.IntegerValue("SearchMetaTables.Data.DataEntityList["+ i +"].EntityType");
				dataEntityListItem.ProjectId = _ctx.LongValue("SearchMetaTables.Data.DataEntityList["+ i +"].ProjectId");
				dataEntityListItem.ProjectName = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].ProjectName");
				dataEntityListItem.ClusterId = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].ClusterId");
				dataEntityListItem.DatabaseName = _ctx.StringValue("SearchMetaTables.Data.DataEntityList["+ i +"].DatabaseName");

				data_dataEntityList.Add(dataEntityListItem);
			}
			data.DataEntityList = data_dataEntityList;
			searchMetaTablesResponse.Data = data;
        
			return searchMetaTablesResponse;
        }
    }
}
