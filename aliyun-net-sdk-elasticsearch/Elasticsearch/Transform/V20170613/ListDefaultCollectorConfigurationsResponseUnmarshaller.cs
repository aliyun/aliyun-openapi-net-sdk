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
    public class ListDefaultCollectorConfigurationsResponseUnmarshaller
    {
        public static ListDefaultCollectorConfigurationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDefaultCollectorConfigurationsResponse listDefaultCollectorConfigurationsResponse = new ListDefaultCollectorConfigurationsResponse();

			listDefaultCollectorConfigurationsResponse.HttpResponse = _ctx.HttpResponse;
			listDefaultCollectorConfigurationsResponse.RequestId = _ctx.StringValue("ListDefaultCollectorConfigurations.RequestId");

			List<ListDefaultCollectorConfigurationsResponse.ListDefaultCollectorConfigurations_ResultItem> listDefaultCollectorConfigurationsResponse_result = new List<ListDefaultCollectorConfigurationsResponse.ListDefaultCollectorConfigurations_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListDefaultCollectorConfigurations.Result.Length"); i++) {
				ListDefaultCollectorConfigurationsResponse.ListDefaultCollectorConfigurations_ResultItem resultItem = new ListDefaultCollectorConfigurationsResponse.ListDefaultCollectorConfigurations_ResultItem();
				resultItem.FileName = _ctx.StringValue("ListDefaultCollectorConfigurations.Result["+ i +"].fileName");
				resultItem.Content = _ctx.StringValue("ListDefaultCollectorConfigurations.Result["+ i +"].content");

				listDefaultCollectorConfigurationsResponse_result.Add(resultItem);
			}
			listDefaultCollectorConfigurationsResponse.Result = listDefaultCollectorConfigurationsResponse_result;
        
			return listDefaultCollectorConfigurationsResponse;
        }
    }
}
