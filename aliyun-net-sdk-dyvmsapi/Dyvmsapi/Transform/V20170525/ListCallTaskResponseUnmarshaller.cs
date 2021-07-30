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
    public class ListCallTaskResponseUnmarshaller
    {
        public static ListCallTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCallTaskResponse listCallTaskResponse = new ListCallTaskResponse();

			listCallTaskResponse.HttpResponse = _ctx.HttpResponse;
			listCallTaskResponse.RequestId = _ctx.StringValue("ListCallTask.RequestId");
			listCallTaskResponse.Code = _ctx.StringValue("ListCallTask.Code");
			listCallTaskResponse.PageNumber = _ctx.LongValue("ListCallTask.PageNumber");
			listCallTaskResponse.PageSize = _ctx.LongValue("ListCallTask.PageSize");
			listCallTaskResponse.Total = _ctx.LongValue("ListCallTask.Total");

			List<ListCallTaskResponse.ListCallTask_DataItem> listCallTaskResponse_data = new List<ListCallTaskResponse.ListCallTask_DataItem>();
			for (int i = 0; i < _ctx.Length("ListCallTask.Data.Length"); i++) {
				ListCallTaskResponse.ListCallTask_DataItem dataItem = new ListCallTaskResponse.ListCallTask_DataItem();
				dataItem.Id = _ctx.LongValue("ListCallTask.Data["+ i +"].Id");
				dataItem.TaskName = _ctx.StringValue("ListCallTask.Data["+ i +"].TaskName");
				dataItem.TemplateName = _ctx.StringValue("ListCallTask.Data["+ i +"].TemplateName");
				dataItem.BizType = _ctx.StringValue("ListCallTask.Data["+ i +"].BizType");
				dataItem.Resource = _ctx.StringValue("ListCallTask.Data["+ i +"].Resource");
				dataItem.FireTime = _ctx.StringValue("ListCallTask.Data["+ i +"].FireTime");
				dataItem.CompleteTime = _ctx.StringValue("ListCallTask.Data["+ i +"].CompleteTime");
				dataItem.Status = _ctx.StringValue("ListCallTask.Data["+ i +"].Status");
				dataItem.StopTime = _ctx.StringValue("ListCallTask.Data["+ i +"].StopTime");
				dataItem.TemplateCode = _ctx.StringValue("ListCallTask.Data["+ i +"].TemplateCode");
				dataItem.Data = _ctx.StringValue("ListCallTask.Data["+ i +"].Data");
				dataItem.DataType = _ctx.StringValue("ListCallTask.Data["+ i +"].DataType");
				dataItem.TotalCount = _ctx.LongValue("ListCallTask.Data["+ i +"].TotalCount");
				dataItem.CompletedCount = _ctx.LongValue("ListCallTask.Data["+ i +"].CompletedCount");
				dataItem.CompletedRate = _ctx.IntegerValue("ListCallTask.Data["+ i +"].CompletedRate");

				listCallTaskResponse_data.Add(dataItem);
			}
			listCallTaskResponse.Data = listCallTaskResponse_data;
        
			return listCallTaskResponse;
        }
    }
}
