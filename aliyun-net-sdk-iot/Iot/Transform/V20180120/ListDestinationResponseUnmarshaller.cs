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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class ListDestinationResponseUnmarshaller
    {
        public static ListDestinationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListDestinationResponse listDestinationResponse = new ListDestinationResponse();

			listDestinationResponse.HttpResponse = _ctx.HttpResponse;
			listDestinationResponse.RequestId = _ctx.StringValue("ListDestination.RequestId");
			listDestinationResponse.Success = _ctx.BooleanValue("ListDestination.Success");
			listDestinationResponse.Code = _ctx.StringValue("ListDestination.Code");
			listDestinationResponse.ErrorMessage = _ctx.StringValue("ListDestination.ErrorMessage");
			listDestinationResponse.Page = _ctx.IntegerValue("ListDestination.Page");
			listDestinationResponse.PageSize = _ctx.IntegerValue("ListDestination.PageSize");
			listDestinationResponse.Total = _ctx.IntegerValue("ListDestination.Total");

			List<ListDestinationResponse.ListDestination_DestinationsItem> listDestinationResponse_destinations = new List<ListDestinationResponse.ListDestination_DestinationsItem>();
			for (int i = 0; i < _ctx.Length("ListDestination.Destinations.Length"); i++) {
				ListDestinationResponse.ListDestination_DestinationsItem destinationsItem = new ListDestinationResponse.ListDestination_DestinationsItem();
				destinationsItem.DestinationId = _ctx.LongValue("ListDestination.Destinations["+ i +"].DestinationId");
				destinationsItem.Name = _ctx.StringValue("ListDestination.Destinations["+ i +"].Name");
				destinationsItem.Type = _ctx.StringValue("ListDestination.Destinations["+ i +"].Type");
				destinationsItem.Configuration = _ctx.StringValue("ListDestination.Destinations["+ i +"].Configuration");
				destinationsItem.IsFailover = _ctx.BooleanValue("ListDestination.Destinations["+ i +"].IsFailover");
				destinationsItem.UtcCreated = _ctx.StringValue("ListDestination.Destinations["+ i +"].UtcCreated");
				destinationsItem.Description = _ctx.StringValue("ListDestination.Destinations["+ i +"].Description");

				listDestinationResponse_destinations.Add(destinationsItem);
			}
			listDestinationResponse.Destinations = listDestinationResponse_destinations;
        
			return listDestinationResponse;
        }
    }
}
