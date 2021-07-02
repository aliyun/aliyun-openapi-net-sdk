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
    public class ExportDataSourcesResponseUnmarshaller
    {
        public static ExportDataSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExportDataSourcesResponse exportDataSourcesResponse = new ExportDataSourcesResponse();

			exportDataSourcesResponse.HttpResponse = _ctx.HttpResponse;
			exportDataSourcesResponse.HttpStatusCode = _ctx.IntegerValue("ExportDataSources.HttpStatusCode");
			exportDataSourcesResponse.Success = _ctx.BooleanValue("ExportDataSources.Success");
			exportDataSourcesResponse.RequestId = _ctx.StringValue("ExportDataSources.RequestId");

			ExportDataSourcesResponse.ExportDataSources_Data data = new ExportDataSourcesResponse.ExportDataSources_Data();
			data.PageNumber = _ctx.IntegerValue("ExportDataSources.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ExportDataSources.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ExportDataSources.Data.TotalCount");

			List<ExportDataSourcesResponse.ExportDataSources_Data.ExportDataSources_DataSourcesItem> data_dataSources = new List<ExportDataSourcesResponse.ExportDataSources_Data.ExportDataSources_DataSourcesItem>();
			for (int i = 0; i < _ctx.Length("ExportDataSources.Data.DataSources.Length"); i++) {
				ExportDataSourcesResponse.ExportDataSources_Data.ExportDataSources_DataSourcesItem dataSourcesItem = new ExportDataSourcesResponse.ExportDataSources_Data.ExportDataSources_DataSourcesItem();
				dataSourcesItem.Shared = _ctx.BooleanValue("ExportDataSources.Data.DataSources["+ i +"].Shared");
				dataSourcesItem.GmtModified = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].GmtModified");
				dataSourcesItem.ConnectStatus = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].ConnectStatus");
				dataSourcesItem.BindingCalcEngineId = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].BindingCalcEngineId");
				dataSourcesItem.Description = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].Description");
				dataSourcesItem.DataSourceType = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].DataSourceType");
				dataSourcesItem.GmtCreate = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].GmtCreate");
				dataSourcesItem.DefaultEngine = _ctx.BooleanValue("ExportDataSources.Data.DataSources["+ i +"].DefaultEngine");
				dataSourcesItem._Operator = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].Operator");
				dataSourcesItem.Sequence = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].Sequence");
				dataSourcesItem.EnvType = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].EnvType");
				dataSourcesItem.TenantId = _ctx.LongValue("ExportDataSources.Data.DataSources["+ i +"].TenantId");
				dataSourcesItem.Name = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].Name");
				dataSourcesItem.SubType = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].SubType");
				dataSourcesItem.Id = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].Id");
				dataSourcesItem.ProjectId = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].ProjectId");
				dataSourcesItem.Status = _ctx.IntegerValue("ExportDataSources.Data.DataSources["+ i +"].Status");
				dataSourcesItem.Content = _ctx.StringValue("ExportDataSources.Data.DataSources["+ i +"].Content");

				data_dataSources.Add(dataSourcesItem);
			}
			data.DataSources = data_dataSources;
			exportDataSourcesResponse.Data = data;
        
			return exportDataSourcesResponse;
        }
    }
}
