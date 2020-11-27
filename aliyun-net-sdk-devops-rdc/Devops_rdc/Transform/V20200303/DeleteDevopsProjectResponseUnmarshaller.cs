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
    public class DeleteDevopsProjectResponseUnmarshaller
    {
        public static DeleteDevopsProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteDevopsProjectResponse deleteDevopsProjectResponse = new DeleteDevopsProjectResponse();

			deleteDevopsProjectResponse.HttpResponse = _ctx.HttpResponse;
			deleteDevopsProjectResponse.ErrorCode = _ctx.StringValue("DeleteDevopsProject.ErrorCode");
			deleteDevopsProjectResponse.ErrorMessage = _ctx.StringValue("DeleteDevopsProject.ErrorMessage");
			deleteDevopsProjectResponse._Object = _ctx.StringValue("DeleteDevopsProject.Object");
			deleteDevopsProjectResponse.RequestId = _ctx.StringValue("DeleteDevopsProject.RequestId");
			deleteDevopsProjectResponse.Success = _ctx.BooleanValue("DeleteDevopsProject.Success");
        
			return deleteDevopsProjectResponse;
        }
    }
}
