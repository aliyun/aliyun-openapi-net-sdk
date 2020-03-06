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
using Aliyun.Acs.saf.Model.V20180919;

namespace Aliyun.Acs.saf.Transform.V20180919
{
    public class ExecuteRequestResponseUnmarshaller
    {
        public static ExecuteRequestResponse Unmarshall(UnmarshallerContext context)
        {
			ExecuteRequestResponse executeRequestResponse = new ExecuteRequestResponse();

			executeRequestResponse.HttpResponse = context.HttpResponse;
			executeRequestResponse.RequestId = context.StringValue("ExecuteRequest.RequestId");
			executeRequestResponse.Code = context.IntegerValue("ExecuteRequest.Code");
			executeRequestResponse.Message = context.StringValue("ExecuteRequest.Message");

			ExecuteRequestResponse.ExecuteRequest_Data data = new ExecuteRequestResponse.ExecuteRequest_Data();
			data.Tags = context.StringValue("ExecuteRequest.Data.Tags");
			data.Score = context.StringValue("ExecuteRequest.Data.Score");
			data.Extend = context.StringValue("ExecuteRequest.Data.Extend");
			executeRequestResponse.Data = data;
        
			return executeRequestResponse;
        }
    }
}
