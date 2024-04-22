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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class ListIngressesResponseUnmarshaller
    {
        public static ListIngressesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListIngressesResponse listIngressesResponse = new ListIngressesResponse();

			listIngressesResponse.HttpResponse = _ctx.HttpResponse;
			listIngressesResponse.RequestId = _ctx.StringValue("ListIngresses.RequestId");
			listIngressesResponse.Message = _ctx.StringValue("ListIngresses.Message");
			listIngressesResponse.TraceId = _ctx.StringValue("ListIngresses.TraceId");
			listIngressesResponse.ErrorCode = _ctx.StringValue("ListIngresses.ErrorCode");
			listIngressesResponse.Code = _ctx.StringValue("ListIngresses.Code");
			listIngressesResponse.Success = _ctx.BooleanValue("ListIngresses.Success");

			ListIngressesResponse.ListIngresses_Data data = new ListIngressesResponse.ListIngresses_Data();

			List<ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress> data_ingressList = new List<ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress>();
			for (int i = 0; i < _ctx.Length("ListIngresses.Data.IngressList.Length"); i++) {
				ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress ingress = new ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress();
				ingress.SlbId = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].SlbId");
				ingress.NamespaceId = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].NamespaceId");
				ingress.Description = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].Description");
				ingress.ListenerPort = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].ListenerPort");
				ingress.SlbType = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].SlbType");
				ingress.CertId = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].CertId");
				ingress.CertIds = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].CertIds");
				ingress.Name = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].Name");
				ingress.Id = _ctx.LongValue("ListIngresses.Data.IngressList["+ i +"].Id");
				ingress.LoadBalanceType = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].LoadBalanceType");
				ingress.ListenerProtocol = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].ListenerProtocol");
				ingress.MseGatewayId = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].MseGatewayId");
				ingress.MseGatewayPort = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].MseGatewayPort");
				ingress.MseGatewayProtocol = _ctx.StringValue("ListIngresses.Data.IngressList["+ i +"].MseGatewayProtocol");

				data_ingressList.Add(ingress);
			}
			data.IngressList = data_ingressList;
			listIngressesResponse.Data = data;
        
			return listIngressesResponse;
        }
    }
}
