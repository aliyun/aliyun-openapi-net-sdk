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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class RestartAsrTaskResponseUnmarshaller
    {
        public static RestartAsrTaskResponse Unmarshall(UnmarshallerContext _ctx)
        {
			RestartAsrTaskResponse restartAsrTaskResponse = new RestartAsrTaskResponse();

			restartAsrTaskResponse.HttpResponse = _ctx.HttpResponse;
			restartAsrTaskResponse.RequestId = _ctx.StringValue("RestartAsrTask.RequestId");
			restartAsrTaskResponse.Success = _ctx.BooleanValue("RestartAsrTask.Success");
			restartAsrTaskResponse.Code = _ctx.StringValue("RestartAsrTask.Code");
			restartAsrTaskResponse.Message = _ctx.StringValue("RestartAsrTask.Message");

			List<RestartAsrTaskResponse.RestartAsrTask_RestartResult> restartAsrTaskResponse_data = new List<RestartAsrTaskResponse.RestartAsrTask_RestartResult>();
			for (int i = 0; i < _ctx.Length("RestartAsrTask.Data.Length"); i++) {
				RestartAsrTaskResponse.RestartAsrTask_RestartResult restartResult = new RestartAsrTaskResponse.RestartAsrTask_RestartResult();
				restartResult.Success = _ctx.BooleanValue("RestartAsrTask.Data["+ i +"].Success");
				restartResult.Data = _ctx.StringValue("RestartAsrTask.Data["+ i +"].Data");
				restartResult.Message = _ctx.StringValue("RestartAsrTask.Data["+ i +"].Message");

				restartAsrTaskResponse_data.Add(restartResult);
			}
			restartAsrTaskResponse.Data = restartAsrTaskResponse_data;
        
			return restartAsrTaskResponse;
        }
    }
}
