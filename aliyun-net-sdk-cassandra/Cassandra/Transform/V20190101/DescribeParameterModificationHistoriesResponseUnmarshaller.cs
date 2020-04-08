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
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeParameterModificationHistoriesResponseUnmarshaller
    {
        public static DescribeParameterModificationHistoriesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeParameterModificationHistoriesResponse describeParameterModificationHistoriesResponse = new DescribeParameterModificationHistoriesResponse();

			describeParameterModificationHistoriesResponse.HttpResponse = context.HttpResponse;
			describeParameterModificationHistoriesResponse.RequestId = context.StringValue("DescribeParameterModificationHistories.RequestId");
			describeParameterModificationHistoriesResponse.PageNumber = context.IntegerValue("DescribeParameterModificationHistories.PageNumber");
			describeParameterModificationHistoriesResponse.PageSize = context.IntegerValue("DescribeParameterModificationHistories.PageSize");
			describeParameterModificationHistoriesResponse.TotalCount = context.LongValue("DescribeParameterModificationHistories.TotalCount");

			List<DescribeParameterModificationHistoriesResponse.DescribeParameterModificationHistories_History> describeParameterModificationHistoriesResponse_histories = new List<DescribeParameterModificationHistoriesResponse.DescribeParameterModificationHistories_History>();
			for (int i = 0; i < context.Length("DescribeParameterModificationHistories.Histories.Length"); i++) {
				DescribeParameterModificationHistoriesResponse.DescribeParameterModificationHistories_History history = new DescribeParameterModificationHistoriesResponse.DescribeParameterModificationHistories_History();
				history.Name = context.StringValue("DescribeParameterModificationHistories.Histories["+ i +"].Name");
				history.OldValue = context.StringValue("DescribeParameterModificationHistories.Histories["+ i +"].OldValue");
				history.NewValue = context.StringValue("DescribeParameterModificationHistories.Histories["+ i +"].NewValue");
				history.Time = context.LongValue("DescribeParameterModificationHistories.Histories["+ i +"].Time");

				describeParameterModificationHistoriesResponse_histories.Add(history);
			}
			describeParameterModificationHistoriesResponse.Histories = describeParameterModificationHistoriesResponse_histories;
        
			return describeParameterModificationHistoriesResponse;
        }
    }
}
