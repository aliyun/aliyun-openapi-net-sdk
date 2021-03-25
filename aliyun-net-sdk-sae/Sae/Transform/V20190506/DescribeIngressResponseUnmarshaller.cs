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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeIngressResponseUnmarshaller
    {
        public static DescribeIngressResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeIngressResponse describeIngressResponse = new DescribeIngressResponse();

			describeIngressResponse.HttpResponse = _ctx.HttpResponse;
			describeIngressResponse.RequestId = _ctx.StringValue("DescribeIngress.RequestId");
			describeIngressResponse.Code = _ctx.StringValue("DescribeIngress.Code");
			describeIngressResponse.Message = _ctx.StringValue("DescribeIngress.Message");
			describeIngressResponse.Success = _ctx.BooleanValue("DescribeIngress.Success");
			describeIngressResponse.ErrorCode = _ctx.StringValue("DescribeIngress.ErrorCode");
			describeIngressResponse.TraceId = _ctx.StringValue("DescribeIngress.TraceId");

			DescribeIngressResponse.DescribeIngress_Data data = new DescribeIngressResponse.DescribeIngress_Data();
			data.Id = _ctx.LongValue("DescribeIngress.Data.Id");
			data.Name = _ctx.StringValue("DescribeIngress.Data.Name");
			data.NamespaceId = _ctx.StringValue("DescribeIngress.Data.NamespaceId");
			data.Description = _ctx.StringValue("DescribeIngress.Data.Description");
			data.SlbId = _ctx.StringValue("DescribeIngress.Data.SlbId");
			data.ListenerPort = _ctx.IntegerValue("DescribeIngress.Data.ListenerPort");
			data.CertId = _ctx.StringValue("DescribeIngress.Data.CertId");
			data.SlbType = _ctx.StringValue("DescribeIngress.Data.SlbType");

			DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_DefaultRule defaultRule = new DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_DefaultRule();
			defaultRule.AppId = _ctx.StringValue("DescribeIngress.Data.DefaultRule.AppId");
			defaultRule.ContainerPort = _ctx.IntegerValue("DescribeIngress.Data.DefaultRule.ContainerPort");
			defaultRule.AppName = _ctx.StringValue("DescribeIngress.Data.DefaultRule.AppName");
			data.DefaultRule = defaultRule;

			List<DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule> data_rules = new List<DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule>();
			for (int i = 0; i < _ctx.Length("DescribeIngress.Data.Rules.Length"); i++) {
				DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule rule = new DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule();
				rule.AppId = _ctx.StringValue("DescribeIngress.Data.Rules["+ i +"].AppId");
				rule.ContainerPort = _ctx.IntegerValue("DescribeIngress.Data.Rules["+ i +"].ContainerPort");
				rule.Domain = _ctx.StringValue("DescribeIngress.Data.Rules["+ i +"].Domain");
				rule.Path = _ctx.StringValue("DescribeIngress.Data.Rules["+ i +"].Path");
				rule.AppName = _ctx.StringValue("DescribeIngress.Data.Rules["+ i +"].AppName");

				data_rules.Add(rule);
			}
			data.Rules = data_rules;
			describeIngressResponse.Data = data;
        
			return describeIngressResponse;
        }
    }
}
