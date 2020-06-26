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
using Aliyun.Acs.ivpd.Model.V20190625;

namespace Aliyun.Acs.ivpd.Transform.V20190625
{
    public class GetAsyncResultResponseUnmarshaller
    {
        public static GetAsyncResultResponse Unmarshall(UnmarshallerContext context)
        {
			GetAsyncResultResponse getAsyncResultResponse = new GetAsyncResultResponse();

			getAsyncResultResponse.HttpResponse = context.HttpResponse;
			getAsyncResultResponse.RequestId = context.StringValue("GetAsyncResult.RequestId");
			getAsyncResultResponse.Code = context.StringValue("GetAsyncResult.Code");
			getAsyncResultResponse.Message = context.StringValue("GetAsyncResult.Message");

			GetAsyncResultResponse.GetAsyncResult_Data data = new GetAsyncResultResponse.GetAsyncResult_Data();
			data.Status = context.StringValue("GetAsyncResult.Data.Status");
			data.BatchSize = context.StringValue("GetAsyncResult.Data.BatchSize");
			data.Finish = context.BooleanValue("GetAsyncResult.Data.Finish");
			data.Progress = context.FloatValue("GetAsyncResult.Data.Progress");
			data.Message = context.StringValue("GetAsyncResult.Data.Message");
			data.Completed = context.BooleanValue("GetAsyncResult.Data.Completed");
			data.TotalUsedTime = context.LongValue("GetAsyncResult.Data.TotalUsedTime");
			data.Result = context.StringValue("GetAsyncResult.Data.Result");
			data.Code = context.StringValue("GetAsyncResult.Data.Code");
			getAsyncResultResponse.Data = data;
        
			return getAsyncResultResponse;
        }
    }
}
