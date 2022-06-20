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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeRiskTypeResponseUnmarshaller
    {
        public static DescribeRiskTypeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRiskTypeResponse describeRiskTypeResponse = new DescribeRiskTypeResponse();

			describeRiskTypeResponse.HttpResponse = _ctx.HttpResponse;
			describeRiskTypeResponse.RequestId = _ctx.StringValue("DescribeRiskType.RequestId");

			List<DescribeRiskTypeResponse.DescribeRiskType_RiskType> describeRiskTypeResponse_riskTypes = new List<DescribeRiskTypeResponse.DescribeRiskType_RiskType>();
			for (int i = 0; i < _ctx.Length("DescribeRiskType.RiskTypes.Length"); i++) {
				DescribeRiskTypeResponse.DescribeRiskType_RiskType riskType = new DescribeRiskTypeResponse.DescribeRiskType_RiskType();
				riskType.TypeName = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].TypeName");
				riskType.Alias = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].Alias");

				List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType> riskType_subTypes = new List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType>();
				for (int j = 0; j < _ctx.Length("DescribeRiskType.RiskTypes["+ i +"].SubTypes.Length"); j++) {
					DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType subType = new DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType();
					subType.TypeName = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].TypeName");
					subType.Alias = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].Alias");

					List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail> subType_checkDetails = new List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail>();
					for (int k = 0; k < _ctx.Length("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails.Length"); k++) {
						DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail checkDetail = new DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail();
						checkDetail.CheckId = _ctx.LongValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckId");
						checkDetail.CheckItem = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckItem");
						checkDetail.CheckDesc = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckDesc");

						List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule> checkDetail_rules = new List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule>();
						for (int l = 0; l < _ctx.Length("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules.Length"); l++) {
							DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule rule = new DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule();
							rule.Optional = _ctx.IntegerValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].Optional");
							rule.RuleDesc = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].RuleDesc");
							rule.DefaultValue = _ctx.IntegerValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].DefaultValue");
							rule.RuleId = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].RuleId");

							List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule.DescribeRiskType_Param> rule_paramList = new List<DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule.DescribeRiskType_Param>();
							for (int m = 0; m < _ctx.Length("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList.Length"); m++) {
								DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule.DescribeRiskType_Param param = new DescribeRiskTypeResponse.DescribeRiskType_RiskType.DescribeRiskType_SubType.DescribeRiskType_CheckDetail.DescribeRiskType_Rule.DescribeRiskType_Param();
								param.ParamDefaultValue = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamDefaultValue");
								param.ParamName = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamName");
								param.MaxValue = _ctx.IntegerValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].MaxValue");
								param.ParamType = _ctx.IntegerValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamType");
								param.ParamDesc = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamDesc");
								param.MinValue = _ctx.IntegerValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].MinValue");
								param.EnumValue = _ctx.StringValue("DescribeRiskType.RiskTypes["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].EnumValue");

								rule_paramList.Add(param);
							}
							rule.ParamList = rule_paramList;

							checkDetail_rules.Add(rule);
						}
						checkDetail.Rules = checkDetail_rules;

						subType_checkDetails.Add(checkDetail);
					}
					subType.CheckDetails = subType_checkDetails;

					riskType_subTypes.Add(subType);
				}
				riskType.SubTypes = riskType_subTypes;

				describeRiskTypeResponse_riskTypes.Add(riskType);
			}
			describeRiskTypeResponse.RiskTypes = describeRiskTypeResponse_riskTypes;
        
			return describeRiskTypeResponse;
        }
    }
}
