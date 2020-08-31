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
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class DescribeComplianceSummaryResponseUnmarshaller
    {
        public static DescribeComplianceSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeComplianceSummaryResponse describeComplianceSummaryResponse = new DescribeComplianceSummaryResponse();

			describeComplianceSummaryResponse.HttpResponse = context.HttpResponse;
			describeComplianceSummaryResponse.RequestId = context.StringValue("DescribeComplianceSummary.RequestId");

			DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary complianceSummary = new DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary();

			DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary.DescribeComplianceSummary_ComplianceSummaryByConfigRule complianceSummaryByConfigRule = new DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary.DescribeComplianceSummary_ComplianceSummaryByConfigRule();
			complianceSummaryByConfigRule.ComplianceSummaryTimestamp = context.LongValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByConfigRule.ComplianceSummaryTimestamp");
			complianceSummaryByConfigRule.CompliantCount = context.IntegerValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByConfigRule.CompliantCount");
			complianceSummaryByConfigRule.NonCompliantCount = context.IntegerValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByConfigRule.NonCompliantCount");
			complianceSummaryByConfigRule.TotalCount = context.LongValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByConfigRule.TotalCount");
			complianceSummary.ComplianceSummaryByConfigRule = complianceSummaryByConfigRule;

			DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary.DescribeComplianceSummary_ComplianceSummaryByResource complianceSummaryByResource = new DescribeComplianceSummaryResponse.DescribeComplianceSummary_ComplianceSummary.DescribeComplianceSummary_ComplianceSummaryByResource();
			complianceSummaryByResource.ComplianceSummaryTimestamp = context.LongValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByResource.ComplianceSummaryTimestamp");
			complianceSummaryByResource.CompliantCount = context.IntegerValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByResource.CompliantCount");
			complianceSummaryByResource.NonCompliantCount = context.IntegerValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByResource.NonCompliantCount");
			complianceSummaryByResource.TotalCount = context.LongValue("DescribeComplianceSummary.ComplianceSummary.ComplianceSummaryByResource.TotalCount");
			complianceSummary.ComplianceSummaryByResource = complianceSummaryByResource;
			describeComplianceSummaryResponse.ComplianceSummary = complianceSummary;
        
			return describeComplianceSummaryResponse;
        }
    }
}
