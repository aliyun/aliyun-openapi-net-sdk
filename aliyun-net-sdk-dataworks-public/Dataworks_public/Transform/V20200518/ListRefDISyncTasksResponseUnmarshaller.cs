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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class ListRefDISyncTasksResponseUnmarshaller
    {
        public static ListRefDISyncTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListRefDISyncTasksResponse listRefDISyncTasksResponse = new ListRefDISyncTasksResponse();

			listRefDISyncTasksResponse.HttpResponse = _ctx.HttpResponse;
			listRefDISyncTasksResponse.Success = _ctx.BooleanValue("ListRefDISyncTasks.Success");
			listRefDISyncTasksResponse.RequestId = _ctx.StringValue("ListRefDISyncTasks.RequestId");

			ListRefDISyncTasksResponse.ListRefDISyncTasks_Data data = new ListRefDISyncTasksResponse.ListRefDISyncTasks_Data();

			List<ListRefDISyncTasksResponse.ListRefDISyncTasks_Data.ListRefDISyncTasks_DISyncTasksItem> data_dISyncTasks = new List<ListRefDISyncTasksResponse.ListRefDISyncTasks_Data.ListRefDISyncTasks_DISyncTasksItem>();
			for (int i = 0; i < _ctx.Length("ListRefDISyncTasks.Data.DISyncTasks.Length"); i++) {
				ListRefDISyncTasksResponse.ListRefDISyncTasks_Data.ListRefDISyncTasks_DISyncTasksItem dISyncTasksItem = new ListRefDISyncTasksResponse.ListRefDISyncTasks_Data.ListRefDISyncTasks_DISyncTasksItem();
				dISyncTasksItem.DiSourceDatasource = _ctx.StringValue("ListRefDISyncTasks.Data.DISyncTasks["+ i +"].DiSourceDatasource");
				dISyncTasksItem.TaskType = _ctx.StringValue("ListRefDISyncTasks.Data.DISyncTasks["+ i +"].TaskType");
				dISyncTasksItem.DiDestinationDatasource = _ctx.StringValue("ListRefDISyncTasks.Data.DISyncTasks["+ i +"].DiDestinationDatasource");
				dISyncTasksItem.NodeName = _ctx.StringValue("ListRefDISyncTasks.Data.DISyncTasks["+ i +"].NodeName");
				dISyncTasksItem.NodeId = _ctx.LongValue("ListRefDISyncTasks.Data.DISyncTasks["+ i +"].NodeId");

				data_dISyncTasks.Add(dISyncTasksItem);
			}
			data.DISyncTasks = data_dISyncTasks;
			listRefDISyncTasksResponse.Data = data;
        
			return listRefDISyncTasksResponse;
        }
    }
}
