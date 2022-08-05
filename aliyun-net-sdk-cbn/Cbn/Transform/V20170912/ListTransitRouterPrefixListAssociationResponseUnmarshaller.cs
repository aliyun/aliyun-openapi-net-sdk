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
    public class ListTransitRouterPrefixListAssociationResponseUnmarshaller
    {
        public static ListTransitRouterPrefixListAssociationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterPrefixListAssociationResponse listTransitRouterPrefixListAssociationResponse = new ListTransitRouterPrefixListAssociationResponse();

			listTransitRouterPrefixListAssociationResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterPrefixListAssociationResponse.RequestId = _ctx.StringValue("ListTransitRouterPrefixListAssociation.RequestId");
			listTransitRouterPrefixListAssociationResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterPrefixListAssociation.TotalCount");
			listTransitRouterPrefixListAssociationResponse.PageSize = _ctx.IntegerValue("ListTransitRouterPrefixListAssociation.PageSize");
			listTransitRouterPrefixListAssociationResponse.PageNumber = _ctx.IntegerValue("ListTransitRouterPrefixListAssociation.PageNumber");

			List<ListTransitRouterPrefixListAssociationResponse.ListTransitRouterPrefixListAssociation_PrefixList> listTransitRouterPrefixListAssociationResponse_prefixLists = new List<ListTransitRouterPrefixListAssociationResponse.ListTransitRouterPrefixListAssociation_PrefixList>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterPrefixListAssociation.PrefixLists.Length"); i++) {
				ListTransitRouterPrefixListAssociationResponse.ListTransitRouterPrefixListAssociation_PrefixList prefixList = new ListTransitRouterPrefixListAssociationResponse.ListTransitRouterPrefixListAssociation_PrefixList();
				prefixList.PrefixListId = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].PrefixListId");
				prefixList.OwnerUid = _ctx.LongValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].OwnerUid");
				prefixList.Status = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].Status");
				prefixList.NextHop = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].NextHop");
				prefixList.NextHopInstanceId = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].NextHopInstanceId");
				prefixList.NextHopType = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].NextHopType");
				prefixList.TransitRouterTableId = _ctx.StringValue("ListTransitRouterPrefixListAssociation.PrefixLists["+ i +"].TransitRouterTableId");

				listTransitRouterPrefixListAssociationResponse_prefixLists.Add(prefixList);
			}
			listTransitRouterPrefixListAssociationResponse.PrefixLists = listTransitRouterPrefixListAssociationResponse_prefixLists;
        
			return listTransitRouterPrefixListAssociationResponse;
        }
    }
}
