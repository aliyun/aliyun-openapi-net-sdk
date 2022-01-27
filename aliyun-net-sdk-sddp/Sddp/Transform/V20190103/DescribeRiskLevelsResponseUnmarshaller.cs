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
using Aliyun.Acs.Sddp.Model.V20190103;

namespace Aliyun.Acs.Sddp.Transform.V20190103
{
    public class DescribeRiskLevelsResponseUnmarshaller
    {
        public static DescribeRiskLevelsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRiskLevelsResponse describeRiskLevelsResponse = new DescribeRiskLevelsResponse();

			describeRiskLevelsResponse.HttpResponse = _ctx.HttpResponse;
			describeRiskLevelsResponse.RequestId = _ctx.StringValue("DescribeRiskLevels.RequestId");

			List<DescribeRiskLevelsResponse.DescribeRiskLevels_RiskLevel> describeRiskLevelsResponse_riskLevelList = new List<DescribeRiskLevelsResponse.DescribeRiskLevels_RiskLevel>();
			for (int i = 0; i < _ctx.Length("DescribeRiskLevels.RiskLevelList.Length"); i++) {
				DescribeRiskLevelsResponse.DescribeRiskLevels_RiskLevel riskLevel = new DescribeRiskLevelsResponse.DescribeRiskLevels_RiskLevel();
				riskLevel.Id = _ctx.LongValue("DescribeRiskLevels.RiskLevelList["+ i +"].Id");
				riskLevel.Description = _ctx.StringValue("DescribeRiskLevels.RiskLevelList["+ i +"].Description");
				riskLevel.Name = _ctx.StringValue("DescribeRiskLevels.RiskLevelList["+ i +"].Name");
				riskLevel.Alias = _ctx.StringValue("DescribeRiskLevels.RiskLevelList["+ i +"].Alias");
				riskLevel.ReferenceNum = _ctx.IntegerValue("DescribeRiskLevels.RiskLevelList["+ i +"].ReferenceNum");

				describeRiskLevelsResponse_riskLevelList.Add(riskLevel);
			}
			describeRiskLevelsResponse.RiskLevelList = describeRiskLevelsResponse_riskLevelList;
        
			return describeRiskLevelsResponse;
        }
    }
}
