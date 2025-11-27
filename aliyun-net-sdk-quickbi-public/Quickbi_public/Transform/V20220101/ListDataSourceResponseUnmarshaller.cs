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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class ListDataSourceResponseUnmarshaller
    {
        public static ListDataSourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDataSourceResponse listDataSourceResponse = new ListDataSourceResponse();

			listDataSourceResponse.HttpResponse = _ctx.HttpResponse;
			listDataSourceResponse.RequestId = _ctx.StringValue("ListDataSource.RequestId");
			listDataSourceResponse.Success = _ctx.BooleanValue("ListDataSource.Success");

			List<ListDataSourceResponse.ListDataSource_Data> listDataSourceResponse_result = new List<ListDataSourceResponse.ListDataSource_Data>();
			for (int i = 0; i < _ctx.Length("ListDataSource.Result.Length"); i++) {
				ListDataSourceResponse.ListDataSource_Data data = new ListDataSourceResponse.ListDataSource_Data();
				data.CreatorId = _ctx.StringValue("ListDataSource.Result["+ i +"].CreatorId");
				data.CreatorName = _ctx.StringValue("ListDataSource.Result["+ i +"].CreatorName");
				data.DatasourceId = _ctx.StringValue("ListDataSource.Result["+ i +"].DatasourceId");
				data.GmtCreate = _ctx.StringValue("ListDataSource.Result["+ i +"].GmtCreate");
				data.GmtModified = _ctx.StringValue("ListDataSource.Result["+ i +"].GmtModified");
				data.ShowName = _ctx.StringValue("ListDataSource.Result["+ i +"].ShowName");
				data.DsType = _ctx.StringValue("ListDataSource.Result["+ i +"].DsType");
				data.ParentDsType = _ctx.StringValue("ListDataSource.Result["+ i +"].ParentDsType");

				listDataSourceResponse_result.Add(data);
			}
			listDataSourceResponse.Result = listDataSourceResponse_result;
        
			return listDataSourceResponse;
        }
    }
}
