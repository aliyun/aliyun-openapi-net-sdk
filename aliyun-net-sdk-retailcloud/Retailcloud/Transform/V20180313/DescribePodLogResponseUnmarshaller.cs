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
        public static DescribePodLogResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePodLogResponse describePodLogResponse = new DescribePodLogResponse();

			describePodLogResponse.HttpResponse = context.HttpResponse;
			describePodLogResponse.Code = context.IntegerValue("DescribePodLog.Code");
			describePodLogResponse.ErrMsg = context.StringValue("DescribePodLog.ErrMsg");
			describePodLogResponse.RequestId = context.StringValue("DescribePodLog.RequestId");
			describePodLogResponse.Success = context.BooleanValue("DescribePodLog.Success");

			DescribePodLogResponse.DescribePodLog_Result result = new DescribePodLogResponse.DescribePodLog_Result();
			result.DeployOrderName = context.StringValue("DescribePodLog.Result.DeployOrderName");
			result.EnvTypeName = context.StringValue("DescribePodLog.Result.EnvTypeName");

			List<DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC> result_deployStepList = new List<DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC>();
			for (int i = 0; i < context.Length("DescribePodLog.Result.DeployStepList.Length"); i++) {
				DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC deployLogStepRC = new DescribePodLogResponse.DescribePodLog_Result.DescribePodLog_DeployLogStepRC();
				deployLogStepRC.StepName = context.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepName");
				deployLogStepRC.StepCode = context.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepCode");
				deployLogStepRC.StepLog = context.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].StepLog");
				deployLogStepRC.Status = context.StringValue("DescribePodLog.Result.DeployStepList["+ i +"].Status");

				result_deployStepList.Add(deployLogStepRC);
			}
			result.DeployStepList = result_deployStepList;
			describePodLogResponse.Result = result;
        
			return describePodLogResponse;
        }
    }
}
