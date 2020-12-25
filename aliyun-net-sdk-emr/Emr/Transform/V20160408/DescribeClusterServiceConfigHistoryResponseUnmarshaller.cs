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
    public class DescribeClusterServiceConfigHistoryResponseUnmarshaller
    {
        public static DescribeClusterServiceConfigHistoryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterServiceConfigHistoryResponse describeClusterServiceConfigHistoryResponse = new DescribeClusterServiceConfigHistoryResponse();

			describeClusterServiceConfigHistoryResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterServiceConfigHistoryResponse.RequestId = _ctx.StringValue("DescribeClusterServiceConfigHistory.RequestId");

			DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config config = new DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config();
			config.ServiceName = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ServiceName");
			config.ConfigVersion = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigVersion");
			config.Applied = _ctx.BooleanValue("DescribeClusterServiceConfigHistory.Config.Applied");
			config.CreateTime = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.CreateTime");
			config.Author = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.Author");
			config.Comment = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.Comment");

			List<DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue> config_configValueList = new List<DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue>();
			for (int i = 0; i < _ctx.Length("DescribeClusterServiceConfigHistory.Config.ConfigValueList.Length"); i++) {
				DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue configValue = new DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue();
				configValue.ConfigName = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigName");

				List<DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue.DescribeClusterServiceConfigHistory_ConfigItemValue> configValue_configItemValueList = new List<DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue.DescribeClusterServiceConfigHistory_ConfigItemValue>();
				for (int j = 0; j < _ctx.Length("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigItemValueList.Length"); j++) {
					DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue.DescribeClusterServiceConfigHistory_ConfigItemValue configItemValue = new DescribeClusterServiceConfigHistoryResponse.DescribeClusterServiceConfigHistory_Config.DescribeClusterServiceConfigHistory_ConfigValue.DescribeClusterServiceConfigHistory_ConfigItemValue();
					configItemValue.ItemName = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].ItemName");
					configItemValue._Value = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].Value");
					configItemValue.OldValue = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].OldValue");
					configItemValue.ChangeType = _ctx.StringValue("DescribeClusterServiceConfigHistory.Config.ConfigValueList["+ i +"].ConfigItemValueList["+ j +"].ChangeType");

					configValue_configItemValueList.Add(configItemValue);
				}
				configValue.ConfigItemValueList = configValue_configItemValueList;

				config_configValueList.Add(configValue);
			}
			config.ConfigValueList = config_configValueList;
			describeClusterServiceConfigHistoryResponse.Config = config;
        
			return describeClusterServiceConfigHistoryResponse;
        }
    }
}
