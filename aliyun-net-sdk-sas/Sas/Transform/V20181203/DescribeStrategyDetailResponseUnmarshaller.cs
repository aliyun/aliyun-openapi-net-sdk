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
    public class DescribeStrategyDetailResponseUnmarshaller
    {
        public static DescribeStrategyDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeStrategyDetailResponse describeStrategyDetailResponse = new DescribeStrategyDetailResponse();

			describeStrategyDetailResponse.HttpResponse = _ctx.HttpResponse;
			describeStrategyDetailResponse.RequestId = _ctx.StringValue("DescribeStrategyDetail.RequestId");

			DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy strategy = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy();
			strategy.Type = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.Type");
			strategy.CycleDays = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.CycleDays");
			strategy.Name = _ctx.StringValue("DescribeStrategyDetail.Strategy.Name");
			strategy.Id = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.Id");
			strategy.CycleStartTime = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.CycleStartTime");

			List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult> strategy_riskTypeWhiteListQueryResultList = new List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult>();
			for (int i = 0; i < _ctx.Length("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList.Length"); i++) {
				DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult riskTypeWhiteListQueryResult = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult();
				riskTypeWhiteListQueryResult.TypeName = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].TypeName");
				riskTypeWhiteListQueryResult.Alias = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].Alias");
				riskTypeWhiteListQueryResult.On = _ctx.BooleanValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].On");

				List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType> riskTypeWhiteListQueryResult_subTypes = new List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType>();
				for (int j = 0; j < _ctx.Length("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes.Length"); j++) {
					DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType subType = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType();
					subType.TypeName = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].TypeName");
					subType.Alias = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].Alias");
					subType.On = _ctx.BooleanValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].On");

					List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail> subType_checkDetails = new List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail>();
					for (int k = 0; k < _ctx.Length("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails.Length"); k++) {
						DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail checkDetail = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail();
						checkDetail.CheckId = _ctx.LongValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckId");
						checkDetail.CheckItem = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckItem");
						checkDetail.CheckDesc = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].CheckDesc");

						List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule> checkDetail_rules = new List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule>();
						for (int l = 0; l < _ctx.Length("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules.Length"); l++) {
							DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule rule = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule();
							rule.Optional = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].Optional");
							rule.RuleDesc = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].RuleDesc");
							rule.DefaultValue = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].DefaultValue");
							rule.RuleId = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].RuleId");

							List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule.DescribeStrategyDetail_Param> rule_paramList = new List<DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule.DescribeStrategyDetail_Param>();
							for (int m = 0; m < _ctx.Length("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList.Length"); m++) {
								DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule.DescribeStrategyDetail_Param param = new DescribeStrategyDetailResponse.DescribeStrategyDetail_Strategy.DescribeStrategyDetail_RiskTypeWhiteListQueryResult.DescribeStrategyDetail_SubType.DescribeStrategyDetail_CheckDetail.DescribeStrategyDetail_Rule.DescribeStrategyDetail_Param();
								param.ParamDefaultValue = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamDefaultValue");
								param._Value = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].Value");
								param.ParamName = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamName");
								param.MaxValue = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].MaxValue");
								param.ParamType = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamType");
								param.ParamDesc = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].ParamDesc");
								param.MinValue = _ctx.IntegerValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].MinValue");
								param.EnumValue = _ctx.StringValue("DescribeStrategyDetail.Strategy.RiskTypeWhiteListQueryResultList["+ i +"].SubTypes["+ j +"].CheckDetails["+ k +"].Rules["+ l +"].ParamList["+ m +"].EnumValue");

								rule_paramList.Add(param);
							}
							rule.ParamList = rule_paramList;

							checkDetail_rules.Add(rule);
						}
						checkDetail.Rules = checkDetail_rules;

						subType_checkDetails.Add(checkDetail);
					}
					subType.CheckDetails = subType_checkDetails;

					riskTypeWhiteListQueryResult_subTypes.Add(subType);
				}
				riskTypeWhiteListQueryResult.SubTypes = riskTypeWhiteListQueryResult_subTypes;

				strategy_riskTypeWhiteListQueryResultList.Add(riskTypeWhiteListQueryResult);
			}
			strategy.RiskTypeWhiteListQueryResultList = strategy_riskTypeWhiteListQueryResultList;
			describeStrategyDetailResponse.Strategy = strategy;
        
			return describeStrategyDetailResponse;
        }
    }
}
