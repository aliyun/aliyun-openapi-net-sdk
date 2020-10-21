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
        public static DescribeIngressResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIngressResponse describeIngressResponse = new DescribeIngressResponse();

			describeIngressResponse.HttpResponse = context.HttpResponse;
			describeIngressResponse.RequestId = context.StringValue("DescribeIngress.RequestId");
			describeIngressResponse.Code = context.StringValue("DescribeIngress.Code");
			describeIngressResponse.Message = context.StringValue("DescribeIngress.Message");
			describeIngressResponse.Success = context.BooleanValue("DescribeIngress.Success");
			describeIngressResponse.ErrorCode = context.StringValue("DescribeIngress.ErrorCode");
			describeIngressResponse.TraceId = context.StringValue("DescribeIngress.TraceId");

			DescribeIngressResponse.DescribeIngress_Data data = new DescribeIngressResponse.DescribeIngress_Data();
			data.Id = context.LongValue("DescribeIngress.Data.Id");
			data.Name = context.StringValue("DescribeIngress.Data.Name");
			data.NamespaceId = context.StringValue("DescribeIngress.Data.NamespaceId");
			data.Description = context.StringValue("DescribeIngress.Data.Description");
			data.SlbId = context.StringValue("DescribeIngress.Data.SlbId");
			data.ListenerPort = context.IntegerValue("DescribeIngress.Data.ListenerPort");
			data.CertId = context.StringValue("DescribeIngress.Data.CertId");
			data.SlbType = context.StringValue("DescribeIngress.Data.SlbType");

			DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_DefaultRule defaultRule = new DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_DefaultRule();
			defaultRule.AppId = context.StringValue("DescribeIngress.Data.DefaultRule.AppId");
			defaultRule.ContainerPort = context.IntegerValue("DescribeIngress.Data.DefaultRule.ContainerPort");
			defaultRule.AppName = context.StringValue("DescribeIngress.Data.DefaultRule.AppName");
			data.DefaultRule = defaultRule;

			List<DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule> data_rules = new List<DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule>();
			for (int i = 0; i < context.Length("DescribeIngress.Data.Rules.Length"); i++) {
				DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule rule = new DescribeIngressResponse.DescribeIngress_Data.DescribeIngress_Rule();
				rule.AppId = context.StringValue("DescribeIngress.Data.Rules["+ i +"].AppId");
				rule.ContainerPort = context.IntegerValue("DescribeIngress.Data.Rules["+ i +"].ContainerPort");
				rule.Domain = context.StringValue("DescribeIngress.Data.Rules["+ i +"].Domain");
				rule.Path = context.StringValue("DescribeIngress.Data.Rules["+ i +"].Path");
				rule.AppName = context.StringValue("DescribeIngress.Data.Rules["+ i +"].AppName");

				data_rules.Add(rule);
			}
			data.Rules = data_rules;
			describeIngressResponse.Data = data;
        
			return describeIngressResponse;
        }
    }
}
