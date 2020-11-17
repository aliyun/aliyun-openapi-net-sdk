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
    public class ListAvailableEsInstanceIdsResponseUnmarshaller
    {
        public static ListAvailableEsInstanceIdsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAvailableEsInstanceIdsResponse listAvailableEsInstanceIdsResponse = new ListAvailableEsInstanceIdsResponse();

			listAvailableEsInstanceIdsResponse.HttpResponse = _ctx.HttpResponse;
			listAvailableEsInstanceIdsResponse.RequestId = _ctx.StringValue("ListAvailableEsInstanceIds.RequestId");

			List<ListAvailableEsInstanceIdsResponse.ListAvailableEsInstanceIds_ResultItem> listAvailableEsInstanceIdsResponse_result = new List<ListAvailableEsInstanceIdsResponse.ListAvailableEsInstanceIds_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListAvailableEsInstanceIds.Result.Length"); i++) {
				ListAvailableEsInstanceIdsResponse.ListAvailableEsInstanceIds_ResultItem resultItem = new ListAvailableEsInstanceIdsResponse.ListAvailableEsInstanceIds_ResultItem();
				resultItem.EsInstanceId = _ctx.StringValue("ListAvailableEsInstanceIds.Result["+ i +"].esInstanceId");
				resultItem.Endpoint = _ctx.StringValue("ListAvailableEsInstanceIds.Result["+ i +"].endpoint");
				resultItem.Description = _ctx.StringValue("ListAvailableEsInstanceIds.Result["+ i +"].description");
				resultItem.KibanaEndpoint = _ctx.StringValue("ListAvailableEsInstanceIds.Result["+ i +"].kibanaEndpoint");

				listAvailableEsInstanceIdsResponse_result.Add(resultItem);
			}
			listAvailableEsInstanceIdsResponse.Result = listAvailableEsInstanceIdsResponse_result;
        
			return listAvailableEsInstanceIdsResponse;
        }
    }
}
