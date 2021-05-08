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
    public class ListOTATaskByJobResponseUnmarshaller
    {
        public static ListOTATaskByJobResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOTATaskByJobResponse listOTATaskByJobResponse = new ListOTATaskByJobResponse();

			listOTATaskByJobResponse.HttpResponse = _ctx.HttpResponse;
			listOTATaskByJobResponse.RequestId = _ctx.StringValue("ListOTATaskByJob.RequestId");
			listOTATaskByJobResponse.Success = _ctx.BooleanValue("ListOTATaskByJob.Success");
			listOTATaskByJobResponse.Code = _ctx.StringValue("ListOTATaskByJob.Code");
			listOTATaskByJobResponse.ErrorMessage = _ctx.StringValue("ListOTATaskByJob.ErrorMessage");
			listOTATaskByJobResponse.Total = _ctx.IntegerValue("ListOTATaskByJob.Total");
			listOTATaskByJobResponse.PageSize = _ctx.IntegerValue("ListOTATaskByJob.PageSize");
			listOTATaskByJobResponse.PageCount = _ctx.IntegerValue("ListOTATaskByJob.PageCount");
			listOTATaskByJobResponse.CurrentPage = _ctx.IntegerValue("ListOTATaskByJob.CurrentPage");

			List<ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo> listOTATaskByJobResponse_data = new List<ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo>();
			for (int i = 0; i < _ctx.Length("ListOTATaskByJob.Data.Length"); i++) {
				ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo simpleOTATaskInfo = new ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo();
				simpleOTATaskInfo.TaskId = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].TaskId");
				simpleOTATaskInfo.UtcModified = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].UtcModified");
				simpleOTATaskInfo.ProductKey = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].ProductKey");
				simpleOTATaskInfo.FirmwareId = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].FirmwareId");
				simpleOTATaskInfo.TaskStatus = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].TaskStatus");
				simpleOTATaskInfo.JobId = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].JobId");
				simpleOTATaskInfo.ProductName = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].ProductName");
				simpleOTATaskInfo.DeviceName = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].DeviceName");
				simpleOTATaskInfo.SrcVersion = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].SrcVersion");
				simpleOTATaskInfo.DestVersion = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].DestVersion");
				simpleOTATaskInfo.TaskDesc = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].TaskDesc");
				simpleOTATaskInfo.Progress = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].Progress");
				simpleOTATaskInfo.IotId = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].IotId");
				simpleOTATaskInfo.UtcCreate = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].UtcCreate");
				simpleOTATaskInfo.Timeout = _ctx.StringValue("ListOTATaskByJob.Data["+ i +"].Timeout");

				listOTATaskByJobResponse_data.Add(simpleOTATaskInfo);
			}
			listOTATaskByJobResponse.Data = listOTATaskByJobResponse_data;
        
			return listOTATaskByJobResponse;
        }
    }
}
