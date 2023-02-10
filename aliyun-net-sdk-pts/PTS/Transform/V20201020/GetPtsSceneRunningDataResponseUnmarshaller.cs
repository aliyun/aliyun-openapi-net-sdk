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
    public class GetPtsSceneRunningDataResponseUnmarshaller
    {
        public static GetPtsSceneRunningDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPtsSceneRunningDataResponse getPtsSceneRunningDataResponse = new GetPtsSceneRunningDataResponse();

			getPtsSceneRunningDataResponse.HttpResponse = _ctx.HttpResponse;
			getPtsSceneRunningDataResponse.Status = _ctx.IntegerValue("GetPtsSceneRunningData.Status");
			getPtsSceneRunningDataResponse.TotalRequestCount = _ctx.LongValue("GetPtsSceneRunningData.TotalRequestCount");
			getPtsSceneRunningDataResponse.HasReport = _ctx.BooleanValue("GetPtsSceneRunningData.HasReport");
			getPtsSceneRunningDataResponse.ConcurrencyLimit = _ctx.IntegerValue("GetPtsSceneRunningData.ConcurrencyLimit");
			getPtsSceneRunningDataResponse.Message = _ctx.StringValue("GetPtsSceneRunningData.Message");
			getPtsSceneRunningDataResponse.RequestId = _ctx.StringValue("GetPtsSceneRunningData.RequestId");
			getPtsSceneRunningDataResponse.BeginTime = _ctx.LongValue("GetPtsSceneRunningData.BeginTime");
			getPtsSceneRunningDataResponse.Seg90Rt = _ctx.LongValue("GetPtsSceneRunningData.Seg90Rt");
			getPtsSceneRunningDataResponse.ResponseBps = _ctx.StringValue("GetPtsSceneRunningData.ResponseBps");
			getPtsSceneRunningDataResponse.TotalAgents = _ctx.IntegerValue("GetPtsSceneRunningData.TotalAgents");
			getPtsSceneRunningDataResponse.Code = _ctx.StringValue("GetPtsSceneRunningData.Code");
			getPtsSceneRunningDataResponse.Success = _ctx.BooleanValue("GetPtsSceneRunningData.Success");
			getPtsSceneRunningDataResponse.Vum = _ctx.LongValue("GetPtsSceneRunningData.Vum");
			getPtsSceneRunningDataResponse.AverageRt = _ctx.LongValue("GetPtsSceneRunningData.AverageRt");
			getPtsSceneRunningDataResponse.RequestBps = _ctx.StringValue("GetPtsSceneRunningData.RequestBps");
			getPtsSceneRunningDataResponse.FailedBusinessCount = _ctx.LongValue("GetPtsSceneRunningData.FailedBusinessCount");
			getPtsSceneRunningDataResponse.Concurrency = _ctx.IntegerValue("GetPtsSceneRunningData.Concurrency");
			getPtsSceneRunningDataResponse.HttpStatusCode = _ctx.IntegerValue("GetPtsSceneRunningData.HttpStatusCode");
			getPtsSceneRunningDataResponse.FailedRequestCount = _ctx.LongValue("GetPtsSceneRunningData.FailedRequestCount");
			getPtsSceneRunningDataResponse.TpsLimit = _ctx.IntegerValue("GetPtsSceneRunningData.TpsLimit");
			getPtsSceneRunningDataResponse.AliveAgents = _ctx.IntegerValue("GetPtsSceneRunningData.AliveAgents");
			getPtsSceneRunningDataResponse.TotalRealQps = _ctx.IntegerValue("GetPtsSceneRunningData.TotalRealQps");

			List<GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_Location> getPtsSceneRunningDataResponse_agentLocation = new List<GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_Location>();
			for (int i = 0; i < _ctx.Length("GetPtsSceneRunningData.AgentLocation.Length"); i++) {
				GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_Location location = new GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_Location();
				location.Region = _ctx.StringValue("GetPtsSceneRunningData.AgentLocation["+ i +"].Region");
				location.Isp = _ctx.StringValue("GetPtsSceneRunningData.AgentLocation["+ i +"].Isp");
				location.Count = _ctx.IntegerValue("GetPtsSceneRunningData.AgentLocation["+ i +"].Count");
				location.Province = _ctx.StringValue("GetPtsSceneRunningData.AgentLocation["+ i +"].Province");

				getPtsSceneRunningDataResponse_agentLocation.Add(location);
			}
			getPtsSceneRunningDataResponse.AgentLocation = getPtsSceneRunningDataResponse_agentLocation;

			List<GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData> getPtsSceneRunningDataResponse_chainMonitorDataList = new List<GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData>();
			for (int i = 0; i < _ctx.Length("GetPtsSceneRunningData.ChainMonitorDataList.Length"); i++) {
				GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData chainMonitorData = new GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData();
				chainMonitorData.TimePoint = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].TimePoint");
				chainMonitorData.ApiId = _ctx.StringValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].ApiId");
				chainMonitorData.MinRt = _ctx.IntegerValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].MinRt");
				chainMonitorData.Qps2XX = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].Qps2XX");
				chainMonitorData.MaxRt = _ctx.IntegerValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].MaxRt");
				chainMonitorData.ConfigQps = _ctx.IntegerValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].ConfigQps");
				chainMonitorData.FailedCount = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].FailedCount");
				chainMonitorData.FailedQps = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].FailedQps");
				chainMonitorData.AverageRt = _ctx.IntegerValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].AverageRt");
				chainMonitorData.Count2XX = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].Count2XX");
				chainMonitorData.RealQps = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].RealQps");
				chainMonitorData.ApiName = _ctx.StringValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].ApiName");
				chainMonitorData.NodeId = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].NodeId");
				chainMonitorData.Concurrency = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].Concurrency");

				GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData.GetPtsSceneRunningData_CheckPointResult checkPointResult = new GetPtsSceneRunningDataResponse.GetPtsSceneRunningData_ChainMonitorData.GetPtsSceneRunningData_CheckPointResult();
				checkPointResult.SucceedBusinessCount = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].CheckPointResult.SucceedBusinessCount");
				checkPointResult.SucceedBusinessQps = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].CheckPointResult.SucceedBusinessQps");
				checkPointResult.FailedBusinessCount = _ctx.LongValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].CheckPointResult.FailedBusinessCount");
				checkPointResult.FailedBusinessQps = _ctx.FloatValue("GetPtsSceneRunningData.ChainMonitorDataList["+ i +"].CheckPointResult.FailedBusinessQps");
				chainMonitorData.CheckPointResult = checkPointResult;

				getPtsSceneRunningDataResponse_chainMonitorDataList.Add(chainMonitorData);
			}
			getPtsSceneRunningDataResponse.ChainMonitorDataList = getPtsSceneRunningDataResponse_chainMonitorDataList;
        
			return getPtsSceneRunningDataResponse;
        }
    }
}
