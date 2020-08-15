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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class ListPersonTraceResponseUnmarshaller
    {
        public static ListPersonTraceResponse Unmarshall(UnmarshallerContext context)
        {
			ListPersonTraceResponse listPersonTraceResponse = new ListPersonTraceResponse();

			listPersonTraceResponse.HttpResponse = context.HttpResponse;
			listPersonTraceResponse.Code = context.StringValue("ListPersonTrace.Code");
			listPersonTraceResponse.Message = context.StringValue("ListPersonTrace.Message");
			listPersonTraceResponse.RequestId = context.StringValue("ListPersonTrace.RequestId");
			listPersonTraceResponse.Success = context.StringValue("ListPersonTrace.Success");
			listPersonTraceResponse.TotalCount = context.IntegerValue("ListPersonTrace.TotalCount");
			listPersonTraceResponse.PageSize = context.IntegerValue("ListPersonTrace.PageSize");
			listPersonTraceResponse.PageNumber = context.IntegerValue("ListPersonTrace.PageNumber");

			List<ListPersonTraceResponse.ListPersonTrace_Day> listPersonTraceResponse_data = new List<ListPersonTraceResponse.ListPersonTrace_Day>();
			for (int i = 0; i < context.Length("ListPersonTrace.Data.Length"); i++) {
				ListPersonTraceResponse.ListPersonTrace_Day day = new ListPersonTraceResponse.ListPersonTrace_Day();
				day.Date = context.StringValue("ListPersonTrace.Data["+ i +"].Date");
				day.LastTime = context.StringValue("ListPersonTrace.Data["+ i +"].LastTime");
				day.StartTime = context.StringValue("ListPersonTrace.Data["+ i +"].StartTime");
				day.EndSourceImage = context.StringValue("ListPersonTrace.Data["+ i +"].EndSourceImage");
				day.DeviceId = context.StringValue("ListPersonTrace.Data["+ i +"].DeviceId");
				day.StartTargetImage = context.StringValue("ListPersonTrace.Data["+ i +"].StartTargetImage");
				day.GroupId = context.StringValue("ListPersonTrace.Data["+ i +"].GroupId");
				day.PersonId = context.StringValue("ListPersonTrace.Data["+ i +"].PersonId");
				day.StartSourceImage = context.StringValue("ListPersonTrace.Data["+ i +"].StartSourceImage");
				day.CorpId = context.StringValue("ListPersonTrace.Data["+ i +"].CorpId");
				day.EndTargetImage = context.StringValue("ListPersonTrace.Data["+ i +"].EndTargetImage");

				listPersonTraceResponse_data.Add(day);
			}
			listPersonTraceResponse.Data = listPersonTraceResponse_data;
        
			return listPersonTraceResponse;
        }
    }
}
