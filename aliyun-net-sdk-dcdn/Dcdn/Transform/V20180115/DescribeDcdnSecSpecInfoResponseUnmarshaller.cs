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
using Aliyun.Acs.dcdn.Model.V20180115;

namespace Aliyun.Acs.dcdn.Transform.V20180115
{
    public class DescribeDcdnSecSpecInfoResponseUnmarshaller
    {
        public static DescribeDcdnSecSpecInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDcdnSecSpecInfoResponse describeDcdnSecSpecInfoResponse = new DescribeDcdnSecSpecInfoResponse();

			describeDcdnSecSpecInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeDcdnSecSpecInfoResponse.RequestId = _ctx.StringValue("DescribeDcdnSecSpecInfo.RequestId");
			describeDcdnSecSpecInfoResponse.Version = _ctx.StringValue("DescribeDcdnSecSpecInfo.Version");

			List<DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem> describeDcdnSecSpecInfoResponse_specInfos = new List<DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem>();
			for (int i = 0; i < _ctx.Length("DescribeDcdnSecSpecInfo.SpecInfos.Length"); i++) {
				DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem ruleInfoItem = new DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem();
				ruleInfoItem.RuleCode = _ctx.StringValue("DescribeDcdnSecSpecInfo.SpecInfos["+ i +"].RuleCode");

				List<DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem.DescribeDcdnSecSpecInfo_ConfigItem> ruleInfoItem_ruleConfigs = new List<DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem.DescribeDcdnSecSpecInfo_ConfigItem>();
				for (int j = 0; j < _ctx.Length("DescribeDcdnSecSpecInfo.SpecInfos["+ i +"].RuleConfigs.Length"); j++) {
					DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem.DescribeDcdnSecSpecInfo_ConfigItem configItem = new DescribeDcdnSecSpecInfoResponse.DescribeDcdnSecSpecInfo_RuleInfoItem.DescribeDcdnSecSpecInfo_ConfigItem();
					configItem.Code = _ctx.StringValue("DescribeDcdnSecSpecInfo.SpecInfos["+ i +"].RuleConfigs["+ j +"].Code");
					configItem.Expr = _ctx.StringValue("DescribeDcdnSecSpecInfo.SpecInfos["+ i +"].RuleConfigs["+ j +"].Expr");
					configItem._Value = _ctx.StringValue("DescribeDcdnSecSpecInfo.SpecInfos["+ i +"].RuleConfigs["+ j +"].Value");

					ruleInfoItem_ruleConfigs.Add(configItem);
				}
				ruleInfoItem.RuleConfigs = ruleInfoItem_ruleConfigs;

				describeDcdnSecSpecInfoResponse_specInfos.Add(ruleInfoItem);
			}
			describeDcdnSecSpecInfoResponse.SpecInfos = describeDcdnSecSpecInfoResponse_specInfos;
        
			return describeDcdnSecSpecInfoResponse;
        }
    }
}
