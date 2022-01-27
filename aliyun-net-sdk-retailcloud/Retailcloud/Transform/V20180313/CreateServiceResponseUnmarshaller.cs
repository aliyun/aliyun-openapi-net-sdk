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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class CreateServiceResponseUnmarshaller
    {
        public static CreateServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateServiceResponse createServiceResponse = new CreateServiceResponse();

			createServiceResponse.HttpResponse = _ctx.HttpResponse;
			createServiceResponse.Code = _ctx.IntegerValue("CreateService.Code");
			createServiceResponse.ErrMsg = _ctx.StringValue("CreateService.ErrMsg");
			createServiceResponse.RequestId = _ctx.StringValue("CreateService.RequestId");
			createServiceResponse.Success = _ctx.BooleanValue("CreateService.Success");

			CreateServiceResponse.CreateService_Result result = new CreateServiceResponse.CreateService_Result();
			result.ServiceId = _ctx.LongValue("CreateService.Result.ServiceId");
			createServiceResponse.Result = result;
        
			return createServiceResponse;
        }
    }
}
