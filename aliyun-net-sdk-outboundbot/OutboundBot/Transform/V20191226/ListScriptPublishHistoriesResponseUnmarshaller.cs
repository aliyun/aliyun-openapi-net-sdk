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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListScriptPublishHistoriesResponseUnmarshaller
    {
        public static ListScriptPublishHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			ListScriptPublishHistoriesResponse listScriptPublishHistoriesResponse = new ListScriptPublishHistoriesResponse();

			listScriptPublishHistoriesResponse.HttpResponse = context.HttpResponse;
			listScriptPublishHistoriesResponse.RequestId = context.StringValue("ListScriptPublishHistories.RequestId");
			listScriptPublishHistoriesResponse.Success = context.BooleanValue("ListScriptPublishHistories.Success");
			listScriptPublishHistoriesResponse.Code = context.StringValue("ListScriptPublishHistories.Code");
			listScriptPublishHistoriesResponse.Message = context.StringValue("ListScriptPublishHistories.Message");
			listScriptPublishHistoriesResponse.HttpStatusCode = context.IntegerValue("ListScriptPublishHistories.HttpStatusCode");

			ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories scriptPublishHistories = new ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories();
			scriptPublishHistories.TotalCount = context.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.TotalCount");
			scriptPublishHistories.PageNumber = context.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.PageNumber");
			scriptPublishHistories.PageSize = context.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.PageSize");

			List<ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory> scriptPublishHistories_list = new List<ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory>();
			for (int i = 0; i < context.Length("ListScriptPublishHistories.ScriptPublishHistories.List.Length"); i++) {
				ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory publishHistory = new ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory();
				publishHistory.InstanceId = context.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].InstanceId");
				publishHistory.ScriptId = context.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].ScriptId");
				publishHistory.ScriptVersion = context.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].ScriptVersion");
				publishHistory.Description = context.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].Description");
				publishHistory.PublishTime = context.LongValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].PublishTime");

				scriptPublishHistories_list.Add(publishHistory);
			}
			scriptPublishHistories.List = scriptPublishHistories_list;
			listScriptPublishHistoriesResponse.ScriptPublishHistories = scriptPublishHistories;
        
			return listScriptPublishHistoriesResponse;
        }
    }
}
