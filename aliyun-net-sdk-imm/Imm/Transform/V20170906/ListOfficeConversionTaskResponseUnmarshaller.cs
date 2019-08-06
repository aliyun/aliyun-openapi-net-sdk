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
using Aliyun.Acs.imm.Model.V20170906;

namespace Aliyun.Acs.imm.Transform.V20170906
{
    public class ListOfficeConversionTaskResponseUnmarshaller
    {
        public static ListOfficeConversionTaskResponse Unmarshall(UnmarshallerContext context)
        {
			ListOfficeConversionTaskResponse listOfficeConversionTaskResponse = new ListOfficeConversionTaskResponse();

			listOfficeConversionTaskResponse.HttpResponse = context.HttpResponse;
			listOfficeConversionTaskResponse.RequestId = context.StringValue("ListOfficeConversionTask.RequestId");
			listOfficeConversionTaskResponse.NextMarker = context.StringValue("ListOfficeConversionTask.NextMarker");

			List<ListOfficeConversionTaskResponse.ListOfficeConversionTask_TasksItem> listOfficeConversionTaskResponse_tasks = new List<ListOfficeConversionTaskResponse.ListOfficeConversionTask_TasksItem>();
			for (int i = 0; i < context.Length("ListOfficeConversionTask.Tasks.Length"); i++) {
				ListOfficeConversionTaskResponse.ListOfficeConversionTask_TasksItem tasksItem = new ListOfficeConversionTaskResponse.ListOfficeConversionTask_TasksItem();
				tasksItem.TaskId = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].TaskId");
				tasksItem.Status = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].Status");
				tasksItem.Percent = context.IntegerValue("ListOfficeConversionTask.Tasks["+ i +"].Percent");
				tasksItem.PageCount = context.IntegerValue("ListOfficeConversionTask.Tasks["+ i +"].PageCount");
				tasksItem.SrcUri = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].SrcUri");
				tasksItem.TgtType = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].TgtType");
				tasksItem.TgtUri = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].TgtUri");
				tasksItem.ImageSpec = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].ImageSpec");
				tasksItem.NotifyTopicName = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].NotifyTopicName");
				tasksItem.NotifyEndpoint = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].NotifyEndpoint");
				tasksItem.ExternalID = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].ExternalID");
				tasksItem.CreateTime = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].CreateTime");
				tasksItem.FinishTime = context.StringValue("ListOfficeConversionTask.Tasks["+ i +"].FinishTime");

				listOfficeConversionTaskResponse_tasks.Add(tasksItem);
			}
			listOfficeConversionTaskResponse.Tasks = listOfficeConversionTaskResponse_tasks;
        
			return listOfficeConversionTaskResponse;
        }
    }
}
