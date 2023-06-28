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
using Aliyun.Acs.appstream_center.Model.V20210901;

namespace Aliyun.Acs.appstream_center.Transform.V20210901
{
    public class ListOtaTaskResponseUnmarshaller
    {
        public static ListOtaTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOtaTaskResponse listOtaTaskResponse = new ListOtaTaskResponse();

			listOtaTaskResponse.HttpResponse = _ctx.HttpResponse;
			listOtaTaskResponse.RequestId = _ctx.StringValue("ListOtaTask.RequestId");
			listOtaTaskResponse.TotalCount = _ctx.IntegerValue("ListOtaTask.TotalCount");
			listOtaTaskResponse.PageSize = _ctx.IntegerValue("ListOtaTask.PageSize");
			listOtaTaskResponse.PageNumber = _ctx.IntegerValue("ListOtaTask.PageNumber");

			List<ListOtaTaskResponse.ListOtaTask_Data> listOtaTaskResponse_taskList = new List<ListOtaTaskResponse.ListOtaTask_Data>();
			for (int i = 0; i < _ctx.Length("ListOtaTask.TaskList.Length"); i++) {
				ListOtaTaskResponse.ListOtaTask_Data data = new ListOtaTaskResponse.ListOtaTask_Data();
				data.OtaVersion = _ctx.StringValue("ListOtaTask.TaskList["+ i +"].OtaVersion");
				data.TaskDisplayStatus = _ctx.StringValue("ListOtaTask.TaskList["+ i +"].TaskDisplayStatus");
				data.TaskStartTime = _ctx.StringValue("ListOtaTask.TaskList["+ i +"].TaskStartTime");
				data.TaskId = _ctx.StringValue("ListOtaTask.TaskList["+ i +"].TaskId");

				listOtaTaskResponse_taskList.Add(data);
			}
			listOtaTaskResponse.TaskList = listOtaTaskResponse_taskList;
        
			return listOtaTaskResponse;
        }
    }
}
