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
        public static DescribeClusterServiceConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeClusterServiceConfigResponse describeClusterServiceConfigResponse = new DescribeClusterServiceConfigResponse();

			describeClusterServiceConfigResponse.HttpResponse = context.HttpResponse;
			describeClusterServiceConfigResponse.RequestId = context.StringValue("DescribeClusterServiceConfig.RequestId");

			DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config config = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config();
			config.ServiceName = context.StringValue("DescribeClusterServiceConfig.Config.ServiceName");
			config.ConfigVersion = context.StringValue("DescribeClusterServiceConfig.Config.ConfigVersion");
			config.Applied = context.StringValue("DescribeClusterServiceConfig.Config.Applied");
			config.CreateTime = context.StringValue("DescribeClusterServiceConfig.Config.CreateTime");
			config.Author = context.StringValue("DescribeClusterServiceConfig.Config.Author");
			config.Comment = context.StringValue("DescribeClusterServiceConfig.Config.Comment");

			List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue> config_configValueList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue>();
			for (int i = 0; i < context.Length("DescribeClusterServiceConfig.Config.ConfigValueList.Length"); i++) {
				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue configValue = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue();
				configValue.ConfigName = context.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigName");
				configValue.AllowCustom = context.BooleanValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].AllowCustom");

				List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue> configValue_configItemValueList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue>();
				for (int j = 0; j < context.Length("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList.Length"); j++) {
					DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue configItemValue = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_ConfigValue.DescribeClusterServiceConfig_ConfigItemValue();
					configItemValue.ItemName = context.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].ItemName");
					configItemValue._Value = context.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].Value");
					configItemValue.IsCustom = context.BooleanValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].IsCustom");
					configItemValue.Description = context.StringValue("DescribeClusterServiceConfig.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].Description");

					configValue_configItemValueList.Add(configItemValue);
				}
				configValue.ConfigItemValueList = configValue_configItemValueList;

				config_configValueList.Add(configValue);
			}
			config.ConfigValueList = config_configValueList;

			List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo> config_propertyInfoList = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo>();
			for (int i = 0; i < context.Length("DescribeClusterServiceConfig.Config.PropertyInfoList.Length"); i++) {
				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo propertyInfo = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo();
				propertyInfo.Name = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Name");
				propertyInfo._Value = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Value");
				propertyInfo.Description = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Description");
				propertyInfo.FileName = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].FileName");
				propertyInfo.DisplayName = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].DisplayName");
				propertyInfo.ServiceName = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].ServiceName");
				propertyInfo.Component = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].Component");

				List<string> propertyInfo_propertyTypes = new List<string>();
				for (int j = 0; j < context.Length("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyTypes.Length"); j++) {
					propertyInfo_propertyTypes.Add(context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyTypes["+ j +"]"));
				}
				propertyInfo.PropertyTypes = propertyInfo_propertyTypes;

				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes propertyValueAttributes = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes();
				propertyValueAttributes.Type = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Type");
				propertyValueAttributes.Maximum = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Maximum");
				propertyValueAttributes.Mimimum = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Mimimum");
				propertyValueAttributes.Unit = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Unit");
				propertyValueAttributes._ReadOnly = context.BooleanValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.ReadOnly");
				propertyValueAttributes.Hidden = context.BooleanValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Hidden");
				propertyValueAttributes.IncrememtStep = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.IncrememtStep");

				List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo> propertyValueAttributes_entries = new List<DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo>();
				for (int j = 0; j < context.Length("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries.Length"); j++) {
					DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo valueEntryInfo = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_PropertyValueAttributes.DescribeClusterServiceConfig_ValueEntryInfo();
					valueEntryInfo._Value = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Value");
					valueEntryInfo.Label = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Label");
					valueEntryInfo.Description = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].PropertyValueAttributes.Entries["+ j +"].Description");

					propertyValueAttributes_entries.Add(valueEntryInfo);
				}
				propertyValueAttributes.Entries = propertyValueAttributes_entries;
				propertyInfo.PropertyValueAttributes = propertyValueAttributes;

				DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_EffectWay effectWay = new DescribeClusterServiceConfigResponse.DescribeClusterServiceConfig_Config.DescribeClusterServiceConfig_PropertyInfo.DescribeClusterServiceConfig_EffectWay();
				effectWay.EffectType = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].EffectWay.EffectType");
				effectWay.InvokeServiceName = context.StringValue("DescribeClusterServiceConfig.Config.PropertyInfoList["+ i +"].EffectWay.InvokeServiceName");
				propertyInfo.EffectWay = effectWay;

				config_propertyInfoList.Add(propertyInfo);
			}
			config.PropertyInfoList = config_propertyInfoList;
			describeClusterServiceConfigResponse.Config = config;
        
			return describeClusterServiceConfigResponse;
        }
    }
}
