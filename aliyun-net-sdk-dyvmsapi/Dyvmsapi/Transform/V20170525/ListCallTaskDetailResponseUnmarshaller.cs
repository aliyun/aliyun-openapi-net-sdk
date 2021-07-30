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
using Aliyun.Acs.Dyvmsapi.Model.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Transform.V20170525
{
    public class ListCallTaskDetailResponseUnmarshaller
    {
        public static ListCallTaskDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallTaskDetailResponse listCallTaskDetailResponse = new ListCallTaskDetailResponse();

			listCallTaskDetailResponse.HttpResponse = _ctx.HttpResponse;
			listCallTaskDetailResponse.RequestId = _ctx.StringValue("ListCallTaskDetail.RequestId");
			listCallTaskDetailResponse.Code = _ctx.StringValue("ListCallTaskDetail.Code");
			listCallTaskDetailResponse.Total = _ctx.LongValue("ListCallTaskDetail.Total");
			listCallTaskDetailResponse.TotalPage = _ctx.LongValue("ListCallTaskDetail.TotalPage");
			listCallTaskDetailResponse.PageSize = _ctx.LongValue("ListCallTaskDetail.PageSize");
			listCallTaskDetailResponse.PageNumber = _ctx.LongValue("ListCallTaskDetail.PageNumber");

			List<ListCallTaskDetailResponse.ListCallTaskDetail_DataItem> listCallTaskDetailResponse_data = new List<ListCallTaskDetailResponse.ListCallTaskDetail_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCallTaskDetail.Data.Length"); i++) {
				ListCallTaskDetailResponse.ListCallTaskDetail_DataItem dataItem = new ListCallTaskDetailResponse.ListCallTaskDetail_DataItem();
				dataItem.Caller = _ctx.StringValue("ListCallTaskDetail.Data["+ i +"].Caller");
				dataItem.CalledNum = _ctx.StringValue("ListCallTaskDetail.Data["+ i +"].CalledNum");
				dataItem.Status = _ctx.StringValue("ListCallTaskDetail.Data["+ i +"].Status");
				dataItem.Duration = _ctx.LongValue("ListCallTaskDetail.Data["+ i +"].Duration");
				dataItem.Id = _ctx.LongValue("ListCallTaskDetail.Data["+ i +"].Id");

				listCallTaskDetailResponse_data.Add(dataItem);
			}
			listCallTaskDetailResponse.Data = listCallTaskDetailResponse_data;
        
			return listCallTaskDetailResponse;
        }
    }
}
