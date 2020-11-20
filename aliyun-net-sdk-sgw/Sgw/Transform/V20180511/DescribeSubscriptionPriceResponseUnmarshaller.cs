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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeSubscriptionPriceResponseUnmarshaller
    {
        public static DescribeSubscriptionPriceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSubscriptionPriceResponse describeSubscriptionPriceResponse = new DescribeSubscriptionPriceResponse();

			describeSubscriptionPriceResponse.HttpResponse = context.HttpResponse;
			describeSubscriptionPriceResponse.RequestId = context.StringValue("DescribeSubscriptionPrice.RequestId");
			describeSubscriptionPriceResponse.Success = context.BooleanValue("DescribeSubscriptionPrice.Success");
			describeSubscriptionPriceResponse.Code = context.StringValue("DescribeSubscriptionPrice.Code");
			describeSubscriptionPriceResponse.Message = context.StringValue("DescribeSubscriptionPrice.Message");
			describeSubscriptionPriceResponse.Currency = context.StringValue("DescribeSubscriptionPrice.Currency");
			describeSubscriptionPriceResponse.TradePrice = context.FloatValue("DescribeSubscriptionPrice.TradePrice");
        
			return describeSubscriptionPriceResponse;
        }
    }
}
