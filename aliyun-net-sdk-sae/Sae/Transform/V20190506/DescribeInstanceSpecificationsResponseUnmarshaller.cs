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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeInstanceSpecificationsResponseUnmarshaller
    {
        public static DescribeInstanceSpecificationsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceSpecificationsResponse describeInstanceSpecificationsResponse = new DescribeInstanceSpecificationsResponse();

			describeInstanceSpecificationsResponse.HttpResponse = context.HttpResponse;
			describeInstanceSpecificationsResponse.RequestId = context.StringValue("DescribeInstanceSpecifications.RequestId");
			describeInstanceSpecificationsResponse.Code = context.StringValue("DescribeInstanceSpecifications.Code");
			describeInstanceSpecificationsResponse.Message = context.StringValue("DescribeInstanceSpecifications.Message");
			describeInstanceSpecificationsResponse.Success = context.BooleanValue("DescribeInstanceSpecifications.Success");
			describeInstanceSpecificationsResponse.ErrorCode = context.StringValue("DescribeInstanceSpecifications.ErrorCode");
			describeInstanceSpecificationsResponse.TraceId = context.StringValue("DescribeInstanceSpecifications.TraceId");

			List<DescribeInstanceSpecificationsResponse.DescribeInstanceSpecifications_DataItem> describeInstanceSpecificationsResponse_data = new List<DescribeInstanceSpecificationsResponse.DescribeInstanceSpecifications_DataItem>();
			for (int i = 0; i < context.Length("DescribeInstanceSpecifications.Data.Length"); i++) {
				DescribeInstanceSpecificationsResponse.DescribeInstanceSpecifications_DataItem dataItem = new DescribeInstanceSpecificationsResponse.DescribeInstanceSpecifications_DataItem();
				dataItem.Cpu = context.IntegerValue("DescribeInstanceSpecifications.Data["+ i +"].Cpu");
				dataItem.Enable = context.BooleanValue("DescribeInstanceSpecifications.Data["+ i +"].Enable");
				dataItem.Id = context.IntegerValue("DescribeInstanceSpecifications.Data["+ i +"].Id");
				dataItem.Memory = context.IntegerValue("DescribeInstanceSpecifications.Data["+ i +"].Memory");
				dataItem.SpecInfo = context.StringValue("DescribeInstanceSpecifications.Data["+ i +"].SpecInfo");
				dataItem.Version = context.IntegerValue("DescribeInstanceSpecifications.Data["+ i +"].Version");

				describeInstanceSpecificationsResponse_data.Add(dataItem);
			}
			describeInstanceSpecificationsResponse.Data = describeInstanceSpecificationsResponse_data;
        
			return describeInstanceSpecificationsResponse;
        }
    }
}
