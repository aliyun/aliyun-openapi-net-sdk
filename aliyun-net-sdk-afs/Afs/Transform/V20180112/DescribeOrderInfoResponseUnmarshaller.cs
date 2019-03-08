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
using Aliyun.Acs.afs.Model.V20180112;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.afs.Transform.V20180112
{
    public class DescribeOrderInfoResponseUnmarshaller
    {
        public static DescribeOrderInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrderInfoResponse describeOrderInfoResponse = new DescribeOrderInfoResponse();

			describeOrderInfoResponse.HttpResponse = context.HttpResponse;
			describeOrderInfoResponse.RequestId = context.StringValue("DescribeOrderInfo.RequestId");
			describeOrderInfoResponse.BizCode = context.StringValue("DescribeOrderInfo.BizCode");
			describeOrderInfoResponse.OrderLevel = context.StringValue("DescribeOrderInfo.OrderLevel");
			describeOrderInfoResponse.Num = context.StringValue("DescribeOrderInfo.Num");
			describeOrderInfoResponse.BeginDate = context.StringValue("DescribeOrderInfo.BeginDate");
			describeOrderInfoResponse.EndDate = context.StringValue("DescribeOrderInfo.EndDate");
        
			return describeOrderInfoResponse;
        }
    }
}