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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetMergeRequestSettingResponseUnmarshaller
    {
        public static GetMergeRequestSettingResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMergeRequestSettingResponse getMergeRequestSettingResponse = new GetMergeRequestSettingResponse();

			getMergeRequestSettingResponse.HttpResponse = _ctx.HttpResponse;
			getMergeRequestSettingResponse.ErrorCode = _ctx.StringValue("GetMergeRequestSetting.ErrorCode");
			getMergeRequestSettingResponse.ErrorMessage = _ctx.StringValue("GetMergeRequestSetting.ErrorMessage");
			getMergeRequestSettingResponse.RequestId = _ctx.StringValue("GetMergeRequestSetting.RequestId");
			getMergeRequestSettingResponse.Success = _ctx.BooleanValue("GetMergeRequestSetting.Success");

			GetMergeRequestSettingResponse.GetMergeRequestSetting_Result result = new GetMergeRequestSettingResponse.GetMergeRequestSetting_Result();
			result.IsEnableSmartCodeReview = _ctx.BooleanValue("GetMergeRequestSetting.Result.IsEnableSmartCodeReview");

			List<string> result_mergeTypes = new List<string>();
			for (int i = 0; i < _ctx.Length("GetMergeRequestSetting.Result.MergeTypes.Length"); i++) {
				result_mergeTypes.Add(_ctx.StringValue("GetMergeRequestSetting.Result.MergeTypes["+ i +"]"));
			}
			result.MergeTypes = result_mergeTypes;
			getMergeRequestSettingResponse.Result = result;
        
			return getMergeRequestSettingResponse;
        }
    }
}
