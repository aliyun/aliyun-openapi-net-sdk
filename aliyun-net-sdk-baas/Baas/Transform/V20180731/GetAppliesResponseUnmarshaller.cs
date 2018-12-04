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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class GetAppliesResponseUnmarshaller
    {
        public static GetAppliesResponse Unmarshall(UnmarshallerContext context)
        {
			GetAppliesResponse getAppliesResponse = new GetAppliesResponse();

			getAppliesResponse.HttpResponse = context.HttpResponse;
			getAppliesResponse.RequestId = context.StringValue("GetApplies.RequestId");

			GetAppliesResponse.GetApplies_Result result = new GetAppliesResponse.GetApplies_Result();

			GetAppliesResponse.GetApplies_Result.GetApplies_Pagination pagination = new GetAppliesResponse.GetApplies_Result.GetApplies_Pagination();
			pagination.PageSize = context.IntegerValue("GetApplies.Result.Pagination.PageSize");
			pagination.Current = context.IntegerValue("GetApplies.Result.Pagination.Current");
			pagination.Total = context.IntegerValue("GetApplies.Result.Pagination.Total");
			result.Pagination = pagination;

			List<GetAppliesResponse.GetApplies_Result.GetApplies_ApplyHistoryListItem> result_applyHistoryList = new List<GetAppliesResponse.GetApplies_Result.GetApplies_ApplyHistoryListItem>();
			for (int i = 0; i < context.Length("GetApplies.Result.ApplyHistoryList.Length"); i++) {
				GetAppliesResponse.GetApplies_Result.GetApplies_ApplyHistoryListItem applyHistoryListItem = new GetAppliesResponse.GetApplies_Result.GetApplies_ApplyHistoryListItem();
				applyHistoryListItem.Id = context.IntegerValue("GetApplies.Result.ApplyHistoryList["+ i +"].Id");
				applyHistoryListItem.Bizid = context.StringValue("GetApplies.Result.ApplyHistoryList["+ i +"].Bizid");
				applyHistoryListItem.Username = context.StringValue("GetApplies.Result.ApplyHistoryList["+ i +"].Username");
				applyHistoryListItem.ReqAddr = context.StringValue("GetApplies.Result.ApplyHistoryList["+ i +"].ReqAddr");
				applyHistoryListItem.SignedAddr = context.StringValue("GetApplies.Result.ApplyHistoryList["+ i +"].SignedAddr");
				applyHistoryListItem.Status = context.IntegerValue("GetApplies.Result.ApplyHistoryList["+ i +"].Status");
				applyHistoryListItem.RejectReason = context.StringValue("GetApplies.Result.ApplyHistoryList["+ i +"].RejectReason");
				applyHistoryListItem.Createtime = context.LongValue("GetApplies.Result.ApplyHistoryList["+ i +"].Createtime");
				applyHistoryListItem.Updatetime = context.LongValue("GetApplies.Result.ApplyHistoryList["+ i +"].Updatetime");

				result_applyHistoryList.Add(applyHistoryListItem);
			}
			result.ApplyHistoryList = result_applyHistoryList;
			getAppliesResponse.Result = result;
        
			return getAppliesResponse;
        }
    }
}