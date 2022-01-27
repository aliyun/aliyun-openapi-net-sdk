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
    public class DeleteRoleActionsResponseUnmarshaller
    {
        public static DeleteRoleActionsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRoleActionsResponse deleteRoleActionsResponse = new DeleteRoleActionsResponse();

			deleteRoleActionsResponse.HttpResponse = _ctx.HttpResponse;
			deleteRoleActionsResponse.ErrorMessage = _ctx.StringValue("DeleteRoleActions.ErrorMessage");
			deleteRoleActionsResponse.ErrorCode = _ctx.StringValue("DeleteRoleActions.ErrorCode");
			deleteRoleActionsResponse.Message = _ctx.StringValue("DeleteRoleActions.Message");
			deleteRoleActionsResponse.DynamicCode = _ctx.StringValue("DeleteRoleActions.DynamicCode");
			deleteRoleActionsResponse.Code = _ctx.StringValue("DeleteRoleActions.Code");
			deleteRoleActionsResponse.DynamicMessage = _ctx.StringValue("DeleteRoleActions.DynamicMessage");
			deleteRoleActionsResponse.RequestId = _ctx.StringValue("DeleteRoleActions.RequestId");
			deleteRoleActionsResponse.Success = _ctx.BooleanValue("DeleteRoleActions.Success");
        
			return deleteRoleActionsResponse;
        }
    }
}
