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
    public class DescribeMySuccessAppliesResponseUnmarshaller
    {
        public static DescribeMySuccessAppliesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMySuccessAppliesResponse describeMySuccessAppliesResponse = new DescribeMySuccessAppliesResponse();

			describeMySuccessAppliesResponse.HttpResponse = context.HttpResponse;
			describeMySuccessAppliesResponse.RequestId = context.StringValue("DescribeMySuccessApplies.RequestId");

			List<DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem> describeMySuccessAppliesResponse_result = new List<DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem>();
			for (int i = 0; i < context.Length("DescribeMySuccessApplies.Result.Length"); i++) {
				DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem resultItem = new DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem();
				resultItem.Bizid = context.StringValue("DescribeMySuccessApplies.Result["+ i +"].Bizid");
				resultItem.NodeNumber = context.IntegerValue("DescribeMySuccessApplies.Result["+ i +"].NodeNumber");
				resultItem.BlockHeight = context.IntegerValue("DescribeMySuccessApplies.Result["+ i +"].BlockHeight");
				resultItem.TransactionSum = context.IntegerValue("DescribeMySuccessApplies.Result["+ i +"].TransactionSum");
				resultItem.CreateTime = context.LongValue("DescribeMySuccessApplies.Result["+ i +"].CreateTime");
				resultItem.AbnormalNodes = context.IntegerValue("DescribeMySuccessApplies.Result["+ i +"].AbnormalNodes");
				resultItem.Version = context.StringValue("DescribeMySuccessApplies.Result["+ i +"].Version");
				resultItem.IsRole = context.BooleanValue("DescribeMySuccessApplies.Result["+ i +"].IsRole");
				resultItem.Normal = context.BooleanValue("DescribeMySuccessApplies.Result["+ i +"].Normal");
				resultItem.Name = context.StringValue("DescribeMySuccessApplies.Result["+ i +"].Name");

				List<DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem.DescribeMySuccessApplies_NodeInfoListItem> resultItem_nodeInfoList = new List<DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem.DescribeMySuccessApplies_NodeInfoListItem>();
				for (int j = 0; j < context.Length("DescribeMySuccessApplies.Result["+ i +"].NodeInfoList.Length"); j++) {
					DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem.DescribeMySuccessApplies_NodeInfoListItem nodeInfoListItem = new DescribeMySuccessAppliesResponse.DescribeMySuccessApplies_ResultItem.DescribeMySuccessApplies_NodeInfoListItem();
					nodeInfoListItem.NodeName = context.StringValue("DescribeMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].NodeName");
					nodeInfoListItem.Status = context.BooleanValue("DescribeMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].Status");
					nodeInfoListItem.Version = context.StringValue("DescribeMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].Version");
					nodeInfoListItem.BlockHeight = context.LongValue("DescribeMySuccessApplies.Result["+ i +"].NodeInfoList["+ j +"].BlockHeight");

					resultItem_nodeInfoList.Add(nodeInfoListItem);
				}
				resultItem.NodeInfoList = resultItem_nodeInfoList;

				describeMySuccessAppliesResponse_result.Add(resultItem);
			}
			describeMySuccessAppliesResponse.Result = describeMySuccessAppliesResponse_result;
        
			return describeMySuccessAppliesResponse;
        }
    }
}