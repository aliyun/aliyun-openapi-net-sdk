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
using Aliyun.Acs.saf.Model.V20190521;

namespace Aliyun.Acs.saf.Transform.V20190521
{
    public class ExecuteExtendServiceResponseUnmarshaller
    {
        public static ExecuteExtendServiceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecuteExtendServiceResponse executeExtendServiceResponse = new ExecuteExtendServiceResponse();

			executeExtendServiceResponse.HttpResponse = _ctx.HttpResponse;
			executeExtendServiceResponse.HttpStatusCode = _ctx.StringValue("ExecuteExtendService.HttpStatusCode");
			executeExtendServiceResponse.Code = _ctx.StringValue("ExecuteExtendService.Code");
			executeExtendServiceResponse.Message = _ctx.StringValue("ExecuteExtendService.Message");
			executeExtendServiceResponse.RequestId = _ctx.StringValue("ExecuteExtendService.RequestId");
			executeExtendServiceResponse.Success = _ctx.BooleanValue("ExecuteExtendService.Success");

			ExecuteExtendServiceResponse.ExecuteExtendService_Data data = new ExecuteExtendServiceResponse.ExecuteExtendService_Data();
			data.InvokeResult = _ctx.StringValue("ExecuteExtendService.Data.InvokeResult");
			executeExtendServiceResponse.Data = data;
        
			return executeExtendServiceResponse;
        }
    }
}
