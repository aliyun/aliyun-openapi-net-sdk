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
    public class ListPtsSceneResponseUnmarshaller
    {
        public static ListPtsSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPtsSceneResponse listPtsSceneResponse = new ListPtsSceneResponse();

			listPtsSceneResponse.HttpResponse = _ctx.HttpResponse;
			listPtsSceneResponse.Message = _ctx.StringValue("ListPtsScene.Message");
			listPtsSceneResponse.RequestId = _ctx.StringValue("ListPtsScene.RequestId");
			listPtsSceneResponse.HttpStatusCode = _ctx.IntegerValue("ListPtsScene.HttpStatusCode");
			listPtsSceneResponse.Code = _ctx.StringValue("ListPtsScene.Code");
			listPtsSceneResponse.Success = _ctx.BooleanValue("ListPtsScene.Success");

			List<ListPtsSceneResponse.ListPtsScene_SceneView> listPtsSceneResponse_sceneViewList = new List<ListPtsSceneResponse.ListPtsScene_SceneView>();
			for (int i = 0; i < _ctx.Length("ListPtsScene.SceneViewList.Length"); i++) {
				ListPtsSceneResponse.ListPtsScene_SceneView sceneView = new ListPtsSceneResponse.ListPtsScene_SceneView();
				sceneView.CreateTime = _ctx.StringValue("ListPtsScene.SceneViewList["+ i +"].CreateTime");
				sceneView.SceneId = _ctx.StringValue("ListPtsScene.SceneViewList["+ i +"].SceneId");
				sceneView.SceneName = _ctx.StringValue("ListPtsScene.SceneViewList["+ i +"].SceneName");

				listPtsSceneResponse_sceneViewList.Add(sceneView);
			}
			listPtsSceneResponse.SceneViewList = listPtsSceneResponse_sceneViewList;
        
			return listPtsSceneResponse;
        }
    }
}
