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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeGrantRulesToCenResponseUnmarshaller
    {
        public static DescribeGrantRulesToCenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGrantRulesToCenResponse describeGrantRulesToCenResponse = new DescribeGrantRulesToCenResponse();

			describeGrantRulesToCenResponse.HttpResponse = _ctx.HttpResponse;
			describeGrantRulesToCenResponse.RequestId = _ctx.StringValue("DescribeGrantRulesToCen.RequestId");
			describeGrantRulesToCenResponse.TotalCount = _ctx.IntegerValue("DescribeGrantRulesToCen.TotalCount");
			describeGrantRulesToCenResponse.PageNumber = _ctx.IntegerValue("DescribeGrantRulesToCen.PageNumber");
			describeGrantRulesToCenResponse.PageSize = _ctx.IntegerValue("DescribeGrantRulesToCen.PageSize");

			List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule> describeGrantRulesToCenResponse_cenGrantRules = new List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule>();
			for (int i = 0; i < _ctx.Length("DescribeGrantRulesToCen.CenGrantRules.Length"); i++) {
				DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule cbnGrantRule = new DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule();
				cbnGrantRule.CenInstanceId = _ctx.StringValue("DescribeGrantRulesToCen.CenGrantRules["+ i +"].CenInstanceId");
				cbnGrantRule.CenOwnerId = _ctx.LongValue("DescribeGrantRulesToCen.CenGrantRules["+ i +"].CenOwnerId");
				cbnGrantRule.CreationTime = _ctx.StringValue("DescribeGrantRulesToCen.CenGrantRules["+ i +"].CreationTime");

				describeGrantRulesToCenResponse_cenGrantRules.Add(cbnGrantRule);
			}
			describeGrantRulesToCenResponse.CenGrantRules = describeGrantRulesToCenResponse_cenGrantRules;
        
			return describeGrantRulesToCenResponse;
        }
    }
}
