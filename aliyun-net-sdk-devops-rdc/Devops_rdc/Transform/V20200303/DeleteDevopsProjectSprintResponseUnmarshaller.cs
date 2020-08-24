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
    public class DeleteDevopsProjectSprintResponseUnmarshaller
    {
        public static DeleteDevopsProjectSprintResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteDevopsProjectSprintResponse deleteDevopsProjectSprintResponse = new DeleteDevopsProjectSprintResponse();

			deleteDevopsProjectSprintResponse.HttpResponse = context.HttpResponse;
			deleteDevopsProjectSprintResponse.Successful = context.BooleanValue("DeleteDevopsProjectSprint.Successful");
			deleteDevopsProjectSprintResponse.ErrorCode = context.StringValue("DeleteDevopsProjectSprint.ErrorCode");
			deleteDevopsProjectSprintResponse.ErrorMsg = context.StringValue("DeleteDevopsProjectSprint.ErrorMsg");
			deleteDevopsProjectSprintResponse.RequestId = context.StringValue("DeleteDevopsProjectSprint.RequestId");
			deleteDevopsProjectSprintResponse._Object = context.BooleanValue("DeleteDevopsProjectSprint.Object");
        
			return deleteDevopsProjectSprintResponse;
        }
    }
}
