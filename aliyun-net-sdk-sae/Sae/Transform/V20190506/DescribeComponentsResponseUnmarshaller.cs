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
    public class DescribeComponentsResponseUnmarshaller
    {
        public static DescribeComponentsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeComponentsResponse describeComponentsResponse = new DescribeComponentsResponse();

			describeComponentsResponse.HttpResponse = context.HttpResponse;
			describeComponentsResponse.RequestId = context.StringValue("DescribeComponents.RequestId");
			describeComponentsResponse.Code = context.StringValue("DescribeComponents.Code");
			describeComponentsResponse.ErrorCode = context.StringValue("DescribeComponents.ErrorCode");
			describeComponentsResponse.Message = context.StringValue("DescribeComponents.Message");
			describeComponentsResponse.Success = context.BooleanValue("DescribeComponents.Success");
			describeComponentsResponse.TraceId = context.StringValue("DescribeComponents.TraceId");

			List<DescribeComponentsResponse.DescribeComponents_DataItem> describeComponentsResponse_data = new List<DescribeComponentsResponse.DescribeComponents_DataItem>();
			for (int i = 0; i < context.Length("DescribeComponents.Data.Length"); i++) {
				DescribeComponentsResponse.DescribeComponents_DataItem dataItem = new DescribeComponentsResponse.DescribeComponents_DataItem();
				dataItem.ComponentKey = context.StringValue("DescribeComponents.Data["+ i +"].ComponentKey");
				dataItem.ComponentDescription = context.StringValue("DescribeComponents.Data["+ i +"].ComponentDescription");
				dataItem.Expired = context.BooleanValue("DescribeComponents.Data["+ i +"].Expired");
				dataItem.Type = context.StringValue("DescribeComponents.Data["+ i +"].Type");

				describeComponentsResponse_data.Add(dataItem);
			}
			describeComponentsResponse.Data = describeComponentsResponse_data;
        
			return describeComponentsResponse;
        }
    }
}
