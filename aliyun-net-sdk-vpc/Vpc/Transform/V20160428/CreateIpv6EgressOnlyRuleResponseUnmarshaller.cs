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
    public class CreateIpv6EgressOnlyRuleResponseUnmarshaller
    {
        public static CreateIpv6EgressOnlyRuleResponse Unmarshall(UnmarshallerContext context)
        {
            CreateIpv6EgressOnlyRuleResponse createIpv6EgressOnlyRuleResponse = new CreateIpv6EgressOnlyRuleResponse();

            createIpv6EgressOnlyRuleResponse.HttpResponse = context.HttpResponse;
            createIpv6EgressOnlyRuleResponse.RequestId = context.StringValue("CreateIpv6EgressOnlyRule.RequestId");
            createIpv6EgressOnlyRuleResponse.Ipv6EgressRuleId = context.StringValue("CreateIpv6EgressOnlyRule.Ipv6EgressRuleId");

            return createIpv6EgressOnlyRuleResponse;
        }
    }
}