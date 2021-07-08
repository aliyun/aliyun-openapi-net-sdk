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
using Aliyun.Acs.dataworks_public.Model.V20180601;

namespace Aliyun.Acs.dataworks_public.Transform.V20180601
{
    public class QueryDataImportProcessStatusResponseUnmarshaller
    {
        public static QueryDataImportProcessStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDataImportProcessStatusResponse queryDataImportProcessStatusResponse = new QueryDataImportProcessStatusResponse();

			queryDataImportProcessStatusResponse.HttpResponse = _ctx.HttpResponse;
			queryDataImportProcessStatusResponse.RequestId = _ctx.StringValue("QueryDataImportProcessStatus.RequestId");
			queryDataImportProcessStatusResponse.Message = _ctx.StringValue("QueryDataImportProcessStatus.Message");
			queryDataImportProcessStatusResponse.Code = _ctx.IntegerValue("QueryDataImportProcessStatus.Code");

			QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data data = new QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data();
			data.Status = _ctx.StringValue("QueryDataImportProcessStatus.Data.Status");
			data.Message = _ctx.StringValue("QueryDataImportProcessStatus.Data.Message");

			List<QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data.QueryDataImportProcessStatus_ProjectListItem> data_projectList = new List<QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data.QueryDataImportProcessStatus_ProjectListItem>();
			for (int i = 0; i < _ctx.Length("QueryDataImportProcessStatus.Data.ProjectList.Length"); i++) {
				QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data.QueryDataImportProcessStatus_ProjectListItem projectListItem = new QueryDataImportProcessStatusResponse.QueryDataImportProcessStatus_Data.QueryDataImportProcessStatus_ProjectListItem();
				projectListItem.ProjectName = _ctx.StringValue("QueryDataImportProcessStatus.Data.ProjectList["+ i +"].ProjectName");
				projectListItem.ProjectId = _ctx.StringValue("QueryDataImportProcessStatus.Data.ProjectList["+ i +"].ProjectId");
				projectListItem.ProjectIdentifier = _ctx.StringValue("QueryDataImportProcessStatus.Data.ProjectList["+ i +"].ProjectIdentifier");

				data_projectList.Add(projectListItem);
			}
			data.ProjectList = data_projectList;
			queryDataImportProcessStatusResponse.Data = data;
        
			return queryDataImportProcessStatusResponse;
        }
    }
}
