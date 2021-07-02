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
    public class ExportConnectionsResponseUnmarshaller
    {
        public static ExportConnectionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExportConnectionsResponse exportConnectionsResponse = new ExportConnectionsResponse();

			exportConnectionsResponse.HttpResponse = _ctx.HttpResponse;
			exportConnectionsResponse.HttpStatusCode = _ctx.IntegerValue("ExportConnections.HttpStatusCode");
			exportConnectionsResponse.Success = _ctx.BooleanValue("ExportConnections.Success");
			exportConnectionsResponse.RequestId = _ctx.StringValue("ExportConnections.RequestId");

			ExportConnectionsResponse.ExportConnections_Data data = new ExportConnectionsResponse.ExportConnections_Data();
			data.PageNumber = _ctx.IntegerValue("ExportConnections.Data.PageNumber");
			data.PageSize = _ctx.IntegerValue("ExportConnections.Data.PageSize");
			data.TotalCount = _ctx.IntegerValue("ExportConnections.Data.TotalCount");

			List<ExportConnectionsResponse.ExportConnections_Data.ExportConnections_DataSourcesItem> data_dataSources = new List<ExportConnectionsResponse.ExportConnections_Data.ExportConnections_DataSourcesItem>();
			for (int i = 0; i < _ctx.Length("ExportConnections.Data.DataSources.Length"); i++) {
				ExportConnectionsResponse.ExportConnections_Data.ExportConnections_DataSourcesItem dataSourcesItem = new ExportConnectionsResponse.ExportConnections_Data.ExportConnections_DataSourcesItem();
				dataSourcesItem.Shared = _ctx.BooleanValue("ExportConnections.Data.DataSources["+ i +"].Shared");
				dataSourcesItem.GmtModified = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].GmtModified");
				dataSourcesItem.ConnectStatus = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].ConnectStatus");
				dataSourcesItem.BindingCalcEngineId = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].BindingCalcEngineId");
				dataSourcesItem.Description = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].Description");
				dataSourcesItem.DataSourceType = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].DataSourceType");
				dataSourcesItem.GmtCreate = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].GmtCreate");
				dataSourcesItem.DefaultEngine = _ctx.BooleanValue("ExportConnections.Data.DataSources["+ i +"].DefaultEngine");
				dataSourcesItem._Operator = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].Operator");
				dataSourcesItem.Sequence = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].Sequence");
				dataSourcesItem.EnvType = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].EnvType");
				dataSourcesItem.TenantId = _ctx.LongValue("ExportConnections.Data.DataSources["+ i +"].TenantId");
				dataSourcesItem.Name = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].Name");
				dataSourcesItem.SubType = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].SubType");
				dataSourcesItem.Id = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].Id");
				dataSourcesItem.ProjectId = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].ProjectId");
				dataSourcesItem.Status = _ctx.IntegerValue("ExportConnections.Data.DataSources["+ i +"].Status");
				dataSourcesItem.Content = _ctx.StringValue("ExportConnections.Data.DataSources["+ i +"].Content");

				data_dataSources.Add(dataSourcesItem);
			}
			data.DataSources = data_dataSources;
			exportConnectionsResponse.Data = data;
        
			return exportConnectionsResponse;
        }
    }
}
