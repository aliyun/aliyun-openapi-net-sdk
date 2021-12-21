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
    public class ListTransitRouterAvailableResourceResponseUnmarshaller
    {
        public static ListTransitRouterAvailableResourceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTransitRouterAvailableResourceResponse listTransitRouterAvailableResourceResponse = new ListTransitRouterAvailableResourceResponse();

			listTransitRouterAvailableResourceResponse.HttpResponse = _ctx.HttpResponse;
			listTransitRouterAvailableResourceResponse.RequestId = _ctx.StringValue("ListTransitRouterAvailableResource.RequestId");

			List<string> listTransitRouterAvailableResourceResponse_slaveZones = new List<string>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterAvailableResource.SlaveZones.Length"); i++) {
				listTransitRouterAvailableResourceResponse_slaveZones.Add(_ctx.StringValue("ListTransitRouterAvailableResource.SlaveZones["+ i +"]"));
			}
			listTransitRouterAvailableResourceResponse.SlaveZones = listTransitRouterAvailableResourceResponse_slaveZones;

			List<string> listTransitRouterAvailableResourceResponse_masterZones = new List<string>();
			for (int i = 0; i < _ctx.Length("ListTransitRouterAvailableResource.MasterZones.Length"); i++) {
				listTransitRouterAvailableResourceResponse_masterZones.Add(_ctx.StringValue("ListTransitRouterAvailableResource.MasterZones["+ i +"]"));
			}
			listTransitRouterAvailableResourceResponse.MasterZones = listTransitRouterAvailableResourceResponse_masterZones;
        
			return listTransitRouterAvailableResourceResponse;
        }
    }
}
