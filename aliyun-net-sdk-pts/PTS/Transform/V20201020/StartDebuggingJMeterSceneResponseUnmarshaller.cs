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
using Aliyun.Acs.PTS.Model.V20201020;

namespace Aliyun.Acs.PTS.Transform.V20201020
{
    public class StartDebuggingJMeterSceneResponseUnmarshaller
    {
        public static StartDebuggingJMeterSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartDebuggingJMeterSceneResponse startDebuggingJMeterSceneResponse = new StartDebuggingJMeterSceneResponse();

			startDebuggingJMeterSceneResponse.HttpResponse = _ctx.HttpResponse;
			startDebuggingJMeterSceneResponse.RequestId = _ctx.StringValue("StartDebuggingJMeterScene.RequestId");
			startDebuggingJMeterSceneResponse.Message = _ctx.StringValue("StartDebuggingJMeterScene.Message");
			startDebuggingJMeterSceneResponse.ReportId = _ctx.StringValue("StartDebuggingJMeterScene.ReportId");
			startDebuggingJMeterSceneResponse.HttpStatusCode = _ctx.IntegerValue("StartDebuggingJMeterScene.HttpStatusCode");
			startDebuggingJMeterSceneResponse.Code = _ctx.StringValue("StartDebuggingJMeterScene.Code");
			startDebuggingJMeterSceneResponse.Success = _ctx.BooleanValue("StartDebuggingJMeterScene.Success");
        
			return startDebuggingJMeterSceneResponse;
        }
    }
}
