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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeAutoRenewAttributeResponseUnmarshaller
    {
        public static DescribeAutoRenewAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoRenewAttributeResponse describeAutoRenewAttributeResponse = new DescribeAutoRenewAttributeResponse();

			describeAutoRenewAttributeResponse.HttpResponse = context.HttpResponse;
			describeAutoRenewAttributeResponse.RequestId = context.StringValue("DescribeAutoRenewAttribute.RequestId");
			describeAutoRenewAttributeResponse.PageNumber = context.IntegerValue("DescribeAutoRenewAttribute.PageNumber");
			describeAutoRenewAttributeResponse.TotalRecordCount = context.IntegerValue("DescribeAutoRenewAttribute.TotalRecordCount");
			describeAutoRenewAttributeResponse.PageRecordCount = context.IntegerValue("DescribeAutoRenewAttribute.PageRecordCount");

			List<DescribeAutoRenewAttributeResponse.DescribeAutoRenewAttribute_AutoRenewAttribute> describeAutoRenewAttributeResponse_items = new List<DescribeAutoRenewAttributeResponse.DescribeAutoRenewAttribute_AutoRenewAttribute>();
			for (int i = 0; i < context.Length("DescribeAutoRenewAttribute.Items.Length"); i++) {
				DescribeAutoRenewAttributeResponse.DescribeAutoRenewAttribute_AutoRenewAttribute autoRenewAttribute = new DescribeAutoRenewAttributeResponse.DescribeAutoRenewAttribute_AutoRenewAttribute();
				autoRenewAttribute.DBClusterId = context.StringValue("DescribeAutoRenewAttribute.Items["+ i +"].DBClusterId");
				autoRenewAttribute.RegionId = context.StringValue("DescribeAutoRenewAttribute.Items["+ i +"].RegionId");
				autoRenewAttribute.AutoRenewEnabled = context.BooleanValue("DescribeAutoRenewAttribute.Items["+ i +"].AutoRenewEnabled");
				autoRenewAttribute.Duration = context.IntegerValue("DescribeAutoRenewAttribute.Items["+ i +"].Duration");
				autoRenewAttribute.PeriodUnit = context.StringValue("DescribeAutoRenewAttribute.Items["+ i +"].PeriodUnit");
				autoRenewAttribute.RenewalStatus = context.StringValue("DescribeAutoRenewAttribute.Items["+ i +"].RenewalStatus");

				describeAutoRenewAttributeResponse_items.Add(autoRenewAttribute);
			}
			describeAutoRenewAttributeResponse.Items = describeAutoRenewAttributeResponse_items;
        
			return describeAutoRenewAttributeResponse;
        }
    }
}
