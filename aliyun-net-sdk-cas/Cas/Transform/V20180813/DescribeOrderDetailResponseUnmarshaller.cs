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
using Aliyun.Acs.cas.Model.V20180813;

namespace Aliyun.Acs.cas.Transform.V20180813
{
    public class DescribeOrderDetailResponseUnmarshaller
    {
        public static DescribeOrderDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderDetailResponse describeOrderDetailResponse = new DescribeOrderDetailResponse();

			describeOrderDetailResponse.HttpResponse = context.HttpResponse;
			describeOrderDetailResponse.RequestId = context.StringValue("DescribeOrderDetail.RequestId");
			describeOrderDetailResponse.Id = context.IntegerValue("DescribeOrderDetail.Id");
			describeOrderDetailResponse.SourceType = context.StringValue("DescribeOrderDetail.SourceType");
			describeOrderDetailResponse.InstanceId = context.StringValue("DescribeOrderDetail.InstanceId");
			describeOrderDetailResponse.OrderId = context.LongValue("DescribeOrderDetail.OrderId");
			describeOrderDetailResponse.Year = context.IntegerValue("DescribeOrderDetail.Year");
			describeOrderDetailResponse.BuyDate = context.IntegerValue("DescribeOrderDetail.BuyDate");
			describeOrderDetailResponse.Domain = context.StringValue("DescribeOrderDetail.Domain");
			describeOrderDetailResponse.StatusCode = context.IntegerValue("DescribeOrderDetail.StatusCode");
			describeOrderDetailResponse.BrandName = context.StringValue("DescribeOrderDetail.BrandName");
			describeOrderDetailResponse.ProductAliasName = context.StringValue("DescribeOrderDetail.ProductAliasName");
			describeOrderDetailResponse.CertType = context.StringValue("DescribeOrderDetail.CertType");
        
			return describeOrderDetailResponse;
        }
    }
}
