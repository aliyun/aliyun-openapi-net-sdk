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
using Aliyun.Acs.WebsiteBuild.Model.V20250429;

namespace Aliyun.Acs.WebsiteBuild.Transform.V20250429
{
    public class CreateLogoTaskResponseUnmarshaller
    {
        public static CreateLogoTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateLogoTaskResponse createLogoTaskResponse = new CreateLogoTaskResponse();

			createLogoTaskResponse.HttpResponse = _ctx.HttpResponse;
			createLogoTaskResponse.RequestId = _ctx.StringValue("CreateLogoTask.RequestId");
			createLogoTaskResponse.ErrorMsg = _ctx.StringValue("CreateLogoTask.ErrorMsg");
			createLogoTaskResponse.Success = _ctx.BooleanValue("CreateLogoTask.Success");
			createLogoTaskResponse.ErrorCode = _ctx.StringValue("CreateLogoTask.ErrorCode");
			createLogoTaskResponse.TaskId = _ctx.StringValue("CreateLogoTask.TaskId");
        
			return createLogoTaskResponse;
        }
    }
}
