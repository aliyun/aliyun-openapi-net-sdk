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
    public class CreatePtsSceneResponseUnmarshaller
    {
        public static CreatePtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreatePtsSceneResponse createPtsSceneResponse = new CreatePtsSceneResponse();

			createPtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			createPtsSceneResponse.SceneId = _ctx.StringValue("CreatePtsScene.SceneId");
			createPtsSceneResponse.RequestId = _ctx.StringValue("CreatePtsScene.RequestId");
			createPtsSceneResponse.Message = _ctx.StringValue("CreatePtsScene.Message");
			createPtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("CreatePtsScene.HttpStatusCode");
			createPtsSceneResponse.Code = _ctx.StringValue("CreatePtsScene.Code");
			createPtsSceneResponse.Success = _ctx.BooleanValue("CreatePtsScene.Success");
        
			return createPtsSceneResponse;
        }
    }
}
