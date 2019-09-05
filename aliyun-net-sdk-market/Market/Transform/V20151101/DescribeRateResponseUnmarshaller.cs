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
    public class DescribeRateResponseUnmarshaller
    {
        public static DescribeRateResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRateResponse describeRateResponse = new DescribeRateResponse();

			describeRateResponse.HttpResponse = context.HttpResponse;
			describeRateResponse.Id = context.LongValue("DescribeRate.Id");
			describeRateResponse.OrderId = context.StringValue("DescribeRate.OrderId");
			describeRateResponse.InstanceId = context.StringValue("DescribeRate.InstanceId");
			describeRateResponse.AliUid = context.LongValue("DescribeRate.AliUid");
			describeRateResponse.ProductId = context.StringValue("DescribeRate.ProductId");
			describeRateResponse.Score = context.StringValue("DescribeRate.Score");
			describeRateResponse.Content = context.StringValue("DescribeRate.Content");
			describeRateResponse.GmtCreated = context.LongValue("DescribeRate.GmtCreated");
			describeRateResponse.Explaintion = context.StringValue("DescribeRate.Explaintion");
			describeRateResponse.GmtExplaintion = context.LongValue("DescribeRate.GmtExplaintion");
			describeRateResponse.AdditionalContent = context.StringValue("DescribeRate.AdditionalContent");
			describeRateResponse.GmtAdditional = context.LongValue("DescribeRate.GmtAdditional");
			describeRateResponse.AdditionalExplaintion = context.StringValue("DescribeRate.AdditionalExplaintion");
			describeRateResponse.GmtAdditionalExplaintion = context.LongValue("DescribeRate.GmtAdditionalExplaintion");
			describeRateResponse.Type = context.StringValue("DescribeRate.Type");
			describeRateResponse.RequestId = context.StringValue("DescribeRate.RequestId");
        
			return describeRateResponse;
        }
    }
}
