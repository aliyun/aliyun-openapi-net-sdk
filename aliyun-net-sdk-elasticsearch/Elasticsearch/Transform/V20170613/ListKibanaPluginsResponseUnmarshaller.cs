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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListKibanaPluginsResponseUnmarshaller
    {
        public static ListKibanaPluginsResponse Unmarshall(UnmarshallerContext context)
        {
			ListKibanaPluginsResponse listKibanaPluginsResponse = new ListKibanaPluginsResponse();

			listKibanaPluginsResponse.HttpResponse = context.HttpResponse;
			listKibanaPluginsResponse.RequestId = context.StringValue("ListKibanaPlugins.RequestId");

			ListKibanaPluginsResponse.ListKibanaPlugins_Headers headers = new ListKibanaPluginsResponse.ListKibanaPlugins_Headers();
			headers.XTotalCount = context.IntegerValue("ListKibanaPlugins.Headers.X-Total-Count");
			listKibanaPluginsResponse.Headers = headers;

			List<ListKibanaPluginsResponse.ListKibanaPlugins_PluginItem> listKibanaPluginsResponse_result = new List<ListKibanaPluginsResponse.ListKibanaPlugins_PluginItem>();
			for (int i = 0; i < context.Length("ListKibanaPlugins.Result.Length"); i++) {
				ListKibanaPluginsResponse.ListKibanaPlugins_PluginItem pluginItem = new ListKibanaPluginsResponse.ListKibanaPlugins_PluginItem();
				pluginItem.Name = context.StringValue("ListKibanaPlugins.Result["+ i +"].name");
				pluginItem.State = context.StringValue("ListKibanaPlugins.Result["+ i +"].state");
				pluginItem.Source = context.StringValue("ListKibanaPlugins.Result["+ i +"].source");
				pluginItem.Description = context.StringValue("ListKibanaPlugins.Result["+ i +"].description");
				pluginItem.SpecificationUrl = context.StringValue("ListKibanaPlugins.Result["+ i +"].specificationUrl");

				listKibanaPluginsResponse_result.Add(pluginItem);
			}
			listKibanaPluginsResponse.Result = listKibanaPluginsResponse_result;
        
			return listKibanaPluginsResponse;
        }
    }
}
