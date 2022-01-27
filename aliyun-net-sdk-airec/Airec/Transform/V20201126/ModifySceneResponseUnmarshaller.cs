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
    public class ModifySceneResponseUnmarshaller
    {
        public static ModifySceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ModifySceneResponse modifySceneResponse = new ModifySceneResponse();

			modifySceneResponse.HttpResponse = _ctx.HttpResponse;
			modifySceneResponse.RequestId = _ctx.StringValue("ModifyScene.requestId");
			modifySceneResponse.Code = _ctx.StringValue("ModifyScene.code");
			modifySceneResponse.Message = _ctx.StringValue("ModifyScene.message");

			ModifySceneResponse.ModifyScene_Result result = new ModifySceneResponse.ModifyScene_Result();
			result.GmtCreate = _ctx.StringValue("ModifyScene.Result.gmtCreate");
			result.GmtModified = _ctx.StringValue("ModifyScene.Result.gmtModified");
			result.SceneId = _ctx.StringValue("ModifyScene.Result.sceneId");
			result.Status = _ctx.StringValue("ModifyScene.Result.status");
			modifySceneResponse.Result = result;
        
			return modifySceneResponse;
        }
    }
}
