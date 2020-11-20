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
    public class DescribeComplianceResponseUnmarshaller
    {
        public static DescribeComplianceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeComplianceResponse describeComplianceResponse = new DescribeComplianceResponse();

			describeComplianceResponse.HttpResponse = _ctx.HttpResponse;
			describeComplianceResponse.RequestId = _ctx.StringValue("DescribeCompliance.RequestId");

			DescribeComplianceResponse.DescribeCompliance_ComplianceResult complianceResult = new DescribeComplianceResponse.DescribeCompliance_ComplianceResult();
			complianceResult.TotalCount = _ctx.LongValue("DescribeCompliance.ComplianceResult.TotalCount");

			List<DescribeComplianceResponse.DescribeCompliance_ComplianceResult.DescribeCompliance_CompliancesItem> complianceResult_compliances = new List<DescribeComplianceResponse.DescribeCompliance_ComplianceResult.DescribeCompliance_CompliancesItem>();
			for (int i = 0; i < _ctx.Length("DescribeCompliance.ComplianceResult.Compliances.Length"); i++) {
				DescribeComplianceResponse.DescribeCompliance_ComplianceResult.DescribeCompliance_CompliancesItem compliancesItem = new DescribeComplianceResponse.DescribeCompliance_ComplianceResult.DescribeCompliance_CompliancesItem();
				compliancesItem.ComplianceType = _ctx.StringValue("DescribeCompliance.ComplianceResult.Compliances["+ i +"].ComplianceType");
				compliancesItem.Count = _ctx.IntegerValue("DescribeCompliance.ComplianceResult.Compliances["+ i +"].Count");

				complianceResult_compliances.Add(compliancesItem);
			}
			complianceResult.Compliances = complianceResult_compliances;
			describeComplianceResponse.ComplianceResult = complianceResult;
        
			return describeComplianceResponse;
        }
    }
}
