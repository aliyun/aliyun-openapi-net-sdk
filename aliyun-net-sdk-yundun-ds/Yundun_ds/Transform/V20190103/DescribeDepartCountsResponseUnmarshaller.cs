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
using Aliyun.Acs.Yundun_ds.Model.V20190103;

namespace Aliyun.Acs.Yundun_ds.Transform.V20190103
{
    public class DescribeDepartCountsResponseUnmarshaller
    {
        public static DescribeDepartCountsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDepartCountsResponse describeDepartCountsResponse = new DescribeDepartCountsResponse();

			describeDepartCountsResponse.HttpResponse = context.HttpResponse;
			describeDepartCountsResponse.RequestId = context.StringValue("DescribeDepartCounts.RequestId");
			describeDepartCountsResponse.PageSize = context.IntegerValue("DescribeDepartCounts.PageSize");
			describeDepartCountsResponse.CurrentPage = context.IntegerValue("DescribeDepartCounts.CurrentPage");
			describeDepartCountsResponse.TotalCount = context.IntegerValue("DescribeDepartCounts.TotalCount");

			List<DescribeDepartCountsResponse.DescribeDepartCounts_DepartCount> describeDepartCountsResponse_items = new List<DescribeDepartCountsResponse.DescribeDepartCounts_DepartCount>();
			for (int i = 0; i < context.Length("DescribeDepartCounts.Items.Length"); i++) {
				DescribeDepartCountsResponse.DescribeDepartCounts_DepartCount departCount = new DescribeDepartCountsResponse.DescribeDepartCounts_DepartCount();
				departCount.DepartName = context.StringValue("DescribeDepartCounts.Items["+ i +"].DepartName");
				departCount.DepartCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].DepartCount");
				departCount.Count = context.LongValue("DescribeDepartCounts.Items["+ i +"].Count");
				departCount.UserCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].UserCount");
				departCount.DtCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].DtCount");
				departCount.SubCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].SubCount");
				departCount.SensitiveCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].SensitiveCount");
				departCount.EventTotalCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].EventTotalCount");
				departCount.ConfirmCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].ConfirmCount");
				departCount.UserConfirmCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].UserConfirmCount");
				departCount.LastEventCount = context.LongValue("DescribeDepartCounts.Items["+ i +"].LastEventCount");
				departCount.TopSubTypeName = context.LongValue("DescribeDepartCounts.Items["+ i +"].TopSubTypeName");
				departCount.TopDisplayName = context.LongValue("DescribeDepartCounts.Items["+ i +"].TopDisplayName");

				describeDepartCountsResponse_items.Add(departCount);
			}
			describeDepartCountsResponse.Items = describeDepartCountsResponse_items;
        
			return describeDepartCountsResponse;
        }
    }
}
