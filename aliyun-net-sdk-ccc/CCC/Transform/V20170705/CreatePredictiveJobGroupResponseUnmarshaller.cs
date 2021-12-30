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
using Aliyun.Acs.CCC.Model.V20170705;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CreatePredictiveJobGroupResponseUnmarshaller
    {
        public static CreatePredictiveJobGroupResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePredictiveJobGroupResponse createPredictiveJobGroupResponse = new CreatePredictiveJobGroupResponse();

			createPredictiveJobGroupResponse.HttpResponse = _ctx.HttpResponse;
			createPredictiveJobGroupResponse.HttpStatusCode = _ctx.IntegerValue("CreatePredictiveJobGroup.HttpStatusCode");
			createPredictiveJobGroupResponse.JobGroupId = _ctx.StringValue("CreatePredictiveJobGroup.JobGroupId");
			createPredictiveJobGroupResponse.RequestId = _ctx.StringValue("CreatePredictiveJobGroup.RequestId");
			createPredictiveJobGroupResponse.Success = _ctx.BooleanValue("CreatePredictiveJobGroup.Success");
			createPredictiveJobGroupResponse.Code = _ctx.StringValue("CreatePredictiveJobGroup.Code");
			createPredictiveJobGroupResponse.Message = _ctx.StringValue("CreatePredictiveJobGroup.Message");
        
			return createPredictiveJobGroupResponse;
        }
    }
}
