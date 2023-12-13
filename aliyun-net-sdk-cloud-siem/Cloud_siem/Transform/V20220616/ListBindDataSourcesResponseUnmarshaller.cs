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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class ListBindDataSourcesResponseUnmarshaller
    {
        public static ListBindDataSourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListBindDataSourcesResponse listBindDataSourcesResponse = new ListBindDataSourcesResponse();

			listBindDataSourcesResponse.HttpResponse = _ctx.HttpResponse;
			listBindDataSourcesResponse.RequestId = _ctx.StringValue("ListBindDataSources.RequestId");

			List<ListBindDataSourcesResponse.ListBindDataSources_DataItem> listBindDataSourcesResponse_data = new List<ListBindDataSourcesResponse.ListBindDataSources_DataItem>();
			for (int i = 0; i < _ctx.Length("ListBindDataSources.Data.Length"); i++) {
				ListBindDataSourcesResponse.ListBindDataSources_DataItem dataItem = new ListBindDataSourcesResponse.ListBindDataSources_DataItem();
				dataItem.AccountName = _ctx.StringValue("ListBindDataSources.Data["+ i +"].AccountName");
				dataItem.DataSourceInstanceId = _ctx.StringValue("ListBindDataSources.Data["+ i +"].DataSourceInstanceId");
				dataItem.DataSourceType = _ctx.StringValue("ListBindDataSources.Data["+ i +"].DataSourceType");
				dataItem.DataSourceName = _ctx.StringValue("ListBindDataSources.Data["+ i +"].DataSourceName");
				dataItem.DataSourceRemark = _ctx.StringValue("ListBindDataSources.Data["+ i +"].DataSourceRemark");
				dataItem.LogCount = _ctx.IntegerValue("ListBindDataSources.Data["+ i +"].LogCount");
				dataItem.TaskCount = _ctx.IntegerValue("ListBindDataSources.Data["+ i +"].TaskCount");
				dataItem.AccountId = _ctx.StringValue("ListBindDataSources.Data["+ i +"].AccountId");
				dataItem.CloudCode = _ctx.StringValue("ListBindDataSources.Data["+ i +"].CloudCode");

				listBindDataSourcesResponse_data.Add(dataItem);
			}
			listBindDataSourcesResponse.Data = listBindDataSourcesResponse_data;
        
			return listBindDataSourcesResponse;
        }
    }
}
