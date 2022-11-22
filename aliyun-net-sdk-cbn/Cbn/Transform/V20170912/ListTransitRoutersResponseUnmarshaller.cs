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
    public class ListTransitRoutersResponseUnmarshaller
    {
        public static ListTransitRoutersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRoutersResponse listTransitRoutersResponse = new ListTransitRoutersResponse();

			listTransitRoutersResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRoutersResponse.PageSize = _ctx.IntegerValue("ListTransitRouters.PageSize");
			listTransitRoutersResponse.RequestId = _ctx.StringValue("ListTransitRouters.RequestId");
			listTransitRoutersResponse.PageNumber = _ctx.IntegerValue("ListTransitRouters.PageNumber");
			listTransitRoutersResponse.TotalCount = _ctx.IntegerValue("ListTransitRouters.TotalCount");

			List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter> listTransitRoutersResponse_transitRouters = new List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter>();
			for (int i = 0; i < _ctx.Length("ListTransitRouters.TransitRouters.Length"); i++) {
				ListTransitRoutersResponse.ListTransitRouters_TransitRouter transitRouter = new ListTransitRoutersResponse.ListTransitRouters_TransitRouter();
				transitRouter.CreationTime = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].CreationTime");
				transitRouter.Type = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Type");
				transitRouter.Status = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Status");
				transitRouter.TransitRouterId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterId");
				transitRouter.TransitRouterDescription = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterDescription");
				transitRouter.TransitRouterName = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterName");
				transitRouter.CenId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].CenId");
				transitRouter.AliUid = _ctx.LongValue("ListTransitRouters.TransitRouters["+ i +"].AliUid");
				transitRouter.RegionId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].RegionId");
				transitRouter.ServiceMode = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].ServiceMode");
				transitRouter.SupportMulticast = _ctx.BooleanValue("ListTransitRouters.TransitRouters["+ i +"].SupportMulticast");

				List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_TransitRouterCidrListItem> transitRouter_transitRouterCidrList = new List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_TransitRouterCidrListItem>();
				for (int j = 0; j < _ctx.Length("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList.Length"); j++) {
					ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_TransitRouterCidrListItem transitRouterCidrListItem = new ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_TransitRouterCidrListItem();
					transitRouterCidrListItem.Cidr = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList["+ j +"].Cidr");
					transitRouterCidrListItem.Name = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList["+ j +"].Name");
					transitRouterCidrListItem.Description = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList["+ j +"].Description");
					transitRouterCidrListItem.TransitRouterCidrId = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList["+ j +"].TransitRouterCidrId");
					transitRouterCidrListItem.PublishCidrRoute = _ctx.BooleanValue("ListTransitRouters.TransitRouters["+ i +"].TransitRouterCidrList["+ j +"].PublishCidrRoute");

					transitRouter_transitRouterCidrList.Add(transitRouterCidrListItem);
				}
				transitRouter.TransitRouterCidrList = transitRouter_transitRouterCidrList;

				List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_Tag> transitRouter_tags = new List<ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_Tag>();
				for (int j = 0; j < _ctx.Length("ListTransitRouters.TransitRouters["+ i +"].Tags.Length"); j++) {
					ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_Tag tag = new ListTransitRoutersResponse.ListTransitRouters_TransitRouter.ListTransitRouters_Tag();
					tag.Key = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("ListTransitRouters.TransitRouters["+ i +"].Tags["+ j +"].Value");

					transitRouter_tags.Add(tag);
				}
				transitRouter.Tags = transitRouter_tags;

				listTransitRoutersResponse_transitRouters.Add(transitRouter);
			}
			listTransitRoutersResponse.TransitRouters = listTransitRoutersResponse_transitRouters;
        
			return listTransitRoutersResponse;
        }
    }
}
