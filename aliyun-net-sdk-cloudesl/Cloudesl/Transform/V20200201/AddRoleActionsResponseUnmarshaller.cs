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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class AddRoleActionsResponseUnmarshaller
    {
        public static AddRoleActionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddRoleActionsResponse addRoleActionsResponse = new AddRoleActionsResponse();

			addRoleActionsResponse.HttpResponse = _ctx.HttpResponse;
			addRoleActionsResponse.ErrorMessage = _ctx.StringValue("AddRoleActions.ErrorMessage");
			addRoleActionsResponse.ErrorCode = _ctx.StringValue("AddRoleActions.ErrorCode");
			addRoleActionsResponse.Message = _ctx.StringValue("AddRoleActions.Message");
			addRoleActionsResponse.DynamicCode = _ctx.StringValue("AddRoleActions.DynamicCode");
			addRoleActionsResponse.Code = _ctx.StringValue("AddRoleActions.Code");
			addRoleActionsResponse.DynamicMessage = _ctx.StringValue("AddRoleActions.DynamicMessage");
			addRoleActionsResponse.RequestId = _ctx.StringValue("AddRoleActions.RequestId");
			addRoleActionsResponse.Success = _ctx.BooleanValue("AddRoleActions.Success");
        
			return addRoleActionsResponse;
        }
    }
}
