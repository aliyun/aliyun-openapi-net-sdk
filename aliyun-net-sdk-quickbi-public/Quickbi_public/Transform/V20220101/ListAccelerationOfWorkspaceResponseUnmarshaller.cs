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
    public class ListAccelerationOfWorkspaceResponseUnmarshaller
    {
        public static ListAccelerationOfWorkspaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAccelerationOfWorkspaceResponse listAccelerationOfWorkspaceResponse = new ListAccelerationOfWorkspaceResponse();

			listAccelerationOfWorkspaceResponse.HttpResponse = _ctx.HttpResponse;
			listAccelerationOfWorkspaceResponse.RequestId = _ctx.StringValue("ListAccelerationOfWorkspace.RequestId");
			listAccelerationOfWorkspaceResponse.Success = _ctx.BooleanValue("ListAccelerationOfWorkspace.Success");

			ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result result = new ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result();
			result.TotalPages = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.TotalPages");
			result.TotalNum = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.TotalNum");
			result.PageNum = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.PageNum");
			result.PageSize = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.PageSize");
			result.Pre = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.Pre");
			result.Next = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.Next");

			List<ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result.ListAccelerationOfWorkspace_DataItem> result_data = new List<ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result.ListAccelerationOfWorkspace_DataItem>();
			for (int i = 0; i < _ctx.Length("ListAccelerationOfWorkspace.Result.Data.Length"); i++) {
				ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result.ListAccelerationOfWorkspace_DataItem dataItem = new ListAccelerationOfWorkspaceResponse.ListAccelerationOfWorkspace_Result.ListAccelerationOfWorkspace_DataItem();
				dataItem.CubeId = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].CubeId");
				dataItem.CubeName = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].CubeName");
				dataItem.CreatorName = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].CreatorName");
				dataItem.Size = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].Size");
				dataItem.LastModifyTime = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].LastModifyTime");
				dataItem.EnableQuickindexTime = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].EnableQuickindexTime");
				dataItem.JobId = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].JobId");
				dataItem.JobStatus = _ctx.IntegerValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].JobStatus");
				dataItem.JobHistoryId = _ctx.StringValue("ListAccelerationOfWorkspace.Result.Data["+ i +"].JobHistoryId");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			listAccelerationOfWorkspaceResponse.Result = result;
        
			return listAccelerationOfWorkspaceResponse;
        }
    }
}
