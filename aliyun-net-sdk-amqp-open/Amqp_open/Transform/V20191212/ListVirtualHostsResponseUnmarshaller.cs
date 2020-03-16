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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class ListVirtualHostsResponseUnmarshaller
    {
        public static ListVirtualHostsResponse Unmarshall(UnmarshallerContext context)
        {
			ListVirtualHostsResponse listVirtualHostsResponse = new ListVirtualHostsResponse();

			listVirtualHostsResponse.HttpResponse = context.HttpResponse;
			listVirtualHostsResponse.RequestId = context.StringValue("ListVirtualHosts.RequestId");

			ListVirtualHostsResponse.ListVirtualHosts_Data data = new ListVirtualHostsResponse.ListVirtualHosts_Data();
			data.NextToken = context.StringValue("ListVirtualHosts.Data.NextToken");
			data.MaxResults = context.IntegerValue("ListVirtualHosts.Data.MaxResults");

			List<ListVirtualHostsResponse.ListVirtualHosts_Data.ListVirtualHosts_VhostVO> data_virtualHosts = new List<ListVirtualHostsResponse.ListVirtualHosts_Data.ListVirtualHosts_VhostVO>();
			for (int i = 0; i < context.Length("ListVirtualHosts.Data.VirtualHosts.Length"); i++) {
				ListVirtualHostsResponse.ListVirtualHosts_Data.ListVirtualHosts_VhostVO vhostVO = new ListVirtualHostsResponse.ListVirtualHosts_Data.ListVirtualHosts_VhostVO();
				vhostVO.Name = context.StringValue("ListVirtualHosts.Data.VirtualHosts["+ i +"].Name");

				data_virtualHosts.Add(vhostVO);
			}
			data.VirtualHosts = data_virtualHosts;
			listVirtualHostsResponse.Data = data;
        
			return listVirtualHostsResponse;
        }
    }
}
