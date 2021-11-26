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
    public class InsertSubScoreForApiResponseUnmarshaller
    {
        public static InsertSubScoreForApiResponse Unmarshall(UnmarshallerContext _ctx)
        {
			InsertSubScoreForApiResponse insertSubScoreForApiResponse = new InsertSubScoreForApiResponse();

			insertSubScoreForApiResponse.HttpResponse = _ctx.HttpResponse;
			insertSubScoreForApiResponse.Code = _ctx.StringValue("InsertSubScoreForApi.Code");
			insertSubScoreForApiResponse.Message = _ctx.StringValue("InsertSubScoreForApi.Message");
			insertSubScoreForApiResponse.RequestId = _ctx.StringValue("InsertSubScoreForApi.RequestId");
			insertSubScoreForApiResponse.Success = _ctx.BooleanValue("InsertSubScoreForApi.Success");

			InsertSubScoreForApiResponse.InsertSubScoreForApi_Data data = new InsertSubScoreForApiResponse.InsertSubScoreForApi_Data();
			data.ScoreSubId = _ctx.LongValue("InsertSubScoreForApi.Data.ScoreSubId");
			data.ScoreSubName = _ctx.StringValue("InsertSubScoreForApi.Data.ScoreSubName");
			insertSubScoreForApiResponse.Data = data;
        
			return insertSubScoreForApiResponse;
        }
    }
}
