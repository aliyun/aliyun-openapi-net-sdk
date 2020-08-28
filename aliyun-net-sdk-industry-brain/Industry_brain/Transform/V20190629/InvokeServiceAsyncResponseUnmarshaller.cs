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
using Aliyun.Acs.industry_brain.Model.V20190629;

namespace Aliyun.Acs.industry_brain.Transform.V20190629
{
    public class InvokeServiceAsyncResponseUnmarshaller
    {
        public static InvokeServiceAsyncResponse Unmarshall(UnmarshallerContext context)
        {
			InvokeServiceAsyncResponse invokeServiceAsyncResponse = new InvokeServiceAsyncResponse();

			invokeServiceAsyncResponse.HttpResponse = context.HttpResponse;
			invokeServiceAsyncResponse.RequestId = context.StringValue("InvokeServiceAsync.RequestId");
			invokeServiceAsyncResponse.Data = context.StringValue("InvokeServiceAsync.Data");
			invokeServiceAsyncResponse.Code = context.StringValue("InvokeServiceAsync.Code");
			invokeServiceAsyncResponse.Message = context.StringValue("InvokeServiceAsync.Message");
        
			return invokeServiceAsyncResponse;
        }
    }
}
