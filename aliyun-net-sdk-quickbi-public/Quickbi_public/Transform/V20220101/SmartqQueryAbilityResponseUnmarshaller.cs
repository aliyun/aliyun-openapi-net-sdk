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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class SmartqQueryAbilityResponseUnmarshaller
    {
        public static SmartqQueryAbilityResponse Unmarshall(UnmarshallerContext _ctx)
        {
			SmartqQueryAbilityResponse smartqQueryAbilityResponse = new SmartqQueryAbilityResponse();

			smartqQueryAbilityResponse.HttpResponse = _ctx.HttpResponse;
			smartqQueryAbilityResponse.RequestId = _ctx.StringValue("SmartqQueryAbility.RequestId");
			smartqQueryAbilityResponse.Success = _ctx.BooleanValue("SmartqQueryAbility.Success");

			SmartqQueryAbilityResponse.SmartqQueryAbility_Result result = new SmartqQueryAbilityResponse.SmartqQueryAbility_Result();
			result.ChartType = _ctx.StringValue("SmartqQueryAbility.Result.ChartType");
			result.LogicSql = _ctx.StringValue("SmartqQueryAbility.Result.LogicSql");
			result.ConclusionText = _ctx.StringValue("SmartqQueryAbility.Result.ConclusionText");

			List<SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_MetaTypeItem> result_metaType = new List<SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_MetaTypeItem>();
			for (int i = 0; i < _ctx.Length("SmartqQueryAbility.Result.MetaType.Length"); i++) {
				SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_MetaTypeItem metaTypeItem = new SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_MetaTypeItem();
				metaTypeItem.Key = _ctx.StringValue("SmartqQueryAbility.Result.MetaType["+ i +"].Key");
				metaTypeItem._Value = _ctx.StringValue("SmartqQueryAbility.Result.MetaType["+ i +"].Value");
				metaTypeItem.Type = _ctx.StringValue("SmartqQueryAbility.Result.MetaType["+ i +"].Type");

				result_metaType.Add(metaTypeItem);
			}
			result.MetaType = result_metaType;

			List<SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_ValuesItem> result_values = new List<SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_ValuesItem>();
			for (int i = 0; i < _ctx.Length("SmartqQueryAbility.Result.Values.Length"); i++) {
				SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_ValuesItem valuesItem = new SmartqQueryAbilityResponse.SmartqQueryAbility_Result.SmartqQueryAbility_ValuesItem();

				List<string> valuesItem_row = new List<string>();
				for (int j = 0; j < _ctx.Length("SmartqQueryAbility.Result.Values["+ i +"].Row.Length"); j++) {
					valuesItem_row.Add(_ctx.StringValue("SmartqQueryAbility.Result.Values["+ i +"].Row["+ j +"]"));
				}
				valuesItem.Row = valuesItem_row;

				result_values.Add(valuesItem);
			}
			result.Values = result_values;
			smartqQueryAbilityResponse.Result = result;
        
			return smartqQueryAbilityResponse;
        }
    }
}
