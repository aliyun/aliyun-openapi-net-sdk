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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeRiskWhiteListResponseUnmarshaller
    {
        public static DescribeRiskWhiteListResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRiskWhiteListResponse describeRiskWhiteListResponse = new DescribeRiskWhiteListResponse();

			describeRiskWhiteListResponse.HttpResponse = context.HttpResponse;
			describeRiskWhiteListResponse.RequestId = context.StringValue("DescribeRiskWhiteList.RequestId");
			describeRiskWhiteListResponse.Count = context.IntegerValue("DescribeRiskWhiteList.Count");
			describeRiskWhiteListResponse.PageSize = context.IntegerValue("DescribeRiskWhiteList.PageSize");
			describeRiskWhiteListResponse.TotalCount = context.IntegerValue("DescribeRiskWhiteList.TotalCount");
			describeRiskWhiteListResponse.CurrentPage = context.IntegerValue("DescribeRiskWhiteList.CurrentPage");

			List<DescribeRiskWhiteListResponse.DescribeRiskWhiteList_WhiteList> describeRiskWhiteListResponse_whiteLists = new List<DescribeRiskWhiteListResponse.DescribeRiskWhiteList_WhiteList>();
			for (int i = 0; i < context.Length("DescribeRiskWhiteList.WhiteLists.Length"); i++) {
				DescribeRiskWhiteListResponse.DescribeRiskWhiteList_WhiteList whiteList = new DescribeRiskWhiteListResponse.DescribeRiskWhiteList_WhiteList();
				whiteList.RiskId = context.LongValue("DescribeRiskWhiteList.WhiteLists["+ i +"].RiskId");
				whiteList.RiskName = context.StringValue("DescribeRiskWhiteList.WhiteLists["+ i +"].RiskName");
				whiteList.Reason = context.StringValue("DescribeRiskWhiteList.WhiteLists["+ i +"].Reason");

				describeRiskWhiteListResponse_whiteLists.Add(whiteList);
			}
			describeRiskWhiteListResponse.WhiteLists = describeRiskWhiteListResponse_whiteLists;
        
			return describeRiskWhiteListResponse;
        }
    }
}
