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
    public class GetWorksEmbedListResponseUnmarshaller
    {
        public static GetWorksEmbedListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetWorksEmbedListResponse getWorksEmbedListResponse = new GetWorksEmbedListResponse();

			getWorksEmbedListResponse.HttpResponse = _ctx.HttpResponse;
			getWorksEmbedListResponse.RequestId = _ctx.StringValue("GetWorksEmbedList.RequestId");
			getWorksEmbedListResponse.Success = _ctx.BooleanValue("GetWorksEmbedList.Success");

			GetWorksEmbedListResponse.GetWorksEmbedList_Result result = new GetWorksEmbedListResponse.GetWorksEmbedList_Result();
			result.PageNo = _ctx.LongValue("GetWorksEmbedList.Result.PageNo");
			result.PageSize = _ctx.LongValue("GetWorksEmbedList.Result.PageSize");
			result.TotalNum = _ctx.LongValue("GetWorksEmbedList.Result.TotalNum");
			result.TotalPages = _ctx.LongValue("GetWorksEmbedList.Result.TotalPages");

			List<GetWorksEmbedListResponse.GetWorksEmbedList_Result.GetWorksEmbedList_DataItem> result_data = new List<GetWorksEmbedListResponse.GetWorksEmbedList_Result.GetWorksEmbedList_DataItem>();
			for (int i = 0; i < _ctx.Length("GetWorksEmbedList.Result.Data.Length"); i++) {
				GetWorksEmbedListResponse.GetWorksEmbedList_Result.GetWorksEmbedList_DataItem dataItem = new GetWorksEmbedListResponse.GetWorksEmbedList_Result.GetWorksEmbedList_DataItem();
				dataItem.EmbedTime = _ctx.StringValue("GetWorksEmbedList.Result.Data["+ i +"].EmbedTime");
				dataItem.WorksId = _ctx.StringValue("GetWorksEmbedList.Result.Data["+ i +"].WorksId");
				dataItem.WorksName = _ctx.StringValue("GetWorksEmbedList.Result.Data["+ i +"].WorksName");
				dataItem.WorksType = _ctx.StringValue("GetWorksEmbedList.Result.Data["+ i +"].WorksType");
				dataItem.WorkspaceId = _ctx.StringValue("GetWorksEmbedList.Result.Data["+ i +"].WorkspaceId");

				result_data.Add(dataItem);
			}
			result.Data = result_data;
			getWorksEmbedListResponse.Result = result;
        
			return getWorksEmbedListResponse;
        }
    }
}
