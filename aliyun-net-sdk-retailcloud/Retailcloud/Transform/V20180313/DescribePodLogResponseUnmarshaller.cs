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
    public class DescribePodLogResponseUnmarshaller
    {
        public static DescribePodLogResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePodLogResponse describePodLogResponse = new DescribePodLogResponse();

			describePodLogResponse.HttpResponse = _ctx.HttpResponse;
			describePodLogResponse.Code = _ctx.IntegerValue("DescribePodLog.Code");
			describePodLogResponse.ErrMsg = _ctx.StringValue("DescribePodLog.ErrMsg");
			describePodLogResponse.RequestId = _ctx.StringValue("DescribePodLog.RequestId");
			describePodLogResponse.Success = _ctx.BooleanValue("DescribePodLog.Success");

			DescribePodLogResponse.DescribePodLog_Result result = new DescribePodLogResponse.DescribePodLog_Result();
			result.DeployOrderName = _ctx.StringValue("DescribePodLog.Result.DeployOrderName");
			result.EnvTypeName = _ctx.StringValue("DescribePodLog.Result.EnvTypeName");

			List<DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC> result_deployStepList = new List<DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC>();
			for (int i = 0; i < _ctx.Length("DescribePodLog.Result.DeployStepList.Length"); i++) {
				DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC deployLogStepRC = new DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC();
				deployLogStepRC.StepName = _ctx.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepName");
				deployLogStepRC.StepCode = _ctx.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepCode");
				deployLogStepRC.StepLog = _ctx.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepLog");
				deployLogStepRC.Status = _ctx.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].Status");

				result_deployStepList.Add(deployLogStepRC);
			}
			result.DeployStepList = result_deployStepList;
			describePodLogResponse.Result = result;
        
			return describePodLogResponse;
        }
    }
}
