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
using Aliyun.Acs.CDRS.Model.V20201101;

namespace Aliyun.Acs.CDRS.Transform.V20201101
{
    public class ListMapRouteDetailsResponseUnmarshaller
    {
        public static ListMapRouteDetailsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListMapRouteDetailsResponse listMapRouteDetailsResponse = new ListMapRouteDetailsResponse();

			listMapRouteDetailsResponse.HttpResponse = _ctx.HttpResponse;
			listMapRouteDetailsResponse.Code = _ctx.StringValue("ListMapRouteDetails.Code");
			listMapRouteDetailsResponse.Message = _ctx.StringValue("ListMapRouteDetails.Message");
			listMapRouteDetailsResponse.PageNumber = _ctx.LongValue("ListMapRouteDetails.PageNumber");
			listMapRouteDetailsResponse.PageSize = _ctx.LongValue("ListMapRouteDetails.PageSize");
			listMapRouteDetailsResponse.RequestId = _ctx.StringValue("ListMapRouteDetails.RequestId");
			listMapRouteDetailsResponse.TotalCount = _ctx.LongValue("ListMapRouteDetails.TotalCount");

			List<ListMapRouteDetailsResponse.ListMapRouteDetails_Datas> listMapRouteDetailsResponse_data = new List<ListMapRouteDetailsResponse.ListMapRouteDetails_Datas>();
			for (int i = 0; i < _ctx.Length("ListMapRouteDetails.Data.Length"); i++) {
				ListMapRouteDetailsResponse.ListMapRouteDetails_Datas datas = new ListMapRouteDetailsResponse.ListMapRouteDetails_Datas();
				datas.Destination = _ctx.StringValue("ListMapRouteDetails.Data["+ i +"].Destination");
				datas.Origin = _ctx.StringValue("ListMapRouteDetails.Data["+ i +"].Origin");
				datas.Route = _ctx.StringValue("ListMapRouteDetails.Data["+ i +"].Route");
				datas.Type = _ctx.StringValue("ListMapRouteDetails.Data["+ i +"].Type");

				listMapRouteDetailsResponse_data.Add(datas);
			}
			listMapRouteDetailsResponse.Data = listMapRouteDetailsResponse_data;
        
			return listMapRouteDetailsResponse;
        }
    }
}
