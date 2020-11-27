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
    public class UpdateDevopsProjectResponseUnmarshaller
    {
        public static UpdateDevopsProjectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateDevopsProjectResponse updateDevopsProjectResponse = new UpdateDevopsProjectResponse();

			updateDevopsProjectResponse.HttpResponse = _ctx.HttpResponse;
			updateDevopsProjectResponse.RequestId = _ctx.StringValue("UpdateDevopsProject.RequestId");
			updateDevopsProjectResponse.ErrorCode = _ctx.StringValue("UpdateDevopsProject.ErrorCode");
			updateDevopsProjectResponse.ErrorMessage = _ctx.StringValue("UpdateDevopsProject.ErrorMessage");
			updateDevopsProjectResponse.Success = _ctx.BooleanValue("UpdateDevopsProject.Success");
			updateDevopsProjectResponse._Object = _ctx.StringValue("UpdateDevopsProject.Object");
        
			return updateDevopsProjectResponse;
        }
    }
}
