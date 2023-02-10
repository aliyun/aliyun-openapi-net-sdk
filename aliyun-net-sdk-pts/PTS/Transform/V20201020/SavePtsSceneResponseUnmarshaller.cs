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
    public class SavePtsSceneResponseUnmarshaller
    {
        public static SavePtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SavePtsSceneResponse savePtsSceneResponse = new SavePtsSceneResponse();

			savePtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			savePtsSceneResponse.Message = _ctx.StringValue("SavePtsScene.Message");
			savePtsSceneResponse.RequestId = _ctx.StringValue("SavePtsScene.RequestId");
			savePtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("SavePtsScene.HttpStatusCode");
			savePtsSceneResponse.Code = _ctx.StringValue("SavePtsScene.Code");
			savePtsSceneResponse.Success = _ctx.BooleanValue("SavePtsScene.Success");
			savePtsSceneResponse.SceneId = _ctx.StringValue("SavePtsScene.SceneId");
        
			return savePtsSceneResponse;
        }
    }
}
