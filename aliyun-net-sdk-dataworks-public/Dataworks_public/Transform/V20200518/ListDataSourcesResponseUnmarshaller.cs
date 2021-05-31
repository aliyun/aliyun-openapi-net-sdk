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
    public class ListDataSourcesResponseUnmarshaller
    {
        public static ListDataSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourcesResponse listDataSourcesResponse = new ListDataSourcesResponse();

			listDataSourcesResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourcesResponse.HttpStatusCode = _ctx.IntegerValue("ListDataSources.HttpStatusCode");
			listDataSourcesResponse.Success = _ctx.BooleanValue("ListDataSources.Success");
			listDataSourcesResponse.RequestId = _ctx.StringValue("ListDataSources.RequestId");

			ListDataSourcesResponse.ListDataSources_Data data = new ListDataSourcesResponse.ListDataSources_Data();
			data.PageNumber = _ctx.IntegerValue("ListDataSources.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ListDataSources.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ListDataSources.Data.TotalCount");

			List<ListDataSourcesResponse.ListDataSources_Data.ListDataSources_DataSourcesItem> data_dataSources = new List<ListDataSourcesResponse.ListDataSources_Data.ListDataSources_DataSourcesItem>();
			for (int i = 0; i < _ctx.Length("ListDataSources.Data.DataSources.Length"); i++) {
				ListDataSourcesResponse.ListDataSources_Data.ListDataSources_DataSourcesItem dataSourcesItem = new ListDataSourcesResponse.ListDataSources_Data.ListDataSources_DataSourcesItem();
				dataSourcesItem.Shared = _ctx.BooleanValue("ListDataSources.Data.DataSources["+ i +"].Shared");
				dataSourcesItem.GmtModified = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].GmtModified");
				dataSourcesItem.ConnectStatus = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].ConnectStatus");
				dataSourcesItem.BindingCalcEngineId = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].BindingCalcEngineId");
				dataSourcesItem.Description = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].Description");
				dataSourcesItem.DataSourceType = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].DataSourceType");
				dataSourcesItem.GmtCreate = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].GmtCreate");
				dataSourcesItem.DefaultEngine = _ctx.BooleanValue("ListDataSources.Data.DataSources["+ i +"].DefaultEngine");
				dataSourcesItem._Operator = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].Operator");
				dataSourcesItem.Sequence = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].Sequence");
				dataSourcesItem.EnvType = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].EnvType");
				dataSourcesItem.TenantId = _ctx.LongValue("ListDataSources.Data.DataSources["+ i +"].TenantId");
				dataSourcesItem.Name = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].Name");
				dataSourcesItem.SubType = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].SubType");
				dataSourcesItem.Id = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].Id");
				dataSourcesItem.ProjectId = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].ProjectId");
				dataSourcesItem.Status = _ctx.IntegerValue("ListDataSources.Data.DataSources["+ i +"].Status");
				dataSourcesItem.Content = _ctx.StringValue("ListDataSources.Data.DataSources["+ i +"].Content");

				data_dataSources.Add(dataSourcesItem);
			}
			data.DataSources = data_dataSources;
			listDataSourcesResponse.Data = data;
        
			return listDataSourcesResponse;
        }
    }
}
