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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class ListUnrecognizedIntentsResponseUnmarshaller
    {
        public static ListUnrecognizedIntentsResponse Unmarshall(UnmarshallerContext context)
        {
			ListUnrecognizedIntentsResponse listUnrecognizedIntentsResponse = new ListUnrecognizedIntentsResponse();

			listUnrecognizedIntentsResponse.HttpResponse = context.HttpResponse;
			listUnrecognizedIntentsResponse.RequestId = context.StringValue("ListUnrecognizedIntents.RequestId");
			listUnrecognizedIntentsResponse.Success = context.BooleanValue("ListUnrecognizedIntents.Success");
			listUnrecognizedIntentsResponse.Code = context.StringValue("ListUnrecognizedIntents.Code");
			listUnrecognizedIntentsResponse.Message = context.StringValue("ListUnrecognizedIntents.Message");
			listUnrecognizedIntentsResponse.HttpStatusCode = context.IntegerValue("ListUnrecognizedIntents.HttpStatusCode");

			ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents unrecognizedIntents = new ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents();
			unrecognizedIntents.TotalCount = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.TotalCount");
			unrecognizedIntents.PageNumber = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.PageNumber");
			unrecognizedIntents.PageSize = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.PageSize");

			List<ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents.ListUnrecognizedIntents_UnrecognizedIntent> unrecognizedIntents_list = new List<ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents.ListUnrecognizedIntents_UnrecognizedIntent>();
			for (int i = 0; i < context.Length("ListUnrecognizedIntents.UnrecognizedIntents.List.Length"); i++) {
				ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents.ListUnrecognizedIntents_UnrecognizedIntent unrecognizedIntent = new ListUnrecognizedIntentsResponse.ListUnrecognizedIntents_UnrecognizedIntents.ListUnrecognizedIntents_UnrecognizedIntent();
				unrecognizedIntent.Question = context.StringValue("ListUnrecognizedIntents.UnrecognizedIntents.List["+ i +"].Question");
				unrecognizedIntent.NodeId = context.StringValue("ListUnrecognizedIntents.UnrecognizedIntents.List["+ i +"].NodeId");
				unrecognizedIntent.TotalCount = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.List["+ i +"].TotalCount");
				unrecognizedIntent.UnrecognizedCount = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.List["+ i +"].UnrecognizedCount");
				unrecognizedIntent.UnrecognizedPercentage = context.IntegerValue("ListUnrecognizedIntents.UnrecognizedIntents.List["+ i +"].UnrecognizedPercentage");

				unrecognizedIntents_list.Add(unrecognizedIntent);
			}
			unrecognizedIntents.List = unrecognizedIntents_list;
			listUnrecognizedIntentsResponse.UnrecognizedIntents = unrecognizedIntents;
        
			return listUnrecognizedIntentsResponse;
        }
    }
}
