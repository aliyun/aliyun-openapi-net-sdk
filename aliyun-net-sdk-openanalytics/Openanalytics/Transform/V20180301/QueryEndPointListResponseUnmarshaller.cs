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
using Aliyun.Acs.openanalytics.Model.V20180301;

namespace Aliyun.Acs.openanalytics.Transform.V20180301
{
    public class QueryEndPointListResponseUnmarshaller
    {
        public static QueryEndPointListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEndPointListResponse queryEndPointListResponse = new QueryEndPointListResponse();

			queryEndPointListResponse.HttpResponse = context.HttpResponse;
			queryEndPointListResponse.RequestId = context.StringValue("QueryEndPointList.RequestId");
			queryEndPointListResponse.RegionId = context.StringValue("QueryEndPointList.RegionId");

			List<QueryEndPointListResponse.QueryEndPointList_EndPointListItem> queryEndPointListResponse_endPointList = new List<QueryEndPointListResponse.QueryEndPointList_EndPointListItem>();
			for (int i = 0; i < context.Length("QueryEndPointList.EndPointList.Length"); i++) {
				QueryEndPointListResponse.QueryEndPointList_EndPointListItem endPointListItem = new QueryEndPointListResponse.QueryEndPointList_EndPointListItem();
				endPointListItem.EndPointID = context.StringValue("QueryEndPointList.EndPointList["+ i +"].EndPointID");
				endPointListItem.Zone = context.StringValue("QueryEndPointList.EndPointList["+ i +"].Zone");
				endPointListItem.VSwitch = context.StringValue("QueryEndPointList.EndPointList["+ i +"].VSwitch");
				endPointListItem.Status = context.StringValue("QueryEndPointList.EndPointList["+ i +"].Status");
				endPointListItem.VpcID = context.StringValue("QueryEndPointList.EndPointList["+ i +"].VpcID");
				endPointListItem.Host = context.StringValue("QueryEndPointList.EndPointList["+ i +"].Host");
				endPointListItem.DomainURL = context.StringValue("QueryEndPointList.EndPointList["+ i +"].DomainURL");
				endPointListItem.NetworkType = context.StringValue("QueryEndPointList.EndPointList["+ i +"].NetworkType");
				endPointListItem.AllowIP = context.StringValue("QueryEndPointList.EndPointList["+ i +"].AllowIP");
				endPointListItem.Port = context.StringValue("QueryEndPointList.EndPointList["+ i +"].Port");
				endPointListItem.CloudInstanceID = context.StringValue("QueryEndPointList.EndPointList["+ i +"].CloudInstanceID");

				queryEndPointListResponse_endPointList.Add(endPointListItem);
			}
			queryEndPointListResponse.EndPointList = queryEndPointListResponse_endPointList;
        
			return queryEndPointListResponse;
        }
    }
}
