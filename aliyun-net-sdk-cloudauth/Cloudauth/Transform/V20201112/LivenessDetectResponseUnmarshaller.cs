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
using Aliyun.Acs.Cloudauth.Model.V20201112;

namespace Aliyun.Acs.Cloudauth.Transform.V20201112
{
    public class LivenessDetectResponseUnmarshaller
    {
        public static LivenessDetectResponse Unmarshall(UnmarshallerContext _ctx)
        {
			LivenessDetectResponse livenessDetectResponse = new LivenessDetectResponse();

			livenessDetectResponse.HttpResponse = _ctx.HttpResponse;
			livenessDetectResponse.RequestId = _ctx.StringValue("LivenessDetect.RequestId");
			livenessDetectResponse.Code = _ctx.StringValue("LivenessDetect.Code");
			livenessDetectResponse.Message = _ctx.StringValue("LivenessDetect.Message");

			LivenessDetectResponse.LivenessDetect_ResultObject resultObject = new LivenessDetectResponse.LivenessDetect_ResultObject();
			resultObject.Passed = _ctx.StringValue("LivenessDetect.ResultObject.Passed");
			resultObject.Score = _ctx.FloatValue("LivenessDetect.ResultObject.Score");
			resultObject.FrameUrl = _ctx.StringValue("LivenessDetect.ResultObject.FrameUrl");
			livenessDetectResponse.ResultObject = resultObject;
        
			return livenessDetectResponse;
        }
    }
}
