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
    public class GetJMeterSceneRunningDataResponseUnmarshaller
    {
        public static GetJMeterSceneRunningDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetJMeterSceneRunningDataResponse getJMeterSceneRunningDataResponse = new GetJMeterSceneRunningDataResponse();

			getJMeterSceneRunningDataResponse.HttpResponse = _ctx.HttpResponse;
			getJMeterSceneRunningDataResponse.Message = _ctx.StringValue("GetJMeterSceneRunningData.Message");
			getJMeterSceneRunningDataResponse.RequestId = _ctx.StringValue("GetJMeterSceneRunningData.RequestId");
			getJMeterSceneRunningDataResponse.Code = _ctx.StringValue("GetJMeterSceneRunningData.Code");
			getJMeterSceneRunningDataResponse.Success = _ctx.BooleanValue("GetJMeterSceneRunningData.Success");
			getJMeterSceneRunningDataResponse.HttpStatusCode = _ctx.IntegerValue("GetJMeterSceneRunningData.HttpStatusCode");
			getJMeterSceneRunningDataResponse.DocumentUrl = _ctx.StringValue("GetJMeterSceneRunningData.DocumentUrl");

			GetJMeterSceneRunningDataResponse.GetJMeterSceneRunningData_RunningData runningData = new GetJMeterSceneRunningDataResponse.GetJMeterSceneRunningData_RunningData();
			runningData.SceneId = _ctx.StringValue("GetJMeterSceneRunningData.RunningData.SceneId");
			runningData.SceneName = _ctx.StringValue("GetJMeterSceneRunningData.RunningData.SceneName");
			runningData.HoldFor = _ctx.IntegerValue("GetJMeterSceneRunningData.RunningData.HoldFor");
			runningData.AgentCount = _ctx.IntegerValue("GetJMeterSceneRunningData.RunningData.AgentCount");
			runningData.Concurrency = _ctx.IntegerValue("GetJMeterSceneRunningData.RunningData.Concurrency");
			runningData.HasReport = _ctx.BooleanValue("GetJMeterSceneRunningData.RunningData.HasReport");
			runningData.IsDebugging = _ctx.BooleanValue("GetJMeterSceneRunningData.RunningData.IsDebugging");
			runningData.Status = _ctx.StringValue("GetJMeterSceneRunningData.RunningData.Status");
			runningData.Vum = _ctx.LongValue("GetJMeterSceneRunningData.RunningData.Vum");
			runningData.StartTimeTS = _ctx.LongValue("GetJMeterSceneRunningData.RunningData.StartTimeTS");
			runningData.StageName = _ctx.StringValue("GetJMeterSceneRunningData.RunningData.StageName");
			runningData.AllSampleStat = _ctx.StringValue("GetJMeterSceneRunningData.RunningData.AllSampleStat");

			List<string> runningData_agentIdList = new List<string>();
			for (int i = 0; i < _ctx.Length("GetJMeterSceneRunningData.RunningData.AgentIdList.Length"); i++) {
				runningData_agentIdList.Add(_ctx.StringValue("GetJMeterSceneRunningData.RunningData.AgentIdList["+ i +"]"));
			}
			runningData.AgentIdList = runningData_agentIdList;

			List<Dictionary<string, string>> runningData_sampleStatList = new List<Dictionary<string, string>>();
			for (int i = 0; i < _ctx.Length("GetJMeterSceneRunningData.RunningData.SampleStatList.Length"); i++) {
				Dictionary<string, string> tmp = new Dictionary<string, string>() { };
				foreach (var _item in _ctx.ResponseDictionary){
					string prefix = "GetJMeterSceneRunningData.RunningData.SampleStatList["+ i +"].";
					if (_item.Key.IndexOf(prefix) == 0){
						tmp.Add(_item.Key.Substring(prefix.Length), _item.Value);
					}
				}
				if (tmp.Count > 0){
					runningData_sampleStatList.Add(tmp);
				}
			}
			runningData.SampleStatList = runningData_sampleStatList;
			getJMeterSceneRunningDataResponse.RunningData = runningData;
        
			return getJMeterSceneRunningDataResponse;
        }
    }
}
