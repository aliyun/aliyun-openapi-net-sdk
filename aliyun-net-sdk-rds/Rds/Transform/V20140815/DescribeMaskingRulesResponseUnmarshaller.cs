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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeMaskingRulesResponseUnmarshaller
    {
        public static DescribeMaskingRulesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMaskingRulesResponse describeMaskingRulesResponse = new DescribeMaskingRulesResponse();

			describeMaskingRulesResponse.HttpResponse = _ctx.HttpResponse;
			describeMaskingRulesResponse.RequestId = _ctx.StringValue("DescribeMaskingRules.RequestId");

			DescribeMaskingRulesResponse.DescribeMaskingRules_Data data = new DescribeMaskingRulesResponse.DescribeMaskingRules_Data();

			List<DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo> data_rules = new List<DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo>();
			for (int i = 0; i < _ctx.Length("DescribeMaskingRules.Data.Rules.Length"); i++) {
				DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo encDBInfo = new DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo();
				encDBInfo.RuleName = _ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].RuleName");
				encDBInfo.Enabled = _ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].Enabled");
				encDBInfo.DefaultAlgo = _ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].DefaultAlgo");
				encDBInfo.MaskingAlgo = _ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].MaskingAlgo");

				DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo.DescribeMaskingRules_RuleConfig ruleConfig = new DescribeMaskingRulesResponse.DescribeMaskingRules_Data.DescribeMaskingRules_EncDBInfo.DescribeMaskingRules_RuleConfig();

				List<string> ruleConfig_databases = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Databases.Length"); j++) {
					ruleConfig_databases.Add(_ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Databases["+ j +"]"));
				}
				ruleConfig.Databases = ruleConfig_databases;

				List<string> ruleConfig_tables = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Tables.Length"); j++) {
					ruleConfig_tables.Add(_ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Tables["+ j +"]"));
				}
				ruleConfig.Tables = ruleConfig_tables;

				List<string> ruleConfig_columns = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Columns.Length"); j++) {
					ruleConfig_columns.Add(_ctx.StringValue("DescribeMaskingRules.Data.Rules["+ i +"].RuleConfig.Columns["+ j +"]"));
				}
				ruleConfig.Columns = ruleConfig_columns;
				encDBInfo.RuleConfig = ruleConfig;

				data_rules.Add(encDBInfo);
			}
			data.Rules = data_rules;
			describeMaskingRulesResponse.Data = data;
        
			return describeMaskingRulesResponse;
        }
    }
}
