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
    public class GetTaskDetailActivityResponseUnmarshaller
    {
        public static GetTaskDetailActivityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTaskDetailActivityResponse getTaskDetailActivityResponse = new GetTaskDetailActivityResponse();

			getTaskDetailActivityResponse.HttpResponse = _ctx.HttpResponse;
			getTaskDetailActivityResponse.Successful = _ctx.BooleanValue("GetTaskDetailActivity.Successful");
			getTaskDetailActivityResponse.ErrorCode = _ctx.StringValue("GetTaskDetailActivity.ErrorCode");
			getTaskDetailActivityResponse.ErrorMsg = _ctx.StringValue("GetTaskDetailActivity.ErrorMsg");
			getTaskDetailActivityResponse.RequestId = _ctx.StringValue("GetTaskDetailActivity.RequestId");
			getTaskDetailActivityResponse.HttpStatusCode = _ctx.IntegerValue("GetTaskDetailActivity.HttpStatusCode");

			List<GetTaskDetailActivityResponse.GetTaskDetailActivity_Activity> getTaskDetailActivityResponse_object = new List<GetTaskDetailActivityResponse.GetTaskDetailActivity_Activity>();
			for (int i = 0; i < _ctx.Length("GetTaskDetailActivity.Object.Length"); i++) {
				GetTaskDetailActivityResponse.GetTaskDetailActivity_Activity activity = new GetTaskDetailActivityResponse.GetTaskDetailActivity_Activity();
				activity.Created = _ctx.StringValue("GetTaskDetailActivity.Object["+ i +"].Created");
				activity.Title = _ctx.StringValue("GetTaskDetailActivity.Object["+ i +"].Title");
				activity.Action = _ctx.StringValue("GetTaskDetailActivity.Object["+ i +"].Action");
				activity.Updated = _ctx.StringValue("GetTaskDetailActivity.Object["+ i +"].Updated");
				activity.Content = _ctx.StringValue("GetTaskDetailActivity.Object["+ i +"].Content");

				getTaskDetailActivityResponse_object.Add(activity);
			}
			getTaskDetailActivityResponse._Object = getTaskDetailActivityResponse_object;
        
			return getTaskDetailActivityResponse;
        }
    }
}
