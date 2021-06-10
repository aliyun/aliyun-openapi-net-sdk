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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class ListDhcpOptionsSetsResponseUnmarshaller
    {
        public static ListDhcpOptionsSetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDhcpOptionsSetsResponse listDhcpOptionsSetsResponse = new ListDhcpOptionsSetsResponse();

			listDhcpOptionsSetsResponse.HttpResponse = _ctx.HttpResponse;
			listDhcpOptionsSetsResponse.RequestId = _ctx.StringValue("ListDhcpOptionsSets.RequestId");
			listDhcpOptionsSetsResponse.NextToken = _ctx.StringValue("ListDhcpOptionsSets.NextToken");

			List<ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet> listDhcpOptionsSetsResponse_dhcpOptionsSets = new List<ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet>();
			for (int i = 0; i < _ctx.Length("ListDhcpOptionsSets.DhcpOptionsSets.Length"); i++) {
				ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet dhcpOptionsSet = new ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet();
				dhcpOptionsSet.DhcpOptionsSetName = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].DhcpOptionsSetName");
				dhcpOptionsSet.DhcpOptionsSetDescription = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].DhcpOptionsSetDescription");
				dhcpOptionsSet.OwnerId = _ctx.LongValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].OwnerId");
				dhcpOptionsSet.Status = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].Status");
				dhcpOptionsSet.DhcpOptionsSetId = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].DhcpOptionsSetId");
				dhcpOptionsSet.AssociateVpcCount = _ctx.IntegerValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].AssociateVpcCount");

				ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet.ListDhcpOptionsSets_DhcpOptions dhcpOptions = new ListDhcpOptionsSetsResponse.ListDhcpOptionsSets_DhcpOptionsSet.ListDhcpOptionsSets_DhcpOptions();
				dhcpOptions.DomainNameServers = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].DhcpOptions.DomainNameServers");
				dhcpOptions.DomainName = _ctx.StringValue("ListDhcpOptionsSets.DhcpOptionsSets["+ i +"].DhcpOptions.DomainName");
				dhcpOptionsSet.DhcpOptions = dhcpOptions;

				listDhcpOptionsSetsResponse_dhcpOptionsSets.Add(dhcpOptionsSet);
			}
			listDhcpOptionsSetsResponse.DhcpOptionsSets = listDhcpOptionsSetsResponse_dhcpOptionsSets;
        
			return listDhcpOptionsSetsResponse;
        }
    }
}
