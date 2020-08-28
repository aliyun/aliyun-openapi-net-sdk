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
    public class AsyncResponsePostResponseUnmarshaller
    {
        public static AsyncResponsePostResponse Unmarshall(UnmarshallerContext context)
        {
			AsyncResponsePostResponse asyncResponsePostResponse = new AsyncResponsePostResponse();

			asyncResponsePostResponse.HttpResponse = context.HttpResponse;
			asyncResponsePostResponse.RequestId = context.StringValue("AsyncResponsePost.RequestId");
			asyncResponsePostResponse.Data = context.StringValue("AsyncResponsePost.Data");
			asyncResponsePostResponse.Status = context.StringValue("AsyncResponsePost.Status");
			asyncResponsePostResponse.Code = context.StringValue("AsyncResponsePost.Code");
			asyncResponsePostResponse.Message = context.StringValue("AsyncResponsePost.Message");
        
			return asyncResponsePostResponse;
        }
    }
}
