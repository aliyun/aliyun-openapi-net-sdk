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
using Aliyun.Acs.cloud_siem.Model.V20220616;

namespace Aliyun.Acs.cloud_siem.Transform.V20220616
{
    public class DescribeAggregateFunctionResponseUnmarshaller
    {
        public static DescribeAggregateFunctionResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAggregateFunctionResponse describeAggregateFunctionResponse = new DescribeAggregateFunctionResponse();

			describeAggregateFunctionResponse.HttpResponse = _ctx.HttpResponse;
			describeAggregateFunctionResponse.Success = _ctx.BooleanValue("DescribeAggregateFunction.Success");
			describeAggregateFunctionResponse.Code = _ctx.IntegerValue("DescribeAggregateFunction.Code");
			describeAggregateFunctionResponse.Message = _ctx.StringValue("DescribeAggregateFunction.Message");
			describeAggregateFunctionResponse.RequestId = _ctx.StringValue("DescribeAggregateFunction.RequestId");

			List<DescribeAggregateFunctionResponse.DescribeAggregateFunction_DataItem> describeAggregateFunctionResponse_data = new List<DescribeAggregateFunctionResponse.DescribeAggregateFunction_DataItem>();
			for (int i = 0; i < _ctx.Length("DescribeAggregateFunction.Data.Length"); i++) {
				DescribeAggregateFunctionResponse.DescribeAggregateFunction_DataItem dataItem = new DescribeAggregateFunctionResponse.DescribeAggregateFunction_DataItem();
				dataItem.Function = _ctx.StringValue("DescribeAggregateFunction.Data["+ i +"].Function");
				dataItem.FunctionName = _ctx.StringValue("DescribeAggregateFunction.Data["+ i +"].FunctionName");

				describeAggregateFunctionResponse_data.Add(dataItem);
			}
			describeAggregateFunctionResponse.Data = describeAggregateFunctionResponse_data;
        
			return describeAggregateFunctionResponse;
        }
    }
}
