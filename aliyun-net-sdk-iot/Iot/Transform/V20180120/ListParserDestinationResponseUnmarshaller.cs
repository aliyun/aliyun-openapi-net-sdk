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
    public class ListParserDestinationResponseUnmarshaller
    {
        public static ListParserDestinationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListParserDestinationResponse listParserDestinationResponse = new ListParserDestinationResponse();

			listParserDestinationResponse.HttpResponse = _ctx.HttpResponse;
			listParserDestinationResponse.RequestId = _ctx.StringValue("ListParserDestination.RequestId");
			listParserDestinationResponse.Success = _ctx.BooleanValue("ListParserDestination.Success");
			listParserDestinationResponse.Code = _ctx.StringValue("ListParserDestination.Code");
			listParserDestinationResponse.ErrorMessage = _ctx.StringValue("ListParserDestination.ErrorMessage");

			List<ListParserDestinationResponse.ListParserDestination_Destinations> listParserDestinationResponse_data = new List<ListParserDestinationResponse.ListParserDestination_Destinations>();
			for (int i = 0; i < _ctx.Length("ListParserDestination.Data.Length"); i++) {
				ListParserDestinationResponse.ListParserDestination_Destinations destinations = new ListParserDestinationResponse.ListParserDestination_Destinations();
				destinations.DestinationId = _ctx.LongValue("ListParserDestination.Data["+ i +"].DestinationId");
				destinations.Name = _ctx.StringValue("ListParserDestination.Data["+ i +"].Name");
				destinations.Type = _ctx.StringValue("ListParserDestination.Data["+ i +"].Type");
				destinations.Configuration = _ctx.StringValue("ListParserDestination.Data["+ i +"].Configuration");
				destinations.IsFailover = _ctx.BooleanValue("ListParserDestination.Data["+ i +"].IsFailover");
				destinations.UtcCreated = _ctx.StringValue("ListParserDestination.Data["+ i +"].UtcCreated");
				destinations.UtcModified = _ctx.StringValue("ListParserDestination.Data["+ i +"].UtcModified");

				listParserDestinationResponse_data.Add(destinations);
			}
			listParserDestinationResponse.Data = listParserDestinationResponse_data;
        
			return listParserDestinationResponse;
        }
    }
}
