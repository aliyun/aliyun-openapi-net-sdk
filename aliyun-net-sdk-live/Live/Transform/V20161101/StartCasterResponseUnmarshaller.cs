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
    public class StartCasterResponseUnmarshaller
    {
        public static StartCasterResponse Unmarshall(UnmarshallerContext _ctx)
        {
			StartCasterResponse startCasterResponse = new StartCasterResponse();

			startCasterResponse.HttpResponse = _ctx.HttpResponse;
			startCasterResponse.RequestId = _ctx.StringValue("StartCaster.RequestId");

			List<StartCasterResponse.StartCaster_SceneInfo> startCasterResponse_pvwSceneInfos = new List<StartCasterResponse.StartCaster_SceneInfo>();
			for (int i = 0; i < _ctx.Length("StartCaster.PvwSceneInfos.Length"); i++) {
				StartCasterResponse.StartCaster_SceneInfo sceneInfo = new StartCasterResponse.StartCaster_SceneInfo();
				sceneInfo.SceneId = _ctx.StringValue("StartCaster.PvwSceneInfos["+ i +"].SceneId");
				sceneInfo.StreamUrl = _ctx.StringValue("StartCaster.PvwSceneInfos["+ i +"].StreamUrl");

				startCasterResponse_pvwSceneInfos.Add(sceneInfo);
			}
			startCasterResponse.PvwSceneInfos = startCasterResponse_pvwSceneInfos;

			List<StartCasterResponse.StartCaster_SceneInfo1> startCasterResponse_pgmSceneInfos = new List<StartCasterResponse.StartCaster_SceneInfo1>();
			for (int i = 0; i < _ctx.Length("StartCaster.PgmSceneInfos.Length"); i++) {
				StartCasterResponse.StartCaster_SceneInfo1 sceneInfo1 = new StartCasterResponse.StartCaster_SceneInfo1();
				sceneInfo1.SceneId = _ctx.StringValue("StartCaster.PgmSceneInfos["+ i +"].SceneId");
				sceneInfo1.StreamUrl = _ctx.StringValue("StartCaster.PgmSceneInfos["+ i +"].StreamUrl");

				List<StartCasterResponse.StartCaster_SceneInfo1.StartCaster_StreamInfo> sceneInfo1_streamInfos = new List<StartCasterResponse.StartCaster_SceneInfo1.StartCaster_StreamInfo>();
				for (int j = 0; j < _ctx.Length("StartCaster.PgmSceneInfos["+ i +"].StreamInfos.Length"); j++) {
					StartCasterResponse.StartCaster_SceneInfo1.StartCaster_StreamInfo streamInfo = new StartCasterResponse.StartCaster_SceneInfo1.StartCaster_StreamInfo();
					streamInfo.TranscodeConfig = _ctx.StringValue("StartCaster.PgmSceneInfos["+ i +"].StreamInfos["+ j +"].TranscodeConfig");
					streamInfo.VideoFormat = _ctx.StringValue("StartCaster.PgmSceneInfos["+ i +"].StreamInfos["+ j +"].VideoFormat");
					streamInfo.OutputStreamUrl = _ctx.StringValue("StartCaster.PgmSceneInfos["+ i +"].StreamInfos["+ j +"].OutputStreamUrl");

					sceneInfo1_streamInfos.Add(streamInfo);
				}
				sceneInfo1.StreamInfos = sceneInfo1_streamInfos;

				startCasterResponse_pgmSceneInfos.Add(sceneInfo1);
			}
			startCasterResponse.PgmSceneInfos = startCasterResponse_pgmSceneInfos;
        
			return startCasterResponse;
        }
    }
}
