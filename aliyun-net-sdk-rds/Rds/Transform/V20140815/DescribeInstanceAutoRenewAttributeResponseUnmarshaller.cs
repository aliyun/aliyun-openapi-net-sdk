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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeInstanceAutoRenewAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAutoRenewAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceAutoRenewAttributeResponse describeInstanceAutoRenewAttributeResponse = new DescribeInstanceAutoRenewAttributeResponse();

			describeInstanceAutoRenewAttributeResponse.HttpResponse = context.HttpResponse;
			describeInstanceAutoRenewAttributeResponse.RequestId = context.StringValue("DescribeInstanceAutoRenewAttribute.RequestId");
			describeInstanceAutoRenewAttributeResponse.PageNumber = context.IntegerValue("DescribeInstanceAutoRenewAttribute.PageNumber");
			describeInstanceAutoRenewAttributeResponse.TotalRecordCount = context.IntegerValue("DescribeInstanceAutoRenewAttribute.TotalRecordCount");
			describeInstanceAutoRenewAttributeResponse.PageRecordCount = context.IntegerValue("DescribeInstanceAutoRenewAttribute.PageRecordCount");

			List<DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_Item> describeInstanceAutoRenewAttributeResponse_items = new List<DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_Item>();
			for (int i = 0; i < context.Length("DescribeInstanceAutoRenewAttribute.Items.Length"); i++) {
				DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_Item item = new DescribeInstanceAutoRenewAttributeResponse.DescribeInstanceAutoRenewAttribute_Item();
				item.DBInstanceId = context.StringValue("DescribeInstanceAutoRenewAttribute.Items["+ i +"].DBInstanceId");
				item.RegionId = context.StringValue("DescribeInstanceAutoRenewAttribute.Items["+ i +"].RegionId");
				item.Duration = context.IntegerValue("DescribeInstanceAutoRenewAttribute.Items["+ i +"].Duration");
				item.Status = context.StringValue("DescribeInstanceAutoRenewAttribute.Items["+ i +"].Status");
				item.AutoRenew = context.StringValue("DescribeInstanceAutoRenewAttribute.Items["+ i +"].AutoRenew");

				describeInstanceAutoRenewAttributeResponse_items.Add(item);
			}
			describeInstanceAutoRenewAttributeResponse.Items = describeInstanceAutoRenewAttributeResponse_items;
        
			return describeInstanceAutoRenewAttributeResponse;
        }
    }
}