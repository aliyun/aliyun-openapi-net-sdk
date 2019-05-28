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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeInstanceAutoRenewalAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAutoRenewalAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceAutoRenewalAttributeResponse describeInstanceAutoRenewalAttributeResponse = new DescribeInstanceAutoRenewalAttributeResponse();

			describeInstanceAutoRenewalAttributeResponse.HttpResponse = context.HttpResponse;
			describeInstanceAutoRenewalAttributeResponse.RequestId = context.StringValue("DescribeInstanceAutoRenewalAttribute.RequestId");
			describeInstanceAutoRenewalAttributeResponse.PageNumber = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.PageNumber");
			describeInstanceAutoRenewalAttributeResponse.TotalRecordCount = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.TotalRecordCount");
			describeInstanceAutoRenewalAttributeResponse.PageRecordCount = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.PageRecordCount");

			List<DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item> describeInstanceAutoRenewalAttributeResponse_items = new List<DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item>();
			for (int i = 0; i < context.Length("DescribeInstanceAutoRenewalAttribute.Items.Length"); i++) {
				DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item item = new DescribeInstanceAutoRenewalAttributeResponse.DescribeInstanceAutoRenewalAttribute_Item();
				item.DBInstanceId = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].DBInstanceId");
				item.RegionId = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].RegionId");
				item.Duration = context.IntegerValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].Duration");
				item.Status = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].Status");
				item.AutoRenew = context.StringValue("DescribeInstanceAutoRenewalAttribute.Items["+ i +"].AutoRenew");

				describeInstanceAutoRenewalAttributeResponse_items.Add(item);
			}
			describeInstanceAutoRenewalAttributeResponse.Items = describeInstanceAutoRenewalAttributeResponse_items;
        
			return describeInstanceAutoRenewalAttributeResponse;
        }
    }
}
