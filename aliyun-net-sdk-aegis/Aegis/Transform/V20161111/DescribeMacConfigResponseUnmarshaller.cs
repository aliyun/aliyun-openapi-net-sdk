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
using Aliyun.Acs.aegis.Model.V20161111;

namespace Aliyun.Acs.aegis.Transform.V20161111
{
    public class DescribeMacConfigResponseUnmarshaller
    {
        public static DescribeMacConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMacConfigResponse describeMacConfigResponse = new DescribeMacConfigResponse();

			describeMacConfigResponse.HttpResponse = context.HttpResponse;
			describeMacConfigResponse.RequestId = context.StringValue("DescribeMacConfig.RequestId");
			describeMacConfigResponse.Count = context.IntegerValue("DescribeMacConfig.Count");
			describeMacConfigResponse.PageSize = context.IntegerValue("DescribeMacConfig.PageSize");
			describeMacConfigResponse.CurrentPage = context.IntegerValue("DescribeMacConfig.CurrentPage");
			describeMacConfigResponse.TotalCount = context.IntegerValue("DescribeMacConfig.TotalCount");

			List<DescribeMacConfigResponse.DescribeMacConfig_Config> describeMacConfigResponse_configs = new List<DescribeMacConfigResponse.DescribeMacConfig_Config>();
			for (int i = 0; i < context.Length("DescribeMacConfig.Configs.Length"); i++) {
				DescribeMacConfigResponse.DescribeMacConfig_Config config = new DescribeMacConfigResponse.DescribeMacConfig_Config();
				config.StartTime = context.StringValue("DescribeMacConfig.Configs["+ i +"].StartTime");
				config.EndTime = context.StringValue("DescribeMacConfig.Configs["+ i +"].EndTime");
				config.Ip = context.StringValue("DescribeMacConfig.Configs["+ i +"].Ip");
				config.StrategyId = context.LongValue("DescribeMacConfig.Configs["+ i +"].StrategyId");
				config.Account = context.StringValue("DescribeMacConfig.Configs["+ i +"].Account");
				config.Location = context.StringValue("DescribeMacConfig.Configs["+ i +"].Location");
				config.Switcher = context.StringValue("DescribeMacConfig.Configs["+ i +"].Switcher");
				config.VulType = context.StringValue("DescribeMacConfig.Configs["+ i +"].VulType");
				config.UuidCount = context.IntegerValue("DescribeMacConfig.Configs["+ i +"].UuidCount");
				config.TotalCount = context.IntegerValue("DescribeMacConfig.Configs["+ i +"].TotalCount");

				List<DescribeMacConfigResponse.DescribeMacConfig_Config.DescribeMacConfig_Target> config_targetList = new List<DescribeMacConfigResponse.DescribeMacConfig_Config.DescribeMacConfig_Target>();
				for (int j = 0; j < context.Length("DescribeMacConfig.Configs["+ i +"].TargetList.Length"); j++) {
					DescribeMacConfigResponse.DescribeMacConfig_Config.DescribeMacConfig_Target target = new DescribeMacConfigResponse.DescribeMacConfig_Config.DescribeMacConfig_Target();
					target.Flag = context.StringValue("DescribeMacConfig.Configs["+ i +"].TargetList["+ j +"].Flag");
					target.TargetType = context.StringValue("DescribeMacConfig.Configs["+ i +"].TargetList["+ j +"].TargetType");
					target.Target = context.StringValue("DescribeMacConfig.Configs["+ i +"].TargetList["+ j +"].Target");

					config_targetList.Add(target);
				}
				config.TargetList = config_targetList;

				describeMacConfigResponse_configs.Add(config);
			}
			describeMacConfigResponse.Configs = describeMacConfigResponse_configs;
        
			return describeMacConfigResponse;
        }
    }
}
