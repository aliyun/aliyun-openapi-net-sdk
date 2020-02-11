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
        public static ListOTATaskByJobResponse Unmarshall(UnmarshallerContext context)
        {
			ListOTATaskByJobResponse listOTATaskByJobResponse = new ListOTATaskByJobResponse();

			listOTATaskByJobResponse.HttpResponse = context.HttpResponse;
			listOTATaskByJobResponse.RequestId = context.StringValue("ListOTATaskByJob.RequestId");
			listOTATaskByJobResponse.Success = context.BooleanValue("ListOTATaskByJob.Success");
			listOTATaskByJobResponse.Code = context.StringValue("ListOTATaskByJob.Code");
			listOTATaskByJobResponse.ErrorMessage = context.StringValue("ListOTATaskByJob.ErrorMessage");
			listOTATaskByJobResponse.Total = context.IntegerValue("ListOTATaskByJob.Total");
			listOTATaskByJobResponse.PageSize = context.IntegerValue("ListOTATaskByJob.PageSize");
			listOTATaskByJobResponse.PageCount = context.IntegerValue("ListOTATaskByJob.PageCount");
			listOTATaskByJobResponse.CurrentPage = context.IntegerValue("ListOTATaskByJob.CurrentPage");

			List<ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo> listOTATaskByJobResponse_data = new List<ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo>();
			for (int i = 0; i < context.Length("ListOTATaskByJob.Data.Length"); i++) {
				ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo simpleOTATaskInfo = new ListOTATaskByJobResponse.ListOTATaskByJob_SimpleOTATaskInfo();
				simpleOTATaskInfo.TaskId = context.StringValue("ListOTATaskByJob.Data["+ i +"].TaskId");
				simpleOTATaskInfo.UtcModified = context.StringValue("ListOTATaskByJob.Data["+ i +"].UtcModified");
				simpleOTATaskInfo.ProductKey = context.StringValue("ListOTATaskByJob.Data["+ i +"].ProductKey");
				simpleOTATaskInfo.FirmwareId = context.StringValue("ListOTATaskByJob.Data["+ i +"].FirmwareId");
				simpleOTATaskInfo.TaskStatus = context.StringValue("ListOTATaskByJob.Data["+ i +"].TaskStatus");
				simpleOTATaskInfo.JobId = context.StringValue("ListOTATaskByJob.Data["+ i +"].JobId");
				simpleOTATaskInfo.ProductName = context.StringValue("ListOTATaskByJob.Data["+ i +"].ProductName");
				simpleOTATaskInfo.DeviceName = context.StringValue("ListOTATaskByJob.Data["+ i +"].DeviceName");
				simpleOTATaskInfo.SrcVersion = context.StringValue("ListOTATaskByJob.Data["+ i +"].SrcVersion");
				simpleOTATaskInfo.DestVersion = context.StringValue("ListOTATaskByJob.Data["+ i +"].DestVersion");
				simpleOTATaskInfo.TaskDesc = context.StringValue("ListOTATaskByJob.Data["+ i +"].TaskDesc");
				simpleOTATaskInfo.Progress = context.StringValue("ListOTATaskByJob.Data["+ i +"].Progress");
				simpleOTATaskInfo.IotId = context.StringValue("ListOTATaskByJob.Data["+ i +"].IotId");
				simpleOTATaskInfo.UtcCreate = context.StringValue("ListOTATaskByJob.Data["+ i +"].UtcCreate");

				listOTATaskByJobResponse_data.Add(simpleOTATaskInfo);
			}
			listOTATaskByJobResponse.Data = listOTATaskByJobResponse_data;
        
			return listOTATaskByJobResponse;
        }
    }
}
