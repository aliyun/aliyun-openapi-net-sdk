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
        public static ListIngressesResponse Unmarshall(UnmarshallerContext context)
        {
			ListIngressesResponse listIngressesResponse = new ListIngressesResponse();

			listIngressesResponse.HttpResponse = context.HttpResponse;
			listIngressesResponse.RequestId = context.StringValue("ListIngresses.RequestId");
			listIngressesResponse.Code = context.StringValue("ListIngresses.Code");
			listIngressesResponse.Message = context.StringValue("ListIngresses.Message");
			listIngressesResponse.Success = context.BooleanValue("ListIngresses.Success");
			listIngressesResponse.ErrorCode = context.StringValue("ListIngresses.ErrorCode");
			listIngressesResponse.TraceId = context.StringValue("ListIngresses.TraceId");

			ListIngressesResponse.ListIngresses_Data data = new ListIngressesResponse.ListIngresses_Data();

			List<ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress> data_ingressList = new List<ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress>();
			for (int i = 0; i < context.Length("ListIngresses.Data.IngressList.Length"); i++) {
				ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress ingress = new ListIngressesResponse.ListIngresses_Data.ListIngresses_Ingress();
				ingress.Id = context.LongValue("ListIngresses.Data.IngressList["+ i +"].Id");
				ingress.Name = context.StringValue("ListIngresses.Data.IngressList["+ i +"].Name");
				ingress.NamespaceId = context.StringValue("ListIngresses.Data.IngressList["+ i +"].NamespaceId");
				ingress.SlbId = context.StringValue("ListIngresses.Data.IngressList["+ i +"].SlbId");
				ingress.ListenerPort = context.StringValue("ListIngresses.Data.IngressList["+ i +"].ListenerPort");
				ingress.CertId = context.StringValue("ListIngresses.Data.IngressList["+ i +"].CertId");
				ingress.Description = context.StringValue("ListIngresses.Data.IngressList["+ i +"].Description");
				ingress.SlbType = context.StringValue("ListIngresses.Data.IngressList["+ i +"].SlbType");

				data_ingressList.Add(ingress);
			}
			data.IngressList = data_ingressList;
			listIngressesResponse.Data = data;
        
			return listIngressesResponse;
        }
    }
}
