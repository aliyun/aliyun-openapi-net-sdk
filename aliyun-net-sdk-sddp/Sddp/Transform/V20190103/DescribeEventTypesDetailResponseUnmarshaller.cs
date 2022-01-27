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
    public class DescribeEventTypesDetailResponseUnmarshaller
    {
        public static DescribeEventTypesDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeEventTypesDetailResponse describeEventTypesDetailResponse = new DescribeEventTypesDetailResponse();

			describeEventTypesDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeEventTypesDetailResponse.RequestId = _ctx.StringValue("DescribeEventTypesDetail.RequestId");

			DescribeEventTypesDetailResponse.DescribeEventTypesDetail_UserStatus userStatus = new DescribeEventTypesDetailResponse.DescribeEventTypesDetail_UserStatus();
			userStatus.Name = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.Name");
			userStatus.Code = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.Code");
			userStatus.Description = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.Description");
			userStatus.ParentTypeId = _ctx.LongValue("DescribeEventTypesDetail.UserStatus.ParentTypeId");
			userStatus.ParentTypeName = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.ParentTypeName");
			userStatus.RiskLevel = _ctx.IntegerValue("DescribeEventTypesDetail.UserStatus.RiskLevel");
			userStatus.RiskName = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.RiskName");
			userStatus.Status = _ctx.IntegerValue("DescribeEventTypesDetail.UserStatus.Status");
			userStatus.EventHitCount = _ctx.IntegerValue("DescribeEventTypesDetail.UserStatus.EventHitCount");
			userStatus.AccessCount = _ctx.IntegerValue("DescribeEventTypesDetail.UserStatus.AccessCount");
			userStatus.DescEvent = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.DescEvent");
			userStatus.DescModel = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.DescModel");
			userStatus.DealSuggestion = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.DealSuggestion");
			userStatus.RiskEvent = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.RiskEvent");
			userStatus.AdaptedProduct = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.AdaptedProduct");
			userStatus.ConfigCode = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.ConfigCode");
			userStatus.ConfigContentType = _ctx.IntegerValue("DescribeEventTypesDetail.UserStatus.ConfigContentType");
			userStatus.ConfigDescription = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.ConfigDescription");
			userStatus.ConfigValue = _ctx.StringValue("DescribeEventTypesDetail.UserStatus.ConfigValue");
			describeEventTypesDetailResponse.UserStatus = userStatus;
        
			return describeEventTypesDetailResponse;
        }
    }
}
