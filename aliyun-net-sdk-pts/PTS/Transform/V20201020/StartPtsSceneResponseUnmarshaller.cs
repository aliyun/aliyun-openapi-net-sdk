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
    public class StartPtsSceneResponseUnmarshaller
    {
        public static StartPtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartPtsSceneResponse startPtsSceneResponse = new StartPtsSceneResponse();

			startPtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			startPtsSceneResponse.RequestId = _ctx.StringValue("StartPtsScene.RequestId");
			startPtsSceneResponse.Message = _ctx.StringValue("StartPtsScene.Message");
			startPtsSceneResponse.PlanId = _ctx.StringValue("StartPtsScene.PlanId");
			startPtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("StartPtsScene.HttpStatusCode");
			startPtsSceneResponse.Code = _ctx.StringValue("StartPtsScene.Code");
			startPtsSceneResponse.Success = _ctx.BooleanValue("StartPtsScene.Success");
        
			return startPtsSceneResponse;
        }
    }
}
