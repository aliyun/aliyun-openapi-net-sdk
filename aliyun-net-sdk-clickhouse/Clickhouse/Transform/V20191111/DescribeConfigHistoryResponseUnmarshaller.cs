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
using Aliyun.Acs.clickhouse.Model.V20191111;

namespace Aliyun.Acs.clickhouse.Transform.V20191111
{
    public class DescribeConfigHistoryResponseUnmarshaller
    {
        public static DescribeConfigHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeConfigHistoryResponse describeConfigHistoryResponse = new DescribeConfigHistoryResponse();

			describeConfigHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeConfigHistoryResponse.RequestId = _ctx.StringValue("DescribeConfigHistory.RequestId");

			List<DescribeConfigHistoryResponse.DescribeConfigHistory_ConfigHistoryItem> describeConfigHistoryResponse_configHistoryItems = new List<DescribeConfigHistoryResponse.DescribeConfigHistory_ConfigHistoryItem>();
			for (int i = 0; i < _ctx.Length("DescribeConfigHistory.ConfigHistoryItems.Length"); i++) {
				DescribeConfigHistoryResponse.DescribeConfigHistory_ConfigHistoryItem configHistoryItem = new DescribeConfigHistoryResponse.DescribeConfigHistory_ConfigHistoryItem();
				configHistoryItem.Time = _ctx.StringValue("DescribeConfigHistory.ConfigHistoryItems["+ i +"].Time");
				configHistoryItem.OwnerId = _ctx.StringValue("DescribeConfigHistory.ConfigHistoryItems["+ i +"].OwnerId");
				configHistoryItem.Reason = _ctx.StringValue("DescribeConfigHistory.ConfigHistoryItems["+ i +"].Reason");
				configHistoryItem.Success = _ctx.BooleanValue("DescribeConfigHistory.ConfigHistoryItems["+ i +"].Success");
				configHistoryItem.ChangeId = _ctx.StringValue("DescribeConfigHistory.ConfigHistoryItems["+ i +"].ChangeId");

				describeConfigHistoryResponse_configHistoryItems.Add(configHistoryItem);
			}
			describeConfigHistoryResponse.ConfigHistoryItems = describeConfigHistoryResponse_configHistoryItems;
        
			return describeConfigHistoryResponse;
        }
    }
}
