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
    public class CreateMessageGroupResponseUnmarshaller
    {
        public static CreateMessageGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateMessageGroupResponse createMessageGroupResponse = new CreateMessageGroupResponse();

			createMessageGroupResponse.HttpResponse = _ctx.HttpResponse;
			createMessageGroupResponse.RequestId = _ctx.StringValue("CreateMessageGroup.RequestId");

			CreateMessageGroupResponse.CreateMessageGroup_Result result = new CreateMessageGroupResponse.CreateMessageGroup_Result();
			result.Extension = _ctx.StringValue("CreateMessageGroup.Result.Extension");
			result.GroupId = _ctx.StringValue("CreateMessageGroup.Result.GroupId");
			createMessageGroupResponse.Result = result;
        
			return createMessageGroupResponse;
        }
    }
}
