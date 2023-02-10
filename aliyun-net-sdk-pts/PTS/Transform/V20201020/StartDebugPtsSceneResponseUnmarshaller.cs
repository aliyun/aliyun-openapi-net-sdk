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
    public class StartDebugPtsSceneResponseUnmarshaller
    {
        public static StartDebugPtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartDebugPtsSceneResponse startDebugPtsSceneResponse = new StartDebugPtsSceneResponse();

			startDebugPtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			startDebugPtsSceneResponse.RequestId = _ctx.StringValue("StartDebugPtsScene.RequestId");
			startDebugPtsSceneResponse.Message = _ctx.StringValue("StartDebugPtsScene.Message");
			startDebugPtsSceneResponse.PlanId = _ctx.StringValue("StartDebugPtsScene.PlanId");
			startDebugPtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("StartDebugPtsScene.HttpStatusCode");
			startDebugPtsSceneResponse.Code = _ctx.StringValue("StartDebugPtsScene.Code");
			startDebugPtsSceneResponse.Success = _ctx.BooleanValue("StartDebugPtsScene.Success");
        
			return startDebugPtsSceneResponse;
        }
    }
}
