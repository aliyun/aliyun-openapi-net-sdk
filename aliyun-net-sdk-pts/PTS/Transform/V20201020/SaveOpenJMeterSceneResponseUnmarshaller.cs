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
    public class SaveOpenJMeterSceneResponseUnmarshaller
    {
        public static SaveOpenJMeterSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SaveOpenJMeterSceneResponse saveOpenJMeterSceneResponse = new SaveOpenJMeterSceneResponse();

			saveOpenJMeterSceneResponse.HttpResponse = _ctx.HttpResponse;
			saveOpenJMeterSceneResponse.SceneId = _ctx.StringValue("SaveOpenJMeterScene.SceneId");
			saveOpenJMeterSceneResponse.RequestId = _ctx.StringValue("SaveOpenJMeterScene.RequestId");
			saveOpenJMeterSceneResponse.Message = _ctx.StringValue("SaveOpenJMeterScene.Message");
			saveOpenJMeterSceneResponse.HttpStatusCode = _ctx.IntegerValue("SaveOpenJMeterScene.HttpStatusCode");
			saveOpenJMeterSceneResponse.Code = _ctx.StringValue("SaveOpenJMeterScene.Code");
			saveOpenJMeterSceneResponse.Success = _ctx.BooleanValue("SaveOpenJMeterScene.Success");
        
			return saveOpenJMeterSceneResponse;
        }
    }
}
