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
    public class ListLogstashPluginsResponseUnmarshaller
    {
        public static ListLogstashPluginsResponse Unmarshall(UnmarshallerContext context)
        {
			ListLogstashPluginsResponse listLogstashPluginsResponse = new ListLogstashPluginsResponse();

			listLogstashPluginsResponse.HttpResponse = context.HttpResponse;
			listLogstashPluginsResponse.RequestId = context.StringValue("ListLogstashPlugins.RequestId");

			List<ListLogstashPluginsResponse.ListLogstashPlugins_ResultItem> listLogstashPluginsResponse_result = new List<ListLogstashPluginsResponse.ListLogstashPlugins_ResultItem>();
			for (int i = 0; i < context.Length("ListLogstashPlugins.Result.Length"); i++) {
				ListLogstashPluginsResponse.ListLogstashPlugins_ResultItem resultItem = new ListLogstashPluginsResponse.ListLogstashPlugins_ResultItem();
				resultItem.Name = context.StringValue("ListLogstashPlugins.Result["+ i +"].name");
				resultItem.State = context.StringValue("ListLogstashPlugins.Result["+ i +"].state");
				resultItem.Source = context.StringValue("ListLogstashPlugins.Result["+ i +"].source");
				resultItem.Description = context.StringValue("ListLogstashPlugins.Result["+ i +"].description");

				listLogstashPluginsResponse_result.Add(resultItem);
			}
			listLogstashPluginsResponse.Result = listLogstashPluginsResponse_result;
        
			return listLogstashPluginsResponse;
        }
    }
}
