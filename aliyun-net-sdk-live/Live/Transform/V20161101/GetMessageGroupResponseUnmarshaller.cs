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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class GetMessageGroupResponseUnmarshaller
    {
        public static GetMessageGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMessageGroupResponse getMessageGroupResponse = new GetMessageGroupResponse();

			getMessageGroupResponse.HttpResponse = _ctx.HttpResponse;
			getMessageGroupResponse.RequestId = _ctx.StringValue("GetMessageGroup.RequestId");

			GetMessageGroupResponse.GetMessageGroup_Result result = new GetMessageGroupResponse.GetMessageGroup_Result();
			result.GroupId = _ctx.StringValue("GetMessageGroup.Result.GroupId");
			result.CreateTime = _ctx.LongValue("GetMessageGroup.Result.CreateTime");
			result.Status = _ctx.IntegerValue("GetMessageGroup.Result.Status");
			result.CreatorId = _ctx.StringValue("GetMessageGroup.Result.CreatorId");
			result.Extension = _ctx.StringValue("GetMessageGroup.Result.Extension");
			getMessageGroupResponse.Result = result;
        
			return getMessageGroupResponse;
        }
    }
}
