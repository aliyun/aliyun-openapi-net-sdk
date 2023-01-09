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
    public class GetPtsSceneBaseLineResponseUnmarshaller
    {
        public static GetPtsSceneBaseLineResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetPtsSceneBaseLineResponse getPtsSceneBaseLineResponse = new GetPtsSceneBaseLineResponse();

			getPtsSceneBaseLineResponse.HttpResponse = _ctx.HttpResponse;
			getPtsSceneBaseLineResponse.SceneId = _ctx.StringValue("GetPtsSceneBaseLine.SceneId");
			getPtsSceneBaseLineResponse.RequestId = _ctx.StringValue("GetPtsSceneBaseLine.RequestId");
			getPtsSceneBaseLineResponse.Message = _ctx.StringValue("GetPtsSceneBaseLine.Message");
			getPtsSceneBaseLineResponse.HttpStatusCode = _ctx.IntegerValue("GetPtsSceneBaseLine.HttpStatusCode");
			getPtsSceneBaseLineResponse.Code = _ctx.StringValue("GetPtsSceneBaseLine.Code");
			getPtsSceneBaseLineResponse.Success = _ctx.BooleanValue("GetPtsSceneBaseLine.Success");

			GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline baseline = new GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline();
			baseline.Name = _ctx.StringValue("GetPtsSceneBaseLine.Baseline.Name");

			GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_SceneBaseline sceneBaseline = new GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_SceneBaseline();
			sceneBaseline.FailCountBiz = _ctx.LongValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.FailCountBiz");
			sceneBaseline.SuccessRateBiz = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.SuccessRateBiz");
			sceneBaseline.AvgRt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.AvgRt");
			sceneBaseline.FailCountReq = _ctx.LongValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.FailCountReq");
			sceneBaseline.AvgTps = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.AvgTps");
			sceneBaseline.Seg99Rt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.Seg99Rt");
			sceneBaseline.SuccessRateReq = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.SuccessRateReq");
			sceneBaseline.Seg90Rt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.SceneBaseline.Seg90Rt");
			baseline.SceneBaseline = sceneBaseline;

			List<GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_ChainBaselineData> baseline_apiBaselines = new List<GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_ChainBaselineData>();
			for (int i = 0; i < _ctx.Length("GetPtsSceneBaseLine.Baseline.ApiBaselines.Length"); i++) {
				GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_ChainBaselineData chainBaselineData = new GetPtsSceneBaseLineResponse.GetPtsSceneBaseLine_Baseline.GetPtsSceneBaseLine_ChainBaselineData();
				chainBaselineData.FailCountBiz = _ctx.LongValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].FailCountBiz");
				chainBaselineData.AvgTps = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].AvgTps");
				chainBaselineData.MinRt = _ctx.IntegerValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].MinRt");
				chainBaselineData.Seg99Rt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].Seg99Rt");
				chainBaselineData.MaxRt = _ctx.IntegerValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].MaxRt");
				chainBaselineData.Seg90Rt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].Seg90Rt");
				chainBaselineData.SuccessRateBiz = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].SuccessRateBiz");
				chainBaselineData.AvgRt = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].AvgRt");
				chainBaselineData.FailCountReq = _ctx.LongValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].FailCountReq");
				chainBaselineData.Name = _ctx.StringValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].Name");
				chainBaselineData.SuccessRateReq = _ctx.FloatValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].SuccessRateReq");
				chainBaselineData.Id = _ctx.LongValue("GetPtsSceneBaseLine.Baseline.ApiBaselines["+ i +"].Id");

				baseline_apiBaselines.Add(chainBaselineData);
			}
			baseline.ApiBaselines = baseline_apiBaselines;
			getPtsSceneBaseLineResponse.Baseline = baseline;
        
			return getPtsSceneBaseLineResponse;
        }
    }
}
