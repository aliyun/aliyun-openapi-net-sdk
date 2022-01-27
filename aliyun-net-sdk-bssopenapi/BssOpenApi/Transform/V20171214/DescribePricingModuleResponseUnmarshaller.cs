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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class DescribePricingModuleResponseUnmarshaller
    {
        public static DescribePricingModuleResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePricingModuleResponse describePricingModuleResponse = new DescribePricingModuleResponse();

			describePricingModuleResponse.HttpResponse = _ctx.HttpResponse;
			describePricingModuleResponse.RequestId = _ctx.StringValue("DescribePricingModule.RequestId");
			describePricingModuleResponse.Success = _ctx.BooleanValue("DescribePricingModule.Success");
			describePricingModuleResponse.Code = _ctx.StringValue("DescribePricingModule.Code");
			describePricingModuleResponse.Message = _ctx.StringValue("DescribePricingModule.Message");

			DescribePricingModuleResponse.DescribePricingModule_Data data = new DescribePricingModuleResponse.DescribePricingModule_Data();

			List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Module> data_moduleList = new List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Module>();
			for (int i = 0; i < _ctx.Length("DescribePricingModule.Data.ModuleList.Length"); i++) {
				DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Module module = new DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Module();
				module.ModuleCode = _ctx.StringValue("DescribePricingModule.Data.ModuleList["+ i +"].ModuleCode");
				module.ModuleName = _ctx.StringValue("DescribePricingModule.Data.ModuleList["+ i +"].ModuleName");
				module.PriceType = _ctx.StringValue("DescribePricingModule.Data.ModuleList["+ i +"].PriceType");
				module.Currency = _ctx.StringValue("DescribePricingModule.Data.ModuleList["+ i +"].Currency");

				List<string> module_configList = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribePricingModule.Data.ModuleList["+ i +"].ConfigList.Length"); j++) {
					module_configList.Add(_ctx.StringValue("DescribePricingModule.Data.ModuleList["+ i +"].ConfigList["+ j +"]"));
				}
				module.ConfigList = module_configList;

				data_moduleList.Add(module);
			}
			data.ModuleList = data_moduleList;

			List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute> data_attributeList = new List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute>();
			for (int i = 0; i < _ctx.Length("DescribePricingModule.Data.AttributeList.Length"); i++) {
				DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute attribute = new DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute();
				attribute.Code = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Code");
				attribute.Name = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Name");
				attribute.Unit = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Unit");

				List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute.DescribePricingModule_AttributeValue> attribute_values = new List<DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute.DescribePricingModule_AttributeValue>();
				for (int j = 0; j < _ctx.Length("DescribePricingModule.Data.AttributeList["+ i +"].Values.Length"); j++) {
					DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute.DescribePricingModule_AttributeValue attributeValue = new DescribePricingModuleResponse.DescribePricingModule_Data.DescribePricingModule_Attribute.DescribePricingModule_AttributeValue();
					attributeValue.Type = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Values["+ j +"].Type");
					attributeValue.Name = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Values["+ j +"].Name");
					attributeValue._Value = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Values["+ j +"].Value");
					attributeValue.Remark = _ctx.StringValue("DescribePricingModule.Data.AttributeList["+ i +"].Values["+ j +"].Remark");

					attribute_values.Add(attributeValue);
				}
				attribute.Values = attribute_values;

				data_attributeList.Add(attribute);
			}
			data.AttributeList = data_attributeList;
			describePricingModuleResponse.Data = data;
        
			return describePricingModuleResponse;
        }
    }
}
