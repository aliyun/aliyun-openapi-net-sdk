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
using Aliyun.Acs.eds_user.Model.V20210308;

namespace Aliyun.Acs.eds_user.Transform.V20210308
{
    public class CreateGroupResponseUnmarshaller
    {
        public static CreateGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateGroupResponse createGroupResponse = new CreateGroupResponse();

			createGroupResponse.HttpResponse = _ctx.HttpResponse;
			createGroupResponse.RequestId = _ctx.StringValue("CreateGroup.RequestId");
			createGroupResponse.GroupId = _ctx.StringValue("CreateGroup.GroupId");
        
			return createGroupResponse;
        }
    }
}
