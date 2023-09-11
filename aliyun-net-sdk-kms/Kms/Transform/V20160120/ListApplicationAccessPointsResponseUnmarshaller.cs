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
using Aliyun.Acs.Kms.Model.V20160120;

namespace Aliyun.Acs.Kms.Transform.V20160120
{
    public class ListApplicationAccessPointsResponseUnmarshaller
    {
        public static ListApplicationAccessPointsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApplicationAccessPointsResponse listApplicationAccessPointsResponse = new ListApplicationAccessPointsResponse();

			listApplicationAccessPointsResponse.HttpResponse = _ctx.HttpResponse;
			listApplicationAccessPointsResponse.RequestId = _ctx.StringValue("ListApplicationAccessPoints.RequestId");
			listApplicationAccessPointsResponse.PageNumber = _ctx.IntegerValue("ListApplicationAccessPoints.PageNumber");
			listApplicationAccessPointsResponse.PageSize = _ctx.IntegerValue("ListApplicationAccessPoints.PageSize");
			listApplicationAccessPointsResponse.TotalCount = _ctx.IntegerValue("ListApplicationAccessPoints.TotalCount");

			List<ListApplicationAccessPointsResponse.ListApplicationAccessPoints_ApplicationAccessPoint> listApplicationAccessPointsResponse_applicationAccessPoints = new List<ListApplicationAccessPointsResponse.ListApplicationAccessPoints_ApplicationAccessPoint>();
			for (int i = 0; i < _ctx.Length("ListApplicationAccessPoints.ApplicationAccessPoints.Length"); i++) {
				ListApplicationAccessPointsResponse.ListApplicationAccessPoints_ApplicationAccessPoint applicationAccessPoint = new ListApplicationAccessPointsResponse.ListApplicationAccessPoints_ApplicationAccessPoint();
				applicationAccessPoint.Name = _ctx.StringValue("ListApplicationAccessPoints.ApplicationAccessPoints["+ i +"].Name");
				applicationAccessPoint.AuthenticationMethod = _ctx.StringValue("ListApplicationAccessPoints.ApplicationAccessPoints["+ i +"].AuthenticationMethod");

				listApplicationAccessPointsResponse_applicationAccessPoints.Add(applicationAccessPoint);
			}
			listApplicationAccessPointsResponse.ApplicationAccessPoints = listApplicationAccessPointsResponse_applicationAccessPoints;
        
			return listApplicationAccessPointsResponse;
        }
    }
}
