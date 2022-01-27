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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListConfigCentersResponseUnmarshaller
    {
        public static ListConfigCentersResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListConfigCentersResponse listConfigCentersResponse = new ListConfigCentersResponse();

			listConfigCentersResponse.HttpResponse = _ctx.HttpResponse;
			listConfigCentersResponse.Code = _ctx.IntegerValue("ListConfigCenters.Code");
			listConfigCentersResponse.Message = _ctx.StringValue("ListConfigCenters.Message");
			listConfigCentersResponse.RequestId = _ctx.StringValue("ListConfigCenters.RequestId");

			List<ListConfigCentersResponse.ListConfigCenters_ListConfigCenters> listConfigCentersResponse_configCentersList = new List<ListConfigCentersResponse.ListConfigCenters_ListConfigCenters>();
			for (int i = 0; i < _ctx.Length("ListConfigCenters.ConfigCentersList.Length"); i++) {
				ListConfigCentersResponse.ListConfigCenters_ListConfigCenters listConfigCenters = new ListConfigCentersResponse.ListConfigCenters_ListConfigCenters();
				listConfigCenters.AppName = _ctx.StringValue("ListConfigCenters.ConfigCentersList["+ i +"].AppName");
				listConfigCenters.DataId = _ctx.StringValue("ListConfigCenters.ConfigCentersList["+ i +"].DataId");
				listConfigCenters.Group = _ctx.StringValue("ListConfigCenters.ConfigCentersList["+ i +"].Group");
				listConfigCenters.Id = _ctx.StringValue("ListConfigCenters.ConfigCentersList["+ i +"].Id");

				listConfigCentersResponse_configCentersList.Add(listConfigCenters);
			}
			listConfigCentersResponse.ConfigCentersList = listConfigCentersResponse_configCentersList;
        
			return listConfigCentersResponse;
        }
    }
}
