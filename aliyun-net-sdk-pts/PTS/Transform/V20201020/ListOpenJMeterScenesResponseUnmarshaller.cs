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
    public class ListOpenJMeterScenesResponseUnmarshaller
    {
        public static ListOpenJMeterScenesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListOpenJMeterScenesResponse listOpenJMeterScenesResponse = new ListOpenJMeterScenesResponse();

			listOpenJMeterScenesResponse.HttpResponse = _ctx.HttpResponse;
			listOpenJMeterScenesResponse.Message = _ctx.StringValue("ListOpenJMeterScenes.Message");
			listOpenJMeterScenesResponse.RequestId = _ctx.StringValue("ListOpenJMeterScenes.RequestId");
			listOpenJMeterScenesResponse.HttpStatusCode = _ctx.IntegerValue("ListOpenJMeterScenes.HttpStatusCode");
			listOpenJMeterScenesResponse.Code = _ctx.StringValue("ListOpenJMeterScenes.Code");
			listOpenJMeterScenesResponse.Success = _ctx.BooleanValue("ListOpenJMeterScenes.Success");
			listOpenJMeterScenesResponse.PageNumber = _ctx.IntegerValue("ListOpenJMeterScenes.PageNumber");
			listOpenJMeterScenesResponse.PageSize = _ctx.IntegerValue("ListOpenJMeterScenes.PageSize");
			listOpenJMeterScenesResponse.TotalCount = _ctx.LongValue("ListOpenJMeterScenes.TotalCount");

			List<ListOpenJMeterScenesResponse.ListOpenJMeterScenes_JMeterSceneItem> listOpenJMeterScenesResponse_jMeterScene = new List<ListOpenJMeterScenesResponse.ListOpenJMeterScenes_JMeterSceneItem>();
			for (int i = 0; i < _ctx.Length("ListOpenJMeterScenes.JMeterScene.Length"); i++) {
				ListOpenJMeterScenesResponse.ListOpenJMeterScenes_JMeterSceneItem jMeterSceneItem = new ListOpenJMeterScenesResponse.ListOpenJMeterScenes_JMeterSceneItem();
				jMeterSceneItem.DurationStr = _ctx.StringValue("ListOpenJMeterScenes.JMeterScene["+ i +"].DurationStr");
				jMeterSceneItem.SceneId = _ctx.StringValue("ListOpenJMeterScenes.JMeterScene["+ i +"].SceneId");
				jMeterSceneItem.SceneName = _ctx.StringValue("ListOpenJMeterScenes.JMeterScene["+ i +"].SceneName");

				listOpenJMeterScenesResponse_jMeterScene.Add(jMeterSceneItem);
			}
			listOpenJMeterScenesResponse.JMeterScene = listOpenJMeterScenesResponse_jMeterScene;
        
			return listOpenJMeterScenesResponse;
        }
    }
}
