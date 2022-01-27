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
        public static DescribeComponentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeComponentsResponse describeComponentsResponse = new DescribeComponentsResponse();

			describeComponentsResponse.HttpResponse = _ctx.HttpResponse;
			describeComponentsResponse.RequestId = _ctx.StringValue("DescribeComponents.RequestId");
			describeComponentsResponse.Code = _ctx.StringValue("DescribeComponents.Code");
			describeComponentsResponse.ErrorCode = _ctx.StringValue("DescribeComponents.ErrorCode");
			describeComponentsResponse.Message = _ctx.StringValue("DescribeComponents.Message");
			describeComponentsResponse.Success = _ctx.BooleanValue("DescribeComponents.Success");
			describeComponentsResponse.TraceId = _ctx.StringValue("DescribeComponents.TraceId");

			List<DescribeComponentsResponse.DescribeComponents_DataItem> describeComponentsResponse_data = new List<DescribeComponentsResponse.DescribeComponents_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeComponents.Data.Length"); i++) {
				DescribeComponentsResponse.DescribeComponents_DataItem dataItem = new DescribeComponentsResponse.DescribeComponents_DataItem();
				dataItem.ComponentKey = _ctx.StringValue("DescribeComponents.Data["+ i +"].ComponentKey");
				dataItem.ComponentDescription = _ctx.StringValue("DescribeComponents.Data["+ i +"].ComponentDescription");
				dataItem.Expired = _ctx.BooleanValue("DescribeComponents.Data["+ i +"].Expired");
				dataItem.Type = _ctx.StringValue("DescribeComponents.Data["+ i +"].Type");

				describeComponentsResponse_data.Add(dataItem);
			}
			describeComponentsResponse.Data = describeComponentsResponse_data;
        
			return describeComponentsResponse;
        }
    }
}
