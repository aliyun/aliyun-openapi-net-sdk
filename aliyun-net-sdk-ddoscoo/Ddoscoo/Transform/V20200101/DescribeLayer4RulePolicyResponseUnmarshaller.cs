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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeLayer4RulePolicyResponseUnmarshaller
    {
        public static DescribeLayer4RulePolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLayer4RulePolicyResponse describeLayer4RulePolicyResponse = new DescribeLayer4RulePolicyResponse();

			describeLayer4RulePolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeLayer4RulePolicyResponse.RequestId = _ctx.StringValue("DescribeLayer4RulePolicy.RequestId");
			describeLayer4RulePolicyResponse.InstanceId = _ctx.StringValue("DescribeLayer4RulePolicy.InstanceId");
			describeLayer4RulePolicyResponse.FrontendPort = _ctx.IntegerValue("DescribeLayer4RulePolicy.FrontendPort");
			describeLayer4RulePolicyResponse.BackendPort = _ctx.IntegerValue("DescribeLayer4RulePolicy.BackendPort");
			describeLayer4RulePolicyResponse.ForwardProtocol = _ctx.StringValue("DescribeLayer4RulePolicy.ForwardProtocol");
			describeLayer4RulePolicyResponse.BakMode = _ctx.StringValue("DescribeLayer4RulePolicy.BakMode");
			describeLayer4RulePolicyResponse.CurrentIndex = _ctx.IntegerValue("DescribeLayer4RulePolicy.CurrentIndex");

			List<DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_PriRealServersItem> describeLayer4RulePolicyResponse_priRealServers = new List<DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_PriRealServersItem>();
			for (int i = 0; i < _ctx.Length("DescribeLayer4RulePolicy.PriRealServers.Length"); i++) {
				DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_PriRealServersItem priRealServersItem = new DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_PriRealServersItem();
				priRealServersItem.InstanceId = _ctx.StringValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].InstanceId");
				priRealServersItem.Eip = _ctx.StringValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].Eip");
				priRealServersItem.FrontendPort = _ctx.IntegerValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].FrontendPort");
				priRealServersItem.Protocol = _ctx.StringValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].Protocol");
				priRealServersItem.RealServer = _ctx.StringValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].RealServer");
				priRealServersItem.CurrentIndex = _ctx.IntegerValue("DescribeLayer4RulePolicy.PriRealServers["+ i +"].CurrentIndex");

				describeLayer4RulePolicyResponse_priRealServers.Add(priRealServersItem);
			}
			describeLayer4RulePolicyResponse.PriRealServers = describeLayer4RulePolicyResponse_priRealServers;

			List<DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_SecRealServersItem> describeLayer4RulePolicyResponse_secRealServers = new List<DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_SecRealServersItem>();
			for (int i = 0; i < _ctx.Length("DescribeLayer4RulePolicy.SecRealServers.Length"); i++) {
				DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_SecRealServersItem secRealServersItem = new DescribeLayer4RulePolicyResponse.DescribeLayer4RulePolicy_SecRealServersItem();
				secRealServersItem.InstanceId = _ctx.StringValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].InstanceId");
				secRealServersItem.Eip = _ctx.StringValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].Eip");
				secRealServersItem.FrontendPort = _ctx.IntegerValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].FrontendPort");
				secRealServersItem.Protocol = _ctx.StringValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].Protocol");
				secRealServersItem.RealServer = _ctx.StringValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].RealServer");
				secRealServersItem.CurrentIndex = _ctx.IntegerValue("DescribeLayer4RulePolicy.SecRealServers["+ i +"].CurrentIndex");

				describeLayer4RulePolicyResponse_secRealServers.Add(secRealServersItem);
			}
			describeLayer4RulePolicyResponse.SecRealServers = describeLayer4RulePolicyResponse_secRealServers;
        
			return describeLayer4RulePolicyResponse;
        }
    }
}
