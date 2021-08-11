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
    public class ListTransitRouterRouteTablesResponseUnmarshaller
    {
        public static ListTransitRouterRouteTablesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterRouteTablesResponse listTransitRouterRouteTablesResponse = new ListTransitRouterRouteTablesResponse();

			listTransitRouterRouteTablesResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterRouteTablesResponse.RequestId = _ctx.StringValue("ListTransitRouterRouteTables.RequestId");
			listTransitRouterRouteTablesResponse.TotalCount = _ctx.IntegerValue("ListTransitRouterRouteTables.TotalCount");
			listTransitRouterRouteTablesResponse.MaxResults = _ctx.IntegerValue("ListTransitRouterRouteTables.MaxResults");
			listTransitRouterRouteTablesResponse.NextToken = _ctx.StringValue("ListTransitRouterRouteTables.NextToken");

			List<ListTransitRouterRouteTablesResponse.ListTransitRouterRouteTables_TransitRouterRouteTable> listTransitRouterRouteTablesResponse_transitRouterRouteTables = new List<ListTransitRouterRouteTablesResponse.ListTransitRouterRouteTables_TransitRouterRouteTable>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterRouteTables.TransitRouterRouteTables.Length"); i++) {
				ListTransitRouterRouteTablesResponse.ListTransitRouterRouteTables_TransitRouterRouteTable transitRouterRouteTable = new ListTransitRouterRouteTablesResponse.ListTransitRouterRouteTables_TransitRouterRouteTable();
				transitRouterRouteTable.TransitRouterRouteTableStatus = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].TransitRouterRouteTableStatus");
				transitRouterRouteTable.TransitRouterRouteTableName = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].TransitRouterRouteTableName");
				transitRouterRouteTable.TransitRouterRouteTableId = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].TransitRouterRouteTableId");
				transitRouterRouteTable.TransitRouterRouteTableDescription = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].TransitRouterRouteTableDescription");
				transitRouterRouteTable.TransitRouterRouteTableType = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].TransitRouterRouteTableType");
				transitRouterRouteTable.CreateTime = _ctx.StringValue("ListTransitRouterRouteTables.TransitRouterRouteTables["+ i +"].CreateTime");

				listTransitRouterRouteTablesResponse_transitRouterRouteTables.Add(transitRouterRouteTable);
			}
			listTransitRouterRouteTablesResponse.TransitRouterRouteTables = listTransitRouterRouteTablesResponse_transitRouterRouteTables;
        
			return listTransitRouterRouteTablesResponse;
        }
    }
}
