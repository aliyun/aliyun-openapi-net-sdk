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
    public class DescribeAppliesResponseUnmarshaller
    {
        public static DescribeAppliesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAppliesResponse describeAppliesResponse = new DescribeAppliesResponse();

			describeAppliesResponse.HttpResponse = context.HttpResponse;
			describeAppliesResponse.RequestId = context.StringValue("DescribeApplies.RequestId");

			DescribeAppliesResponse.DescribeApplies_Result result = new DescribeAppliesResponse.DescribeApplies_Result();

			DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_Pagination pagination = new DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_Pagination();
			pagination.PageSize = context.IntegerValue("DescribeApplies.Result.Pagination.PageSize");
			pagination.Current = context.IntegerValue("DescribeApplies.Result.Pagination.Current");
			pagination.Total = context.IntegerValue("DescribeApplies.Result.Pagination.Total");
			result.Pagination = pagination;

			List<DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_ApplyHistoryListItem> result_applyHistoryList = new List<DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_ApplyHistoryListItem>();
			for (int i = 0; i < context.Length("DescribeApplies.Result.ApplyHistoryList.Length"); i++) {
				DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_ApplyHistoryListItem applyHistoryListItem = new DescribeAppliesResponse.DescribeApplies_Result.DescribeApplies_ApplyHistoryListItem();
				applyHistoryListItem.Id = context.IntegerValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Id");
				applyHistoryListItem.Bizid = context.StringValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Bizid");
				applyHistoryListItem.Username = context.StringValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Username");
				applyHistoryListItem.ReqAddr = context.StringValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].ReqAddr");
				applyHistoryListItem.SignedAddr = context.StringValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].SignedAddr");
				applyHistoryListItem.Status = context.IntegerValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Status");
				applyHistoryListItem.RejectReason = context.StringValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].RejectReason");
				applyHistoryListItem.Createtime = context.LongValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Createtime");
				applyHistoryListItem.Updatetime = context.LongValue("DescribeApplies.Result.ApplyHistoryList["+ i +"].Updatetime");

				result_applyHistoryList.Add(applyHistoryListItem);
			}
			result.ApplyHistoryList = result_applyHistoryList;
			describeAppliesResponse.Result = result;
        
			return describeAppliesResponse;
        }
    }
}