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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CloudAPI.Model.V20160714;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CloudAPI.Transform.V20160714
{
    public class DescribePluginsResponseUnmarshaller
    {
        public static DescribePluginsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePluginsResponse describePluginsResponse = new DescribePluginsResponse();

			describePluginsResponse.HttpResponse = context.HttpResponse;
			describePluginsResponse.RequestId = context.StringValue("DescribePlugins.RequestId");
			describePluginsResponse.TotalCount = context.IntegerValue("DescribePlugins.TotalCount");
			describePluginsResponse.PageSize = context.IntegerValue("DescribePlugins.PageSize");
			describePluginsResponse.PageNumber = context.IntegerValue("DescribePlugins.PageNumber");

			List<DescribePluginsResponse.DescribePlugins_PluginAttribute> describePluginsResponse_plugins = new List<DescribePluginsResponse.DescribePlugins_PluginAttribute>();
			for (int i = 0; i < context.Length("DescribePlugins.Plugins.Length"); i++) {
				DescribePluginsResponse.DescribePlugins_PluginAttribute pluginAttribute = new DescribePluginsResponse.DescribePlugins_PluginAttribute();
				pluginAttribute.PluginId = context.StringValue("DescribePlugins.Plugins["+ i +"].PluginId");
				pluginAttribute.PluginType = context.StringValue("DescribePlugins.Plugins["+ i +"].PluginType");
				pluginAttribute.PluginName = context.StringValue("DescribePlugins.Plugins["+ i +"].PluginName");
				pluginAttribute.PluginData = context.StringValue("DescribePlugins.Plugins["+ i +"].PluginData");
				pluginAttribute.RegionId = context.IntegerValue("DescribePlugins.Plugins["+ i +"].RegionId");
				pluginAttribute.Description = context.IntegerValue("DescribePlugins.Plugins["+ i +"].Description");
				pluginAttribute.CreatedTime = context.StringValue("DescribePlugins.Plugins["+ i +"].CreatedTime");
				pluginAttribute.ModifiedTime = context.StringValue("DescribePlugins.Plugins["+ i +"].ModifiedTime");

				describePluginsResponse_plugins.Add(pluginAttribute);
			}
			describePluginsResponse.Plugins = describePluginsResponse_plugins;
        
			return describePluginsResponse;
        }
    }
}