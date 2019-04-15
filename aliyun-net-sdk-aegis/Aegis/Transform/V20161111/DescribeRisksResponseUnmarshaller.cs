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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeRisksResponseUnmarshaller
    {
        public static DescribeRisksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRisksResponse describeRisksResponse = new DescribeRisksResponse();

			describeRisksResponse.HttpResponse = context.HttpResponse;
			describeRisksResponse.RequestId = context.StringValue("DescribeRisks.RequestId");
			describeRisksResponse.TotalCount = context.IntegerValue("DescribeRisks.TotalCount");

			List<DescribeRisksResponse.DescribeRisks_Risk> describeRisksResponse_risks = new List<DescribeRisksResponse.DescribeRisks_Risk>();
			for (int i = 0; i < context.Length("DescribeRisks.Risks.Length"); i++) {
				DescribeRisksResponse.DescribeRisks_Risk risk = new DescribeRisksResponse.DescribeRisks_Risk();
				risk.RiskId = context.LongValue("DescribeRisks.Risks["+ i +"].RiskId");
				risk.RiskName = context.StringValue("DescribeRisks.Risks["+ i +"].RiskName");
				risk.RiskDetail = context.StringValue("DescribeRisks.Risks["+ i +"].RiskDetail");
				risk.RiskType = context.StringValue("DescribeRisks.Risks["+ i +"].RiskType");
				risk.TypeAlias = context.StringValue("DescribeRisks.Risks["+ i +"].TypeAlias");
				risk.SubRiskType = context.StringValue("DescribeRisks.Risks["+ i +"].SubRiskType");
				risk.SubTypeAlias = context.StringValue("DescribeRisks.Risks["+ i +"].SubTypeAlias");

				describeRisksResponse_risks.Add(risk);
			}
			describeRisksResponse.Risks = describeRisksResponse_risks;
        
			return describeRisksResponse;
        }
    }
}
