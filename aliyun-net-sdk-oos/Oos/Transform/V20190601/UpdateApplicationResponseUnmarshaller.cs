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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class UpdateApplicationResponseUnmarshaller
    {
        public static UpdateApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateApplicationResponse updateApplicationResponse = new UpdateApplicationResponse();

			updateApplicationResponse.HttpResponse = _ctx.HttpResponse;
			updateApplicationResponse.RequestId = _ctx.StringValue("UpdateApplication.RequestId");

			UpdateApplicationResponse.UpdateApplication_Application application = new UpdateApplicationResponse.UpdateApplication_Application();
			application.Description = _ctx.StringValue("UpdateApplication.Application.Description");
			application.UpdatedDate = _ctx.StringValue("UpdateApplication.Application.UpdatedDate");
			application.ResourceGroupId = _ctx.StringValue("UpdateApplication.Application.ResourceGroupId");
			application.CreatedDate = _ctx.StringValue("UpdateApplication.Application.CreatedDate");
			application.Tags = _ctx.StringValue("UpdateApplication.Application.Tags");
			application.Name = _ctx.StringValue("UpdateApplication.Application.Name");
			updateApplicationResponse.Application = application;
        
			return updateApplicationResponse;
        }
    }
}
