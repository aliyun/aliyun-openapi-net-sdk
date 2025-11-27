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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class BatchAddFeishuUsersResponseUnmarshaller
    {
        public static BatchAddFeishuUsersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			BatchAddFeishuUsersResponse batchAddFeishuUsersResponse = new BatchAddFeishuUsersResponse();

			batchAddFeishuUsersResponse.HttpResponse = _ctx.HttpResponse;
			batchAddFeishuUsersResponse.RequestId = _ctx.StringValue("BatchAddFeishuUsers.RequestId");
			batchAddFeishuUsersResponse.Success = _ctx.BooleanValue("BatchAddFeishuUsers.Success");

			BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result result = new BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result();
			result.FailCount = _ctx.IntegerValue("BatchAddFeishuUsers.Result.FailCount");
			result.OkCount = _ctx.IntegerValue("BatchAddFeishuUsers.Result.OkCount");

			List<BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem> result_failResults = new List<BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem>();
			for (int i = 0; i < _ctx.Length("BatchAddFeishuUsers.Result.FailResults.Length"); i++) {
				BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem failResultsItem = new BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem();

				List<BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem.BatchAddFeishuUsers_FailInfosItem> failResultsItem_failInfos = new List<BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem.BatchAddFeishuUsers_FailInfosItem>();
				for (int j = 0; j < _ctx.Length("BatchAddFeishuUsers.Result.FailResults["+ i +"].FailInfos.Length"); j++) {
					BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem.BatchAddFeishuUsers_FailInfosItem failInfosItem = new BatchAddFeishuUsersResponse.BatchAddFeishuUsers_Result.BatchAddFeishuUsers_FailResultsItem.BatchAddFeishuUsers_FailInfosItem();
					failInfosItem.Code = _ctx.StringValue("BatchAddFeishuUsers.Result.FailResults["+ i +"].FailInfos["+ j +"].Code");
					failInfosItem.CodeDesc = _ctx.StringValue("BatchAddFeishuUsers.Result.FailResults["+ i +"].FailInfos["+ j +"].CodeDesc");
					failInfosItem.Input = _ctx.StringValue("BatchAddFeishuUsers.Result.FailResults["+ i +"].FailInfos["+ j +"].Input");

					failResultsItem_failInfos.Add(failInfosItem);
				}
				failResultsItem.FailInfos = failResultsItem_failInfos;

				result_failResults.Add(failResultsItem);
			}
			result.FailResults = result_failResults;
			batchAddFeishuUsersResponse.Result = result;
        
			return batchAddFeishuUsersResponse;
        }
    }
}
