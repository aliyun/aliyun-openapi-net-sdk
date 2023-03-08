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
using Aliyun.Acs.adb.Model.V20211201;

namespace Aliyun.Acs.adb.Transform.V20211201
{
    public class DescribeSqlPatternResponseUnmarshaller
    {
        public static DescribeSqlPatternResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSqlPatternResponse describeSqlPatternResponse = new DescribeSqlPatternResponse();

			describeSqlPatternResponse.HttpResponse = _ctx.HttpResponse;
			describeSqlPatternResponse.PageSize = _ctx.IntegerValue("DescribeSqlPattern.PageSize");
			describeSqlPatternResponse.PageNumber = _ctx.IntegerValue("DescribeSqlPattern.PageNumber");
			describeSqlPatternResponse.TotalCount = _ctx.IntegerValue("DescribeSqlPattern.TotalCount");
			describeSqlPatternResponse.RequestId = _ctx.StringValue("DescribeSqlPattern.RequestId");

			List<DescribeSqlPatternResponse.DescribeSqlPattern_ItemsItem> describeSqlPatternResponse_items = new List<DescribeSqlPatternResponse.DescribeSqlPattern_ItemsItem>();
			for (int i = 0; i < _ctx.Length("DescribeSqlPattern.Items.Length"); i++) {
				DescribeSqlPatternResponse.DescribeSqlPattern_ItemsItem itemsItem = new DescribeSqlPatternResponse.DescribeSqlPattern_ItemsItem();
				itemsItem.AvgStageCount = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AvgStageCount");
				itemsItem.MaxCpuTime = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].MaxCpuTime");
				itemsItem.AccessIP = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AccessIP");
				itemsItem.AvgScanSize = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AvgScanSize");
				itemsItem.MaxScanSize = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].MaxScanSize");
				itemsItem.MaxPeakMemory = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].MaxPeakMemory");
				itemsItem.AvgCpuTime = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AvgCpuTime");
				itemsItem.User = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].User");
				itemsItem.AvgPeakMemory = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AvgPeakMemory");
				itemsItem.MaxStageCount = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].MaxStageCount");
				itemsItem.MaxTaskCount = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].MaxTaskCount");
				itemsItem.InstanceName = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].InstanceName");
				itemsItem.QueryCount = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].QueryCount");
				itemsItem.ReportDate = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].ReportDate");
				itemsItem.Pattern = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].Pattern");
				itemsItem.AvgTaskCount = _ctx.StringValue("DescribeSqlPattern.Items["+ i +"].AvgTaskCount");

				describeSqlPatternResponse_items.Add(itemsItem);
			}
			describeSqlPatternResponse.Items = describeSqlPatternResponse_items;
        
			return describeSqlPatternResponse;
        }
    }
}
