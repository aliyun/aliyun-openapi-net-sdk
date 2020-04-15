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
    public class DescribeDataLimitDetailResponseUnmarshaller
    {
        public static DescribeDataLimitDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDataLimitDetailResponse describeDataLimitDetailResponse = new DescribeDataLimitDetailResponse();

			describeDataLimitDetailResponse.HttpResponse = context.HttpResponse;
			describeDataLimitDetailResponse.RequestId = context.StringValue("DescribeDataLimitDetail.RequestId");

			DescribeDataLimitDetailResponse.DescribeDataLimitDetail_DataLimit dataLimit = new DescribeDataLimitDetailResponse.DescribeDataLimitDetail_DataLimit();
			dataLimit.RegionId = context.StringValue("DescribeDataLimitDetail.DataLimit.RegionId");
			dataLimit.LocalName = context.StringValue("DescribeDataLimitDetail.DataLimit.LocalName");
			dataLimit.ParentId = context.StringValue("DescribeDataLimitDetail.DataLimit.ParentId");
			dataLimit.Id = context.LongValue("DescribeDataLimitDetail.DataLimit.Id");
			dataLimit.UserName = context.StringValue("DescribeDataLimitDetail.DataLimit.UserName");
			dataLimit.GmtCreate = context.LongValue("DescribeDataLimitDetail.DataLimit.GmtCreate");
			dataLimit.Connector = context.StringValue("DescribeDataLimitDetail.DataLimit.Connector");
			dataLimit.CheckStatus = context.IntegerValue("DescribeDataLimitDetail.DataLimit.CheckStatus");
			dataLimit.CheckStatusName = context.StringValue("DescribeDataLimitDetail.DataLimit.CheckStatusName");
			dataLimit.ResourceType = context.LongValue("DescribeDataLimitDetail.DataLimit.ResourceType");
			dataLimit.ResourceTypeCode = context.StringValue("DescribeDataLimitDetail.DataLimit.ResourceTypeCode");
			dataLimit.AuditStatus = context.IntegerValue("DescribeDataLimitDetail.DataLimit.AuditStatus");
			dataLimit.LogStoreDay = context.IntegerValue("DescribeDataLimitDetail.DataLimit.LogStoreDay");
			dataLimit.Port = context.IntegerValue("DescribeDataLimitDetail.DataLimit.Port");
			describeDataLimitDetailResponse.DataLimit = dataLimit;
        
			return describeDataLimitDetailResponse;
        }
    }
}
