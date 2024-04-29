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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterScenesResponseUnmarshaller
    {
        public static DescribeCasterScenesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterScenesResponse describeCasterScenesResponse = new DescribeCasterScenesResponse();

			describeCasterScenesResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterScenesResponse.RequestId = _ctx.StringValue("DescribeCasterScenes.RequestId");
			describeCasterScenesResponse.Total = _ctx.IntegerValue("DescribeCasterScenes.Total");

			List<DescribeCasterScenesResponse.DescribeCasterScenes_Scene> describeCasterScenesResponse_sceneList = new List<DescribeCasterScenesResponse.DescribeCasterScenes_Scene>();
			for (int i = 0; i < _ctx.Length("DescribeCasterScenes.SceneList.Length"); i++) {
				DescribeCasterScenesResponse.DescribeCasterScenes_Scene scene = new DescribeCasterScenesResponse.DescribeCasterScenes_Scene();
				scene.LayoutId = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].LayoutId");
				scene.OutputType = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].OutputType");
				scene.RtsUrl = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].RtsUrl");
				scene.SceneId = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].SceneId");
				scene.SceneName = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].SceneName");
				scene.Status = _ctx.IntegerValue("DescribeCasterScenes.SceneList["+ i +"].Status");
				scene.StreamUrl = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].StreamUrl");

				List<string> scene_componentIds = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeCasterScenes.SceneList["+ i +"].ComponentIds.Length"); j++) {
					scene_componentIds.Add(_ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].ComponentIds["+ j +"]"));
				}
				scene.ComponentIds = scene_componentIds;

				List<DescribeCasterScenesResponse.DescribeCasterScenes_Scene.DescribeCasterScenes_StreamInfo> scene_streamInfos = new List<DescribeCasterScenesResponse.DescribeCasterScenes_Scene.DescribeCasterScenes_StreamInfo>();
				for (int j = 0; j < _ctx.Length("DescribeCasterScenes.SceneList["+ i +"].StreamInfos.Length"); j++) {
					DescribeCasterScenesResponse.DescribeCasterScenes_Scene.DescribeCasterScenes_StreamInfo streamInfo = new DescribeCasterScenesResponse.DescribeCasterScenes_Scene.DescribeCasterScenes_StreamInfo();
					streamInfo.OutputStreamUrl = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].StreamInfos["+ j +"].OutputStreamUrl");
					streamInfo.TranscodeConfig = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].StreamInfos["+ j +"].TranscodeConfig");
					streamInfo.VideoFormat = _ctx.StringValue("DescribeCasterScenes.SceneList["+ i +"].StreamInfos["+ j +"].VideoFormat");

					scene_streamInfos.Add(streamInfo);
				}
				scene.StreamInfos = scene_streamInfos;

				describeCasterScenesResponse_sceneList.Add(scene);
			}
			describeCasterScenesResponse.SceneList = describeCasterScenesResponse_sceneList;
        
			return describeCasterScenesResponse;
        }
    }
}
