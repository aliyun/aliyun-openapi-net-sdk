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
    public class ListPluginsResponseUnmarshaller
    {
        public static ListPluginsResponse Unmarshall(UnmarshallerContext context)
        {
			ListPluginsResponse listPluginsResponse = new ListPluginsResponse();

			listPluginsResponse.HttpResponse = context.HttpResponse;
			listPluginsResponse.RequestId = context.StringValue("ListPlugins.RequestId");

			ListPluginsResponse.ListPlugins_Headers headers = new ListPluginsResponse.ListPlugins_Headers();
			headers.XTotalCount = context.IntegerValue("ListPlugins.Headers.XTotalCount");
			listPluginsResponse.Headers = headers;

			List<ListPluginsResponse.ListPlugins_ResultItem> listPluginsResponse_result = new List<ListPluginsResponse.ListPlugins_ResultItem>();
			for (int i = 0; i < context.Length("ListPlugins.Result.Length"); i++) {
				ListPluginsResponse.ListPlugins_ResultItem resultItem = new ListPluginsResponse.ListPlugins_ResultItem();
				resultItem.Name = context.StringValue("ListPlugins.Result["+ i +"].Name");
				resultItem.State = context.StringValue("ListPlugins.Result["+ i +"].State");
				resultItem.Source = context.StringValue("ListPlugins.Result["+ i +"].Source");
				resultItem.Description = context.StringValue("ListPlugins.Result["+ i +"].Description");

				listPluginsResponse_result.Add(resultItem);
			}
			listPluginsResponse.Result = listPluginsResponse_result;
        
			return listPluginsResponse;
        }
    }
}
