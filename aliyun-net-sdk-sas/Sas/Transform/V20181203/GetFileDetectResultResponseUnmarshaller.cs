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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class GetFileDetectResultResponseUnmarshaller
    {
        public static GetFileDetectResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetFileDetectResultResponse getFileDetectResultResponse = new GetFileDetectResultResponse();

			getFileDetectResultResponse.HttpResponse = _ctx.HttpResponse;
			getFileDetectResultResponse.RequestId = _ctx.StringValue("GetFileDetectResult.RequestId");

			List<GetFileDetectResultResponse.GetFileDetectResult_Result> getFileDetectResultResponse_resultList = new List<GetFileDetectResultResponse.GetFileDetectResult_Result>();
			for (int i = 0; i < _ctx.Length("GetFileDetectResult.ResultList.Length"); i++) {
				GetFileDetectResultResponse.GetFileDetectResult_Result result = new GetFileDetectResultResponse.GetFileDetectResult_Result();
				result.HashKey = _ctx.StringValue("GetFileDetectResult.ResultList["+ i +"].HashKey");
				result.Result = _ctx.IntegerValue("GetFileDetectResult.ResultList["+ i +"].Result");
				result.Score = _ctx.IntegerValue("GetFileDetectResult.ResultList["+ i +"].Score");
				result.VirusType = _ctx.StringValue("GetFileDetectResult.ResultList["+ i +"].VirusType");
				result.Ext = _ctx.StringValue("GetFileDetectResult.ResultList["+ i +"].Ext");

				getFileDetectResultResponse_resultList.Add(result);
			}
			getFileDetectResultResponse.ResultList = getFileDetectResultResponse_resultList;
        
			return getFileDetectResultResponse;
        }
    }
}
