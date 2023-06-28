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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class DuplexDecisionResponseUnmarshaller
    {
        public static DuplexDecisionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DuplexDecisionResponse duplexDecisionResponse = new DuplexDecisionResponse();

			duplexDecisionResponse.HttpResponse = _ctx.HttpResponse;
			duplexDecisionResponse.Code = _ctx.StringValue("DuplexDecision.Code");
			duplexDecisionResponse.Message = _ctx.StringValue("DuplexDecision.Message");
			duplexDecisionResponse.Success = _ctx.StringValue("DuplexDecision.Success");
			duplexDecisionResponse.RequestId = _ctx.StringValue("DuplexDecision.RequestId");

			DuplexDecisionResponse.DuplexDecision_Data data = new DuplexDecisionResponse.DuplexDecision_Data();
			data.ActionType = _ctx.StringValue("DuplexDecision.Data.ActionType");
			data.OutputText = _ctx.StringValue("DuplexDecision.Data.OutputText");
			data.GrabType = _ctx.StringValue("DuplexDecision.Data.GrabType");
			duplexDecisionResponse.Data = data;
        
			return duplexDecisionResponse;
        }
    }
}
