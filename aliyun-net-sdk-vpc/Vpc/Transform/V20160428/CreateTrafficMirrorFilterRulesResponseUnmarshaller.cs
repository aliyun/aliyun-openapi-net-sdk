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
    public class CreateTrafficMirrorFilterRulesResponseUnmarshaller
    {
        public static CreateTrafficMirrorFilterRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateTrafficMirrorFilterRulesResponse createTrafficMirrorFilterRulesResponse = new CreateTrafficMirrorFilterRulesResponse();

			createTrafficMirrorFilterRulesResponse.HttpResponse = _ctx.HttpResponse;
			createTrafficMirrorFilterRulesResponse.RequestId = _ctx.StringValue("CreateTrafficMirrorFilterRules.RequestId");

			List<CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_IngressRule> createTrafficMirrorFilterRulesResponse_ingressRules = new List<CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_IngressRule>();
			for (int i = 0; i < _ctx.Length("CreateTrafficMirrorFilterRules.IngressRules.Length"); i++) {
				CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_IngressRule ingressRule = new CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_IngressRule();
				ingressRule.InstanceId = _ctx.StringValue("CreateTrafficMirrorFilterRules.IngressRules["+ i +"].InstanceId");

				createTrafficMirrorFilterRulesResponse_ingressRules.Add(ingressRule);
			}
			createTrafficMirrorFilterRulesResponse.IngressRules = createTrafficMirrorFilterRulesResponse_ingressRules;

			List<CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_EgressRule> createTrafficMirrorFilterRulesResponse_egressRules = new List<CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_EgressRule>();
			for (int i = 0; i < _ctx.Length("CreateTrafficMirrorFilterRules.EgressRules.Length"); i++) {
				CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_EgressRule egressRule = new CreateTrafficMirrorFilterRulesResponse.CreateTrafficMirrorFilterRules_EgressRule();
				egressRule.InstanceId = _ctx.StringValue("CreateTrafficMirrorFilterRules.EgressRules["+ i +"].InstanceId");

				createTrafficMirrorFilterRulesResponse_egressRules.Add(egressRule);
			}
			createTrafficMirrorFilterRulesResponse.EgressRules = createTrafficMirrorFilterRulesResponse_egressRules;
        
			return createTrafficMirrorFilterRulesResponse;
        }
    }
}
