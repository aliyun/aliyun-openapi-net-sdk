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
    public class CreateApplicationResponseUnmarshaller
    {
        public static CreateApplicationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateApplicationResponse createApplicationResponse = new CreateApplicationResponse();

			createApplicationResponse.HttpResponse = _ctx.HttpResponse;
			createApplicationResponse.RequestId = _ctx.StringValue("CreateApplication.RequestId");

			CreateApplicationResponse.CreateApplication_Application application = new CreateApplicationResponse.CreateApplication_Application();
			application.Tags = _ctx.StringValue("CreateApplication.Application.Tags");
			application.Name = _ctx.StringValue("CreateApplication.Application.Name");
			application.UpdateDate = _ctx.StringValue("CreateApplication.Application.UpdateDate");
			application.Description = _ctx.StringValue("CreateApplication.Application.Description");
			application.CreateDate = _ctx.StringValue("CreateApplication.Application.CreateDate");
			createApplicationResponse.Application = application;
        
			return createApplicationResponse;
        }
    }
}
