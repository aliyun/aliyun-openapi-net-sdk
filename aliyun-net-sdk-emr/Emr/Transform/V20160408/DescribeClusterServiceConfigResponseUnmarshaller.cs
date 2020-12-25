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
using Aliyun.Acs.Emr.Model.V20160408;

namespace Aliyun.Acs.Emr.Transform.V20160408
{
    public class DescribeClusterServiceConfigResponseUnmarshaller
    {
        public static DescribeClusterServiceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterServiceConfigResponse describeClusterServiceConfigResponse = new DescribeClusterServiceConfigResponse();

			describeClusterServiceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterServiceConfigResponse.RequestId = _ctx.StringValue("DescribeClusterServiceConfig.RequestId");

			DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config config = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config();
			config.ServiceName = _ctx.StringValue("DescribeClusterServiceConfig.Config.ServiceName");
			config.ConfigVersion = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigVersion");
			config.Applied = _ctx.StringValue("DescribeClusterServiceConfig.Config.Applied");
			config.CreateTime = _ctx.StringValue("DescribeClusterServiceConfig.Config.CreateTime");
			config.Author = _ctx.StringValue("DescribeClusterServiceConfig.Config.Author");
			config.Comment = _ctx.StringValue("DescribeClusterServiceConfig.Config.Comment");

			List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue> config_configValueList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue>();
			for (int i = 0; i < _ctx.Length("DescribeClusterServiceConfig.Config.ConfigValueList.Length"); i++) {
				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue configValue = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue();
				configValue.ConfigName = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigName");
				configValue.AllowCustom = _ctx.BooleanValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].AllowCustom");
				configValue.Scope = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].Scope");
				configValue.ScopeId = _ctx.LongValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ScopeId");

				List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue> configValue_configItemValueList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue>();
				for (int j = 0; j < _ctx.Length("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList.Length"); j++) {
					DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue configItemValue = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue();
					configItemValue.ItemName = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].ItemName");
					configItemValue._Value = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].Value");
					configItemValue.IsCustom = _ctx.BooleanValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].IsCustom");
					configItemValue.Description = _ctx.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].Description");

					configValue_configItemValueList.Add(configItemValue);
				}
				configValue.ConfigItemValueList = configValue_configItemValueList;

				config_configValueList.Add(configValue);
			}
			config.ConfigValueList = config_configValueList;

			List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo> config_propertyInfoList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo>();
			for (int i = 0; i < _ctx.Length("DescribeClusterServiceConfig.Config.PropertyInfoList.Length"); i++) {
				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo propertyInfo = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo();
				propertyInfo.Name = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Name");
				propertyInfo._Value = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Value");
				propertyInfo.Description = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Description");
				propertyInfo.FileName = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].FileName");
				propertyInfo.DisplayName = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].DisplayName");
				propertyInfo.ServiceName = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].ServiceName");
				propertyInfo.Component = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Component");

				List<string> propertyInfo_propertyTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyTypes.Length"); j++) {
					propertyInfo_propertyTypes.Add(_ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyTypes["+ j +"]"));
				}
				propertyInfo.PropertyTypes = propertyInfo_propertyTypes;

				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes propertyValueAttributes = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes();
				propertyValueAttributes.Type = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Type");
				propertyValueAttributes.Maximum = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Maximum");
				propertyValueAttributes.Mimimum = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Mimimum");
				propertyValueAttributes.Unit = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Unit");
				propertyValueAttributes._ReadOnly = _ctx.BooleanValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.ReadOnly");
				propertyValueAttributes.Hidden = _ctx.BooleanValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Hidden");
				propertyValueAttributes.IncrememtStep = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.IncrememtStep");

				List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo> propertyValueAttributes_entries = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo>();
				for (int j = 0; j < _ctx.Length("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries.Length"); j++) {
					DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo valueEntryInfo = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo();
					valueEntryInfo._Value = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Value");
					valueEntryInfo.Label = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Label");
					valueEntryInfo.Description = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Description");

					propertyValueAttributes_entries.Add(valueEntryInfo);
				}
				propertyValueAttributes.Entries = propertyValueAttributes_entries;
				propertyInfo.PropertyValueAttributes = propertyValueAttributes;

				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_EffectWay effectWay = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_EffectWay();
				effectWay.EffectType = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].EffectWay.EffectType");
				effectWay.InvokeServiceName = _ctx.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].EffectWay.InvokeServiceName");
				propertyInfo.EffectWay = effectWay;

				config_propertyInfoList.Add(propertyInfo);
			}
			config.PropertyInfoList = config_propertyInfoList;
			describeClusterServiceConfigResponse.Config = config;
        
			return describeClusterServiceConfigResponse;
        }
    }
}
