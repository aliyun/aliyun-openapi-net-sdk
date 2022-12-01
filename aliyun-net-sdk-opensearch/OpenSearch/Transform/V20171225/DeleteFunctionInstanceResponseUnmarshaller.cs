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
using Aliyun.Acs.OpenSearch.Model.V20171225;

namespace Aliyun.Acs.OpenSearch.Transform.V20171225
{
    public class DeleteFunctionInstanceResponseUnmarshaller
    {
        public static DeleteFunctionInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteFunctionInstanceResponse deleteFunctionInstanceResponse = new DeleteFunctionInstanceResponse();

			deleteFunctionInstanceResponse.HttpResponse = _ctx.HttpResponse;
			deleteFunctionInstanceResponse.Status = _ctx.StringValue("DeleteFunctionInstance.Status");
			deleteFunctionInstanceResponse.HttpCode = _ctx.LongValue("DeleteFunctionInstance.HttpCode");
			deleteFunctionInstanceResponse.RequestId = _ctx.StringValue("DeleteFunctionInstance.RequestId");
			deleteFunctionInstanceResponse.Message = _ctx.StringValue("DeleteFunctionInstance.Message");
			deleteFunctionInstanceResponse.Code = _ctx.StringValue("DeleteFunctionInstance.Code");
			deleteFunctionInstanceResponse.Latency = _ctx.LongValue("DeleteFunctionInstance.Latency");
        
			return deleteFunctionInstanceResponse;
        }
    }
}
