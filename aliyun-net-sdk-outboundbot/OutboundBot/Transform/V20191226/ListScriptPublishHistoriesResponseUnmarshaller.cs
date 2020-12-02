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
        public static ListScriptPublishHistoriesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListScriptPublishHistoriesResponse listScriptPublishHistoriesResponse = new ListScriptPublishHistoriesResponse();

			listScriptPublishHistoriesResponse.HttpResponse = _ctx.HttpResponse;
			listScriptPublishHistoriesResponse.Code = _ctx.StringValue("ListScriptPublishHistories.Code");
			listScriptPublishHistoriesResponse.HttpStatusCode = _ctx.IntegerValue("ListScriptPublishHistories.HttpStatusCode");
			listScriptPublishHistoriesResponse.Message = _ctx.StringValue("ListScriptPublishHistories.Message");
			listScriptPublishHistoriesResponse.RequestId = _ctx.StringValue("ListScriptPublishHistories.RequestId");
			listScriptPublishHistoriesResponse.Success = _ctx.BooleanValue("ListScriptPublishHistories.Success");

			ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories scriptPublishHistories = new ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories();
			scriptPublishHistories.PageNumber = _ctx.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.PageNumber");
			scriptPublishHistories.PageSize = _ctx.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.PageSize");
			scriptPublishHistories.TotalCount = _ctx.IntegerValue("ListScriptPublishHistories.ScriptPublishHistories.TotalCount");

			List<ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory> scriptPublishHistories_list = new List<ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory>();
			for (int i = 0; i < _ctx.Length("ListScriptPublishHistories.ScriptPublishHistories.List.Length"); i++) {
				ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory publishHistory = new ListScriptPublishHistoriesResponse.ListScriptPublishHistories_ScriptPublishHistories.ListScriptPublishHistories_PublishHistory();
				publishHistory.Description = _ctx.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].Description");
				publishHistory.InstanceId = _ctx.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].InstanceId");
				publishHistory.PublishTime = _ctx.LongValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].PublishTime");
				publishHistory.ScriptId = _ctx.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].ScriptId");
				publishHistory.ScriptVersion = _ctx.StringValue("ListScriptPublishHistories.ScriptPublishHistories.List["+ i +"].ScriptVersion");

				scriptPublishHistories_list.Add(publishHistory);
			}
			scriptPublishHistories.List = scriptPublishHistories_list;
			listScriptPublishHistoriesResponse.ScriptPublishHistories = scriptPublishHistories;
        
			return listScriptPublishHistoriesResponse;
        }
    }
}
