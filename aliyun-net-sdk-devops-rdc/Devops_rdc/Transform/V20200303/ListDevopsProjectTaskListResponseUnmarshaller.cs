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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class ListDevopsProjectTaskListResponseUnmarshaller
    {
        public static ListDevopsProjectTaskListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDevopsProjectTaskListResponse listDevopsProjectTaskListResponse = new ListDevopsProjectTaskListResponse();

			listDevopsProjectTaskListResponse.HttpResponse = _ctx.HttpResponse;
			listDevopsProjectTaskListResponse.Successful = _ctx.BooleanValue("ListDevopsProjectTaskList.Successful");
			listDevopsProjectTaskListResponse.ErrorCode = _ctx.StringValue("ListDevopsProjectTaskList.ErrorCode");
			listDevopsProjectTaskListResponse.ErrorMsg = _ctx.StringValue("ListDevopsProjectTaskList.ErrorMsg");
			listDevopsProjectTaskListResponse.RequestId = _ctx.StringValue("ListDevopsProjectTaskList.RequestId");

			ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object _object = new ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object();

			List<ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object.ListDevopsProjectTaskList_ResultItem> _object_result = new List<ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object.ListDevopsProjectTaskList_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDevopsProjectTaskList.Object.Result.Length"); i++) {
				ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object.ListDevopsProjectTaskList_ResultItem resultItem = new ListDevopsProjectTaskListResponse.ListDevopsProjectTaskList__Object.ListDevopsProjectTaskList_ResultItem();
				resultItem.Id = _ctx.StringValue("ListDevopsProjectTaskList.Object.Result["+ i +"].Id");

				_object_result.Add(resultItem);
			}
			_object.Result = _object_result;
			listDevopsProjectTaskListResponse._Object = _object;
        
			return listDevopsProjectTaskListResponse;
        }
    }
}
