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
using Aliyun.Acs.PaiFeatureStore.Model.V20230621;

namespace Aliyun.Acs.PaiFeatureStore.Transform.V20230621
{
    public class ListDatasourcesResponseUnmarshaller
    {
        public static ListDatasourcesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDatasourcesResponse listDatasourcesResponse = new ListDatasourcesResponse();

			listDatasourcesResponse.HttpResponse = _ctx.HttpResponse;
			listDatasourcesResponse.RequestId = _ctx.StringValue("ListDatasources.RequestId");
			listDatasourcesResponse.TotalCount = _ctx.LongValue("ListDatasources.TotalCount");

			List<ListDatasourcesResponse.ListDatasources_DatasourcesItem> listDatasourcesResponse_datasources = new List<ListDatasourcesResponse.ListDatasources_DatasourcesItem>();
			for (int i = 0; i < _ctx.Length("ListDatasources.Datasources.Length"); i++) {
				ListDatasourcesResponse.ListDatasources_DatasourcesItem datasourcesItem = new ListDatasourcesResponse.ListDatasources_DatasourcesItem();
				datasourcesItem.DatasourceId = _ctx.StringValue("ListDatasources.Datasources["+ i +"].DatasourceId");
				datasourcesItem.Name = _ctx.StringValue("ListDatasources.Datasources["+ i +"].Name");
				datasourcesItem.Type = _ctx.StringValue("ListDatasources.Datasources["+ i +"].Type");
				datasourcesItem.Uri = _ctx.StringValue("ListDatasources.Datasources["+ i +"].Uri");
				datasourcesItem.Config = _ctx.StringValue("ListDatasources.Datasources["+ i +"].Config");
				datasourcesItem.GmtCreateTime = _ctx.StringValue("ListDatasources.Datasources["+ i +"].GmtCreateTime");
				datasourcesItem.GmtModifiedTime = _ctx.StringValue("ListDatasources.Datasources["+ i +"].GmtModifiedTime");
				datasourcesItem.WorkspaceId = _ctx.StringValue("ListDatasources.Datasources["+ i +"].WorkspaceId");

				listDatasourcesResponse_datasources.Add(datasourcesItem);
			}
			listDatasourcesResponse.Datasources = listDatasourcesResponse_datasources;
        
			return listDatasourcesResponse;
        }
    }
}
