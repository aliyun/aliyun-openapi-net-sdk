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
    public class DescribePluginsByApiResponseUnmarshaller
    {
        public static DescribePluginsByApiResponse Unmarshall(UnmarshallerContext context)
        {
			DescribePluginsByApiResponse describePluginsByApiResponse = new DescribePluginsByApiResponse();

			describePluginsByApiResponse.HttpResponse = context.HttpResponse;
			describePluginsByApiResponse.RequestId = context.StringValue("DescribePluginsByApi.RequestId");
			describePluginsByApiResponse.TotalCount = context.IntegerValue("DescribePluginsByApi.TotalCount");
			describePluginsByApiResponse.PageSize = context.IntegerValue("DescribePluginsByApi.PageSize");
			describePluginsByApiResponse.PageNumber = context.IntegerValue("DescribePluginsByApi.PageNumber");

			List<DescribePluginsByApiResponse.DescribePluginsByApi_PluginAttribute> describePluginsByApiResponse_plugins = new List<DescribePluginsByApiResponse.DescribePluginsByApi_PluginAttribute>();
			for (int i = 0; i < context.Length("DescribePluginsByApi.Plugins.Length"); i++) {
				DescribePluginsByApiResponse.DescribePluginsByApi_PluginAttribute pluginAttribute = new DescribePluginsByApiResponse.DescribePluginsByApi_PluginAttribute();
				pluginAttribute.PluginId = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].PluginId");
				pluginAttribute.PluginType = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].PluginType");
				pluginAttribute.PluginName = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].PluginName");
				pluginAttribute.PluginData = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].PluginData");
				pluginAttribute.RegionId = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].RegionId");
				pluginAttribute.Description = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].Description");
				pluginAttribute.CreatedTime = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].CreatedTime");
				pluginAttribute.ModifiedTime = context.StringValue("DescribePluginsByApi.Plugins["+ i +"].ModifiedTime");

				describePluginsByApiResponse_plugins.Add(pluginAttribute);
			}
			describePluginsByApiResponse.Plugins = describePluginsByApiResponse_plugins;
        
			return describePluginsByApiResponse;
        }
    }
}