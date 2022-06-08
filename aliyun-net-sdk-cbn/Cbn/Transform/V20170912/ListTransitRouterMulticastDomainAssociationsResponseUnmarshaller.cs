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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListTransitRouterMulticastDomainAssociationsResponseUnmarshaller
    {
        public static ListTransitRouterMulticastDomainAssociationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterMulticastDomainAssociationsResponse listTransitRouterMulticastDomainAssociationsResponse = new ListTransitRouterMulticastDomainAssociationsResponse();

			listTransitRouterMulticastDomainAssociationsResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterMulticastDomainAssociationsResponse.RequestId = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.RequestId");
			listTransitRouterMulticastDomainAssociationsResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterMulticastDomainAssociations.TotalCount");
			listTransitRouterMulticastDomainAssociationsResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterMulticastDomainAssociations.MaxResults");
			listTransitRouterMulticastDomainAssociationsResponse.NextToken = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.NextToken");

			List<ListTransitRouterMulticastDomainAssociationsResponse.ListTransitRouterMulticastDomainAssociations_TransitRouterMulticastAssociation> listTransitRouterMulticastDomainAssociationsResponse_transitRouterMulticastAssociations = new List<ListTransitRouterMulticastDomainAssociationsResponse.ListTransitRouterMulticastDomainAssociations_TransitRouterMulticastAssociation>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations.Length"); i++) {
				ListTransitRouterMulticastDomainAssociationsResponse.ListTransitRouterMulticastDomainAssociations_TransitRouterMulticastAssociation transitRouterMulticastAssociation = new ListTransitRouterMulticastDomainAssociationsResponse.ListTransitRouterMulticastDomainAssociations_TransitRouterMulticastAssociation();
				transitRouterMulticastAssociation.TransitRouterMulticastDomainId = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].TransitRouterMulticastDomainId");
				transitRouterMulticastAssociation.TransitRouterAttachmentId = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].TransitRouterAttachmentId");
				transitRouterMulticastAssociation.VSwitchId = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].VSwitchId");
				transitRouterMulticastAssociation.Status = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].Status");
				transitRouterMulticastAssociation.ResourceType = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].ResourceType");
				transitRouterMulticastAssociation.ResourceOwnerId = _ctx.LongValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].ResourceOwnerId");
				transitRouterMulticastAssociation.ResourceId = _ctx.StringValue("ListTransitRouterMulticastDomainAssociations.TransitRouterMulticastAssociations["+ i +"].ResourceId");

				listTransitRouterMulticastDomainAssociationsResponse_transitRouterMulticastAssociations.Add(transitRouterMulticastAssociation);
			}
			listTransitRouterMulticastDomainAssociationsResponse.TransitRouterMulticastAssociations = listTransitRouterMulticastDomainAssociationsResponse_transitRouterMulticastAssociations;
        
			return listTransitRouterMulticastDomainAssociationsResponse;
        }
    }
}
