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
using Aliyun.Acs.Vpc.Model.V20160428;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeGrantRulesToCenResponseUnmarshaller
    {
        public static DescribeGrantRulesToCenResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeGrantRulesToCenResponse describeGrantRulesToCenResponse = new DescribeGrantRulesToCenResponse();

            describeGrantRulesToCenResponse.HttpResponse = context.HttpResponse;
            describeGrantRulesToCenResponse.RequestId = context.StringValue("DescribeGrantRulesToCen.RequestId");
            describeGrantRulesToCenResponse.TotalCount = context.IntegerValue("DescribeGrantRulesToCen.TotalCount");
            describeGrantRulesToCenResponse.PageNumber = context.IntegerValue("DescribeGrantRulesToCen.PageNumber");
            describeGrantRulesToCenResponse.PageSize = context.IntegerValue("DescribeGrantRulesToCen.PageSize");

            List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule> describeGrantRulesToCenResponse_cenGrantRules = new List<DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule>();
            for (int i = 0; i < context.Length("DescribeGrantRulesToCen.CenGrantRules.Length"); i++)
            {
                DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule cbnGrantRule = new DescribeGrantRulesToCenResponse.DescribeGrantRulesToCen_CbnGrantRule();
                cbnGrantRule.CenInstanceId = context.StringValue("DescribeGrantRulesToCen.CenGrantRules[" + i + "].CenInstanceId");
                cbnGrantRule.CenOwnerId = context.LongValue("DescribeGrantRulesToCen.CenGrantRules[" + i + "].CenOwnerId");
                cbnGrantRule.CreationTime = context.StringValue("DescribeGrantRulesToCen.CenGrantRules[" + i + "].CreationTime");

                describeGrantRulesToCenResponse_cenGrantRules.Add(cbnGrantRule);
            }
            describeGrantRulesToCenResponse.CenGrantRules = describeGrantRulesToCenResponse_cenGrantRules;

            return describeGrantRulesToCenResponse;
        }
    }
}