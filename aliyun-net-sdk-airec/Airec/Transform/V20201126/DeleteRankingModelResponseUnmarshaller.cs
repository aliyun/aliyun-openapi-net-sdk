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
using Aliyun.Acs.Airec.Model.V20201126;

namespace Aliyun.Acs.Airec.Transform.V20201126
{
    public class DeleteRankingModelResponseUnmarshaller
    {
        public static DeleteRankingModelResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteRankingModelResponse deleteRankingModelResponse = new DeleteRankingModelResponse();

			deleteRankingModelResponse.HttpResponse = _ctx.HttpResponse;
			deleteRankingModelResponse.Code = _ctx.StringValue("DeleteRankingModel.code");
			deleteRankingModelResponse.Message = _ctx.StringValue("DeleteRankingModel.message");
			deleteRankingModelResponse.RequestId = _ctx.StringValue("DeleteRankingModel.requestId");

			DeleteRankingModelResponse.DeleteRankingModel_Result result = new DeleteRankingModelResponse.DeleteRankingModel_Result();
			result.Meta = _ctx.StringValue("DeleteRankingModel.Result.meta");
			result.RankingModelId = _ctx.StringValue("DeleteRankingModel.Result.rankingModelId");
			deleteRankingModelResponse.Result = result;
        
			return deleteRankingModelResponse;
        }
    }
}
