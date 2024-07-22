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
    public class ListVpcEndpointsResponseUnmarshaller
    {
        public static ListVpcEndpointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListVpcEndpointsResponse listVpcEndpointsResponse = new ListVpcEndpointsResponse();

			listVpcEndpointsResponse.HttpResponse = _ctx.HttpResponse;
			listVpcEndpointsResponse.RequestId = _ctx.StringValue("ListVpcEndpoints.RequestId");

			List<ListVpcEndpointsResponse.ListVpcEndpoints_ResultItem> listVpcEndpointsResponse_result = new List<ListVpcEndpointsResponse.ListVpcEndpoints_ResultItem>();
			for (int i = 0; i < _ctx.Length("ListVpcEndpoints.Result.Length"); i++) {
				ListVpcEndpointsResponse.ListVpcEndpoints_ResultItem resultItem = new ListVpcEndpointsResponse.ListVpcEndpoints_ResultItem();
				resultItem.EndpointBusinessStatus = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].endpointBusinessStatus");
				resultItem.ServiceId = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].serviceId");
				resultItem.EndpointName = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].endpointName");
				resultItem.EndpointId = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].endpointId");
				resultItem.ServiceName = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].serviceName");
				resultItem.CreateTime = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].createTime");
				resultItem.ConnectionStatus = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].connectionStatus");
				resultItem.EndpointDomain = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].endpointDomain");
				resultItem.EndpointStatus = _ctx.StringValue("ListVpcEndpoints.Result["+ i +"].endpointStatus");

				listVpcEndpointsResponse_result.Add(resultItem);
			}
			listVpcEndpointsResponse.Result = listVpcEndpointsResponse_result;
        
			return listVpcEndpointsResponse;
        }
    }
}
