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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DeleteSceneResponseUnmarshaller
    {
        public static DeleteSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteSceneResponse deleteSceneResponse = new DeleteSceneResponse();

			deleteSceneResponse.HttpResponse = _ctx.HttpResponse;
			deleteSceneResponse.RequestId = _ctx.StringValue("DeleteScene.requestId");
			deleteSceneResponse.Code = _ctx.StringValue("DeleteScene.code");
			deleteSceneResponse.Message = _ctx.StringValue("DeleteScene.message");

			DeleteSceneResponse.DeleteScene_Result result = new DeleteSceneResponse.DeleteScene_Result();
			result.SceneId = _ctx.StringValue("DeleteScene.Result.sceneId");
			deleteSceneResponse.Result = result;
        
			return deleteSceneResponse;
        }
    }
}
