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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class DescribeApiMeteringResponseUnmarshaller
    {
        public static DescribeApiMeteringResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApiMeteringResponse describeApiMeteringResponse = new DescribeApiMeteringResponse();

			describeApiMeteringResponse.HttpResponse = _ctx.HttpResponse;
			describeApiMeteringResponse.RequestId = _ctx.StringValue("DescribeApiMetering.RequestId");
			describeApiMeteringResponse.Code = _ctx.StringValue("DescribeApiMetering.Code");
			describeApiMeteringResponse.PageNumber = _ctx.LongValue("DescribeApiMetering.PageNumber");
			describeApiMeteringResponse.Success = _ctx.BooleanValue("DescribeApiMetering.Success");
			describeApiMeteringResponse.Count = _ctx.LongValue("DescribeApiMetering.Count");
			describeApiMeteringResponse.PageSize = _ctx.LongValue("DescribeApiMetering.PageSize");
			describeApiMeteringResponse.Message = _ctx.StringValue("DescribeApiMetering.Message");
			describeApiMeteringResponse.Version = _ctx.StringValue("DescribeApiMetering.Version");
			describeApiMeteringResponse.Fatal = _ctx.BooleanValue("DescribeApiMetering.Fatal");

			List<DescribeApiMeteringResponse.DescribeApiMetering_ResultItem> describeApiMeteringResponse_result = new List<DescribeApiMeteringResponse.DescribeApiMetering_ResultItem>();
			for (int i = 0; i < _ctx.Length("DescribeApiMetering.Result.Length"); i++) {
				DescribeApiMeteringResponse.DescribeApiMetering_ResultItem resultItem = new DescribeApiMeteringResponse.DescribeApiMetering_ResultItem();
				resultItem.AliyunPk = _ctx.LongValue("DescribeApiMetering.Result["+ i +"].AliyunPk");
				resultItem.ProductCode = _ctx.StringValue("DescribeApiMetering.Result["+ i +"].ProductCode");
				resultItem.ProductName = _ctx.StringValue("DescribeApiMetering.Result["+ i +"].ProductName");
				resultItem.TotalQuota = _ctx.LongValue("DescribeApiMetering.Result["+ i +"].TotalQuota");
				resultItem.TotalUsage = _ctx.LongValue("DescribeApiMetering.Result["+ i +"].TotalUsage");
				resultItem.TotalCapacity = _ctx.LongValue("DescribeApiMetering.Result["+ i +"].TotalCapacity");
				resultItem.Unit = _ctx.StringValue("DescribeApiMetering.Result["+ i +"].Unit");

				describeApiMeteringResponse_result.Add(resultItem);
			}
			describeApiMeteringResponse.Result = describeApiMeteringResponse_result;
        
			return describeApiMeteringResponse;
        }
    }
}
