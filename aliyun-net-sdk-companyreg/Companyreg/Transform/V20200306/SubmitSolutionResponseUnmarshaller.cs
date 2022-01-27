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
using Aliyun.Acs.companyreg.Model.V20200306;

namespace Aliyun.Acs.companyreg.Transform.V20200306
{
    public class SubmitSolutionResponseUnmarshaller
    {
        public static SubmitSolutionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SubmitSolutionResponse submitSolutionResponse = new SubmitSolutionResponse();

			submitSolutionResponse.HttpResponse = _ctx.HttpResponse;
			submitSolutionResponse.RequestId = _ctx.StringValue("SubmitSolution.RequestId");
			submitSolutionResponse.Success = _ctx.BooleanValue("SubmitSolution.Success");
			submitSolutionResponse.ErrorMsg = _ctx.StringValue("SubmitSolution.ErrorMsg");
			submitSolutionResponse.ErrorCode = _ctx.StringValue("SubmitSolution.ErrorCode");
			submitSolutionResponse.SolutionBizId = _ctx.StringValue("SubmitSolution.SolutionBizId");
			submitSolutionResponse.ConfirmUrl = _ctx.StringValue("SubmitSolution.ConfirmUrl");
        
			return submitSolutionResponse;
        }
    }
}
