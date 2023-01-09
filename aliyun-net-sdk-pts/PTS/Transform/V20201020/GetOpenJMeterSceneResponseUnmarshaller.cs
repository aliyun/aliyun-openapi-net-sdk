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
    public class GetOpenJMeterSceneResponseUnmarshaller
    {
        public static GetOpenJMeterSceneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetOpenJMeterSceneResponse getOpenJMeterSceneResponse = new GetOpenJMeterSceneResponse();

			getOpenJMeterSceneResponse.HttpResponse = _ctx.HttpResponse;
			getOpenJMeterSceneResponse.Message = _ctx.StringValue("GetOpenJMeterScene.Message");
			getOpenJMeterSceneResponse.RequestId = _ctx.StringValue("GetOpenJMeterScene.RequestId");
			getOpenJMeterSceneResponse.HttpStatusCode = _ctx.IntegerValue("GetOpenJMeterScene.HttpStatusCode");
			getOpenJMeterSceneResponse.Code = _ctx.StringValue("GetOpenJMeterScene.Code");
			getOpenJMeterSceneResponse.Success = _ctx.BooleanValue("GetOpenJMeterScene.Success");

			GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene scene = new GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene();
			scene.SceneName = _ctx.StringValue("GetOpenJMeterScene.Scene.SceneName");
			scene.SceneId = _ctx.StringValue("GetOpenJMeterScene.Scene.SceneId");
			scene.EnvironmentId = _ctx.StringValue("GetOpenJMeterScene.Scene.EnvironmentId");
			scene.TestFile = _ctx.StringValue("GetOpenJMeterScene.Scene.TestFile");
			scene.IsVpcTest = _ctx.BooleanValue("GetOpenJMeterScene.Scene.IsVpcTest");
			scene.Duration = _ctx.IntegerValue("GetOpenJMeterScene.Scene.Duration");
			scene.Concurrency = _ctx.IntegerValue("GetOpenJMeterScene.Scene.Concurrency");
			scene.AgentCount = _ctx.IntegerValue("GetOpenJMeterScene.Scene.AgentCount");
			scene.RampUp = _ctx.IntegerValue("GetOpenJMeterScene.Scene.RampUp");
			scene.Steps = _ctx.IntegerValue("GetOpenJMeterScene.Scene.Steps");
			scene.RegionId = _ctx.StringValue("GetOpenJMeterScene.Scene.RegionId");
			scene.VpcId = _ctx.StringValue("GetOpenJMeterScene.Scene.VpcId");
			scene.SecurityGroupId = _ctx.StringValue("GetOpenJMeterScene.Scene.SecurityGroupId");
			scene.VSwitchId = _ctx.StringValue("GetOpenJMeterScene.Scene.VSwitchId");
			scene.SyncTimerType = _ctx.StringValue("GetOpenJMeterScene.Scene.SyncTimerType");
			scene.ConstantThroughputTimerType = _ctx.StringValue("GetOpenJMeterScene.Scene.ConstantThroughputTimerType");
			scene.Pool = _ctx.StringValue("GetOpenJMeterScene.Scene.Pool");
			scene.Mode = _ctx.StringValue("GetOpenJMeterScene.Scene.Mode");
			scene.StartRps = _ctx.IntegerValue("GetOpenJMeterScene.Scene.StartRps");
			scene.MaxRps = _ctx.IntegerValue("GetOpenJMeterScene.Scene.MaxRps");
			scene.StartConcurrency = _ctx.IntegerValue("GetOpenJMeterScene.Scene.StartConcurrency");

			GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_BaseInfo baseInfo = new GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_BaseInfo();
			baseInfo.Remark = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.Remark");
			baseInfo.Principal = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.Principal");
			baseInfo.Resource = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.Resource");
			baseInfo.CreateName = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.CreateName");
			baseInfo.ModifyName = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.ModifyName");
			baseInfo.OperateType = _ctx.StringValue("GetOpenJMeterScene.Scene.BaseInfo.OperateType");
			scene.BaseInfo = baseInfo;

			GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_DnsCacheConfig dnsCacheConfig = new GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_DnsCacheConfig();
			dnsCacheConfig.ClearCacheEachIteration = _ctx.BooleanValue("GetOpenJMeterScene.Scene.DnsCacheConfig.ClearCacheEachIteration");
			dnsCacheConfig.HostTable = _ctx.StringValue("GetOpenJMeterScene.Scene.DnsCacheConfig.HostTable");

			List<string> dnsCacheConfig_dnsServers = new List<string>();
			for (int i = 0; i < _ctx.Length("GetOpenJMeterScene.Scene.DnsCacheConfig.DnsServers.Length"); i++) {
				dnsCacheConfig_dnsServers.Add(_ctx.StringValue("GetOpenJMeterScene.Scene.DnsCacheConfig.DnsServers["+ i +"]"));
			}
			dnsCacheConfig.DnsServers = dnsCacheConfig_dnsServers;
			scene.DnsCacheConfig = dnsCacheConfig;

			List<GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_FileListItem> scene_fileList = new List<GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_FileListItem>();
			for (int i = 0; i < _ctx.Length("GetOpenJMeterScene.Scene.FileList.Length"); i++) {
				GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_FileListItem fileListItem = new GetOpenJMeterSceneResponse.GetOpenJMeterScene_Scene.GetOpenJMeterScene_FileListItem();
				fileListItem.Id = _ctx.LongValue("GetOpenJMeterScene.Scene.FileList["+ i +"].Id");
				fileListItem.FileName = _ctx.StringValue("GetOpenJMeterScene.Scene.FileList["+ i +"].FileName");
				fileListItem.FileOssAddress = _ctx.StringValue("GetOpenJMeterScene.Scene.FileList["+ i +"].FileOssAddress");
				fileListItem.SplitCsv = _ctx.BooleanValue("GetOpenJMeterScene.Scene.FileList["+ i +"].SplitCsv");
				fileListItem.Md5 = _ctx.StringValue("GetOpenJMeterScene.Scene.FileList["+ i +"].Md5");
				fileListItem.FileSize = _ctx.LongValue("GetOpenJMeterScene.Scene.FileList["+ i +"].FileSize");
				fileListItem.FileType = _ctx.StringValue("GetOpenJMeterScene.Scene.FileList["+ i +"].FileType");

				scene_fileList.Add(fileListItem);
			}
			scene.FileList = scene_fileList;
			getOpenJMeterSceneResponse.Scene = scene;
        
			return getOpenJMeterSceneResponse;
        }
    }
}
