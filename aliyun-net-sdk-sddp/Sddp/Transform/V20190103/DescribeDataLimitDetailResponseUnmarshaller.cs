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
        public static DescribeDataLimitDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDataLimitDetailResponse describeDataLimitDetailResponse = new DescribeDataLimitDetailResponse();

			describeDataLimitDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeDataLimitDetailResponse.RequestId = _ctx.StringValue("DescribeDataLimitDetail.RequestId");

			DescribeDataLimitDetailResponse.DescribeDataLimitDetail_DataLimit dataLimit = new DescribeDataLimitDetailResponse.DescribeDataLimitDetail_DataLimit();
			dataLimit.LocalName = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.LocalName");
			dataLimit.CheckStatus = _ctx.IntegerValue("DescribeDataLimitDetail.DataLimit.CheckStatus");
			dataLimit.Connector = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.Connector");
			dataLimit.Port = _ctx.IntegerValue("DescribeDataLimitDetail.DataLimit.Port");
			dataLimit.CheckStatusName = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.CheckStatusName");
			dataLimit.RegionId = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.RegionId");
			dataLimit.ParentId = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.ParentId");
			dataLimit.ResourceType = _ctx.LongValue("DescribeDataLimitDetail.DataLimit.ResourceType");
			dataLimit.LogStoreDay = _ctx.IntegerValue("DescribeDataLimitDetail.DataLimit.LogStoreDay");
			dataLimit.GmtCreate = _ctx.LongValue("DescribeDataLimitDetail.DataLimit.GmtCreate");
			dataLimit.ResourceTypeCode = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.ResourceTypeCode");
			dataLimit.UserName = _ctx.StringValue("DescribeDataLimitDetail.DataLimit.UserName");
			dataLimit.Id = _ctx.LongValue("DescribeDataLimitDetail.DataLimit.Id");
			dataLimit.AuditStatus = _ctx.IntegerValue("DescribeDataLimitDetail.DataLimit.AuditStatus");
			describeDataLimitDetailResponse.DataLimit = dataLimit;
        
			return describeDataLimitDetailResponse;
        }
    }
}
