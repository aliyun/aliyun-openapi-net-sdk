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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListTaskByPageResponseUnmarshaller
    {
        public static ListTaskByPageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTaskByPageResponse listTaskByPageResponse = new ListTaskByPageResponse();

			listTaskByPageResponse.HttpResponse = _ctx.HttpResponse;
			listTaskByPageResponse.RequestId = _ctx.StringValue("ListTaskByPage.RequestId");
			listTaskByPageResponse.Success = _ctx.BooleanValue("ListTaskByPage.Success");
			listTaskByPageResponse.Code = _ctx.StringValue("ListTaskByPage.Code");
			listTaskByPageResponse.ErrorMessage = _ctx.StringValue("ListTaskByPage.ErrorMessage");
			listTaskByPageResponse.Total = _ctx.IntegerValue("ListTaskByPage.Total");
			listTaskByPageResponse.PageSize = _ctx.IntegerValue("ListTaskByPage.PageSize");
			listTaskByPageResponse.PageCount = _ctx.IntegerValue("ListTaskByPage.PageCount");
			listTaskByPageResponse.Page = _ctx.IntegerValue("ListTaskByPage.Page");

			List<ListTaskByPageResponse.ListTaskByPage_DataItem> listTaskByPageResponse_data = new List<ListTaskByPageResponse.ListTaskByPage_DataItem>();
			for (int i = 0; i < _ctx.Length("ListTaskByPage.Data.Length"); i++) {
				ListTaskByPageResponse.ListTaskByPage_DataItem dataItem = new ListTaskByPageResponse.ListTaskByPage_DataItem();
				dataItem.JobId = _ctx.StringValue("ListTaskByPage.Data["+ i +"].JobId");
				dataItem.JobName = _ctx.StringValue("ListTaskByPage.Data["+ i +"].JobName");
				dataItem.TaskId = _ctx.StringValue("ListTaskByPage.Data["+ i +"].TaskId");
				dataItem.ProductKey = _ctx.StringValue("ListTaskByPage.Data["+ i +"].ProductKey");
				dataItem.DeviceName = _ctx.StringValue("ListTaskByPage.Data["+ i +"].DeviceName");
				dataItem.IotId = _ctx.StringValue("ListTaskByPage.Data["+ i +"].IotId");
				dataItem.Progress = _ctx.IntegerValue("ListTaskByPage.Data["+ i +"].Progress");
				dataItem.UtcQueueTime = _ctx.StringValue("ListTaskByPage.Data["+ i +"].UtcQueueTime");
				dataItem.UtcModified = _ctx.StringValue("ListTaskByPage.Data["+ i +"].UtcModified");
				dataItem.StatusDetail = _ctx.StringValue("ListTaskByPage.Data["+ i +"].StatusDetail");
				dataItem.Status = _ctx.StringValue("ListTaskByPage.Data["+ i +"].Status");
				dataItem.ProductName = _ctx.StringValue("ListTaskByPage.Data["+ i +"].ProductName");

				listTaskByPageResponse_data.Add(dataItem);
			}
			listTaskByPageResponse.Data = listTaskByPageResponse_data;
        
			return listTaskByPageResponse;
        }
    }
}
