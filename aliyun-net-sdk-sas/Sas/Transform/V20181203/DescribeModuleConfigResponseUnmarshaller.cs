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
    public class DescribeModuleConfigResponseUnmarshaller
    {
        public static DescribeModuleConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeModuleConfigResponse describeModuleConfigResponse = new DescribeModuleConfigResponse();

			describeModuleConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeModuleConfigResponse.RequestId = _ctx.StringValue("DescribeModuleConfig.RequestId");
			describeModuleConfigResponse.Success = _ctx.BooleanValue("DescribeModuleConfig.Success");
			describeModuleConfigResponse.Count = _ctx.IntegerValue("DescribeModuleConfig.Count");
			describeModuleConfigResponse.HttpStatusCode = _ctx.IntegerValue("DescribeModuleConfig.HttpStatusCode");

			List<DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig> describeModuleConfigResponse_moduleConfigList = new List<DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig>();
			for (int i = 0; i < _ctx.Length("DescribeModuleConfig.ModuleConfigList.Length"); i++) {
				DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig moduleConfig = new DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig();
				moduleConfig.ConfigName = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].ConfigName");
				moduleConfig.ModuleName = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].ModuleName");

				List<DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig.DescribeModuleConfig_Item> moduleConfig_items = new List<DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig.DescribeModuleConfig_Item>();
				for (int j = 0; j < _ctx.Length("DescribeModuleConfig.ModuleConfigList["+ i +"].Items.Length"); j++) {
					DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig.DescribeModuleConfig_Item item = new DescribeModuleConfigResponse.DescribeModuleConfig_ModuleConfig.DescribeModuleConfig_Item();
					item.InstanceId = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].InstanceId");
					item.InstanceName = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].InstanceName");
					item.GroupId = _ctx.IntegerValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].GroupId");
					item.Ip = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].Ip");
					item.Region = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].Region");
					item.Uuid = _ctx.StringValue("DescribeModuleConfig.ModuleConfigList["+ i +"].Items["+ j +"].Uuid");

					moduleConfig_items.Add(item);
				}
				moduleConfig.Items = moduleConfig_items;

				describeModuleConfigResponse_moduleConfigList.Add(moduleConfig);
			}
			describeModuleConfigResponse.ModuleConfigList = describeModuleConfigResponse_moduleConfigList;
        
			return describeModuleConfigResponse;
        }
    }
}
