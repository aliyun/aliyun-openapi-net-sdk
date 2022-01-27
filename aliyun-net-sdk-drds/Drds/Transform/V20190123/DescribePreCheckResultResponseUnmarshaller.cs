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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribePreCheckResultResponseUnmarshaller
    {
        public static DescribePreCheckResultResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePreCheckResultResponse describePreCheckResultResponse = new DescribePreCheckResultResponse();

			describePreCheckResultResponse.HttpResponse = _ctx.HttpResponse;
			describePreCheckResultResponse.RequestId = _ctx.StringValue("DescribePreCheckResult.RequestId");
			describePreCheckResultResponse.Success = _ctx.BooleanValue("DescribePreCheckResult.Success");

			DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult preCheckResult = new DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult();
			preCheckResult.PreCheckName = _ctx.StringValue("DescribePreCheckResult.PreCheckResult.PreCheckName");
			preCheckResult.State = _ctx.StringValue("DescribePreCheckResult.PreCheckResult.State");

			List<DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult.DescribePreCheckResult_SubCheckItemsItem> preCheckResult_subCheckItems = new List<DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult.DescribePreCheckResult_SubCheckItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribePreCheckResult.PreCheckResult.SubCheckItems.Length"); i++) {
				DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult.DescribePreCheckResult_SubCheckItemsItem subCheckItemsItem = new DescribePreCheckResultResponse.DescribePreCheckResult_PreCheckResult.DescribePreCheckResult_SubCheckItemsItem();
				subCheckItemsItem.PreCheckItemName = _ctx.StringValue("DescribePreCheckResult.PreCheckResult.SubCheckItems["+ i +"].PreCheckItemName");
				subCheckItemsItem.State = _ctx.StringValue("DescribePreCheckResult.PreCheckResult.SubCheckItems["+ i +"].State");
				subCheckItemsItem.ErrorMsgCode = _ctx.StringValue("DescribePreCheckResult.PreCheckResult.SubCheckItems["+ i +"].ErrorMsgCode");

				List<string> subCheckItemsItem_errorMsgParams = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePreCheckResult.PreCheckResult.SubCheckItems["+ i +"].ErrorMsgParams.Length"); j++) {
					subCheckItemsItem_errorMsgParams.Add(_ctx.StringValue("DescribePreCheckResult.PreCheckResult.SubCheckItems["+ i +"].ErrorMsgParams["+ j +"]"));
				}
				subCheckItemsItem.ErrorMsgParams = subCheckItemsItem_errorMsgParams;

				preCheckResult_subCheckItems.Add(subCheckItemsItem);
			}
			preCheckResult.SubCheckItems = preCheckResult_subCheckItems;
			describePreCheckResultResponse.PreCheckResult = preCheckResult;
        
			return describePreCheckResultResponse;
        }
    }
}
