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
using Aliyun.Acs.Qualitycheck.Model.V20190115;

namespace Aliyun.Acs.Qualitycheck.Transform.V20190115
{
    public class GetScoreInfoResponseUnmarshaller
    {
        public static GetScoreInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetScoreInfoResponse getScoreInfoResponse = new GetScoreInfoResponse();

			getScoreInfoResponse.HttpResponse = _ctx.HttpResponse;
			getScoreInfoResponse.RequestId = _ctx.StringValue("GetScoreInfo.RequestId");
			getScoreInfoResponse.Success = _ctx.BooleanValue("GetScoreInfo.Success");
			getScoreInfoResponse.Code = _ctx.StringValue("GetScoreInfo.Code");
			getScoreInfoResponse.Message = _ctx.StringValue("GetScoreInfo.Message");

			List<GetScoreInfoResponse.GetScoreInfo_ScorePo> getScoreInfoResponse_data = new List<GetScoreInfoResponse.GetScoreInfo_ScorePo>();
			for (int i = 0; i < _ctx.Length("GetScoreInfo.Data.Length"); i++) {
				GetScoreInfoResponse.GetScoreInfo_ScorePo scorePo = new GetScoreInfoResponse.GetScoreInfo_ScorePo();
				scorePo.ScoreId = _ctx.IntegerValue("GetScoreInfo.Data["+ i +"].ScoreId");
				scorePo.ScoreName = _ctx.StringValue("GetScoreInfo.Data["+ i +"].ScoreName");

				List<GetScoreInfoResponse.GetScoreInfo_ScorePo.GetScoreInfo_ScoreParam> scorePo_scoreInfos = new List<GetScoreInfoResponse.GetScoreInfo_ScorePo.GetScoreInfo_ScoreParam>();
				for (int j = 0; j < _ctx.Length("GetScoreInfo.Data["+ i +"].ScoreInfos.Length"); j++) {
					GetScoreInfoResponse.GetScoreInfo_ScorePo.GetScoreInfo_ScoreParam scoreParam = new GetScoreInfoResponse.GetScoreInfo_ScorePo.GetScoreInfo_ScoreParam();
					scoreParam.ScoreNum = _ctx.IntegerValue("GetScoreInfo.Data["+ i +"].ScoreInfos["+ j +"].ScoreNum");
					scoreParam.ScoreSubId = _ctx.IntegerValue("GetScoreInfo.Data["+ i +"].ScoreInfos["+ j +"].ScoreSubId");
					scoreParam.ScoreSubName = _ctx.StringValue("GetScoreInfo.Data["+ i +"].ScoreInfos["+ j +"].ScoreSubName");
					scoreParam.ScoreType = _ctx.IntegerValue("GetScoreInfo.Data["+ i +"].ScoreInfos["+ j +"].ScoreType");

					scorePo_scoreInfos.Add(scoreParam);
				}
				scorePo.ScoreInfos = scorePo_scoreInfos;

				getScoreInfoResponse_data.Add(scorePo);
			}
			getScoreInfoResponse.Data = getScoreInfoResponse_data;
        
			return getScoreInfoResponse;
        }
    }
}
