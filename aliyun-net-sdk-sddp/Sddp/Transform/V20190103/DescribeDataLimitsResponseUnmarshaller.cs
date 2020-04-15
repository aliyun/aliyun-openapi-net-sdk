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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeDataLimitsResponseUnmarshaller
    {
        public static DescribeDataLimitsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataLimitsResponse describeDataLimitsResponse = new DescribeDataLimitsResponse();

			describeDataLimitsResponse.HttpResponse = context.HttpResponse;
			describeDataLimitsResponse.RequestId = context.StringValue("DescribeDataLimits.RequestId");
			describeDataLimitsResponse.PageSize = context.IntegerValue("DescribeDataLimits.PageSize");
			describeDataLimitsResponse.CurrentPage = context.IntegerValue("DescribeDataLimits.CurrentPage");
			describeDataLimitsResponse.TotalCount = context.IntegerValue("DescribeDataLimits.TotalCount");

			List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit> describeDataLimitsResponse_items = new List<DescribeDataLimitsResponse.DescribeDataLimits_DataLimit>();
			for (int i = 0; i < context.Length("DescribeDataLimits.Items.Length"); i++) {
				DescribeDataLimitsResponse.DescribeDataLimits_DataLimit dataLimit = new DescribeDataLimitsResponse.DescribeDataLimits_DataLimit();
				dataLimit.RegionId = context.StringValue("DescribeDataLimits.Items["+ i +"].RegionId");
				dataLimit.LocalName = context.StringValue("DescribeDataLimits.Items["+ i +"].LocalName");
				dataLimit.ParentId = context.StringValue("DescribeDataLimits.Items["+ i +"].ParentId");
				dataLimit.Id = context.LongValue("DescribeDataLimits.Items["+ i +"].Id");
				dataLimit.UserName = context.StringValue("DescribeDataLimits.Items["+ i +"].UserName");
				dataLimit.GmtCreate = context.LongValue("DescribeDataLimits.Items["+ i +"].GmtCreate");
				dataLimit.Connector = context.StringValue("DescribeDataLimits.Items["+ i +"].Connector");
				dataLimit.CheckStatus = context.IntegerValue("DescribeDataLimits.Items["+ i +"].CheckStatus");
				dataLimit.CheckStatusName = context.StringValue("DescribeDataLimits.Items["+ i +"].CheckStatusName");
				dataLimit.ResourceType = context.LongValue("DescribeDataLimits.Items["+ i +"].ResourceType");
				dataLimit.ResourceTypeCode = context.StringValue("DescribeDataLimits.Items["+ i +"].ResourceTypeCode");
				dataLimit.AuditStatus = context.IntegerValue("DescribeDataLimits.Items["+ i +"].AuditStatus");
				dataLimit.LogStoreDay = context.IntegerValue("DescribeDataLimits.Items["+ i +"].LogStoreDay");
				dataLimit.Enable = context.IntegerValue("DescribeDataLimits.Items["+ i +"].Enable");
				dataLimit.AutoScan = context.IntegerValue("DescribeDataLimits.Items["+ i +"].AutoScan");
				dataLimit.EngineType = context.StringValue("DescribeDataLimits.Items["+ i +"].EngineType");
				dataLimit.ProcessStatus = context.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessStatus");
				dataLimit.ProcessTotalCount = context.IntegerValue("DescribeDataLimits.Items["+ i +"].ProcessTotalCount");
				dataLimit.TotalCount = context.IntegerValue("DescribeDataLimits.Items["+ i +"].TotalCount");
				dataLimit.LastFinishedTime = context.LongValue("DescribeDataLimits.Items["+ i +"].LastFinishedTime");
				dataLimit.ErrorCode = context.StringValue("DescribeDataLimits.Items["+ i +"].ErrorCode");
				dataLimit.ErrorMessage = context.StringValue("DescribeDataLimits.Items["+ i +"].ErrorMessage");
				dataLimit.Port = context.IntegerValue("DescribeDataLimits.Items["+ i +"].Port");

				describeDataLimitsResponse_items.Add(dataLimit);
			}
			describeDataLimitsResponse.Items = describeDataLimitsResponse_items;
        
			return describeDataLimitsResponse;
        }
    }
}
