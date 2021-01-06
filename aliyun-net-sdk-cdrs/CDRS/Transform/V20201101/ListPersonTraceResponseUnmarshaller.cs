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
    public class ListPersonTraceResponseUnmarshaller
    {
        public static ListPersonTraceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListPersonTraceResponse listPersonTraceResponse = new ListPersonTraceResponse();

			listPersonTraceResponse.HttpResponse = _ctx.HttpResponse;
			listPersonTraceResponse.Code = _ctx.StringValue("ListPersonTrace.Code");
			listPersonTraceResponse.Message = _ctx.StringValue("ListPersonTrace.Message");
			listPersonTraceResponse.RequestId = _ctx.StringValue("ListPersonTrace.RequestId");
			listPersonTraceResponse.Success = _ctx.StringValue("ListPersonTrace.Success");
			listPersonTraceResponse.TotalCount = _ctx.IntegerValue("ListPersonTrace.TotalCount");
			listPersonTraceResponse.PageSize = _ctx.IntegerValue("ListPersonTrace.PageSize");
			listPersonTraceResponse.PageNumber = _ctx.IntegerValue("ListPersonTrace.PageNumber");

			List<ListPersonTraceResponse.ListPersonTrace_DataItem> listPersonTraceResponse_data = new List<ListPersonTraceResponse.ListPersonTrace_DataItem>();
			for (int i = 0; i < _ctx.Length("ListPersonTrace.Data.Length"); i++) {
				ListPersonTraceResponse.ListPersonTrace_DataItem dataItem = new ListPersonTraceResponse.ListPersonTrace_DataItem();
				dataItem.Date = _ctx.StringValue("ListPersonTrace.Data["+ i +"].Date");
				dataItem.LastTime = _ctx.StringValue("ListPersonTrace.Data["+ i +"].LastTime");
				dataItem.StartTime = _ctx.StringValue("ListPersonTrace.Data["+ i +"].StartTime");
				dataItem.EndSourceImage = _ctx.StringValue("ListPersonTrace.Data["+ i +"].EndSourceImage");
				dataItem.DeviceId = _ctx.StringValue("ListPersonTrace.Data["+ i +"].DeviceId");
				dataItem.StartTargetImage = _ctx.StringValue("ListPersonTrace.Data["+ i +"].StartTargetImage");
				dataItem.GroupId = _ctx.StringValue("ListPersonTrace.Data["+ i +"].GroupId");
				dataItem.PersonId = _ctx.StringValue("ListPersonTrace.Data["+ i +"].PersonId");
				dataItem.StartSourceImage = _ctx.StringValue("ListPersonTrace.Data["+ i +"].StartSourceImage");
				dataItem.CorpId = _ctx.StringValue("ListPersonTrace.Data["+ i +"].CorpId");
				dataItem.EndTargetImage = _ctx.StringValue("ListPersonTrace.Data["+ i +"].EndTargetImage");

				listPersonTraceResponse_data.Add(dataItem);
			}
			listPersonTraceResponse.Data = listPersonTraceResponse_data;
        
			return listPersonTraceResponse;
        }
    }
}
