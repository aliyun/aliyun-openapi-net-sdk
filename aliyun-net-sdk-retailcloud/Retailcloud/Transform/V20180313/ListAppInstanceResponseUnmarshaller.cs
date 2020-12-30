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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class ListAppInstanceResponseUnmarshaller
    {
        public static ListAppInstanceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListAppInstanceResponse listAppInstanceResponse = new ListAppInstanceResponse();

			listAppInstanceResponse.HttpResponse = _ctx.HttpResponse;
			listAppInstanceResponse.RequestId = _ctx.StringValue("ListAppInstance.RequestId");
			listAppInstanceResponse.Code = _ctx.IntegerValue("ListAppInstance.Code");
			listAppInstanceResponse.PageSize = _ctx.IntegerValue("ListAppInstance.PageSize");
			listAppInstanceResponse.PageNumber = _ctx.IntegerValue("ListAppInstance.PageNumber");
			listAppInstanceResponse.TotalCount = _ctx.LongValue("ListAppInstance.TotalCount");
			listAppInstanceResponse.ErrMsg = _ctx.StringValue("ListAppInstance.ErrMsg");

			List<ListAppInstanceResponse.ListAppInstance_AppInstanceDetail> listAppInstanceResponse_data = new List<ListAppInstanceResponse.ListAppInstance_AppInstanceDetail>();
			for (int i = 0; i < _ctx.Length("ListAppInstance.Data.Length"); i++) {
				ListAppInstanceResponse.ListAppInstance_AppInstanceDetail appInstanceDetail = new ListAppInstanceResponse.ListAppInstance_AppInstanceDetail();
				appInstanceDetail.AppInstanceId = _ctx.StringValue("ListAppInstance.Data["+ i +"].AppInstanceId");
				appInstanceDetail.CreateTime = _ctx.StringValue("ListAppInstance.Data["+ i +"].CreateTime");
				appInstanceDetail.Spec = _ctx.StringValue("ListAppInstance.Data["+ i +"].Spec");
				appInstanceDetail.RestartCount = _ctx.IntegerValue("ListAppInstance.Data["+ i +"].RestartCount");
				appInstanceDetail.HostIp = _ctx.StringValue("ListAppInstance.Data["+ i +"].HostIp");
				appInstanceDetail.PodIp = _ctx.StringValue("ListAppInstance.Data["+ i +"].PodIp");
				appInstanceDetail.Health = _ctx.StringValue("ListAppInstance.Data["+ i +"].Health");
				appInstanceDetail.Requests = _ctx.StringValue("ListAppInstance.Data["+ i +"].Requests");
				appInstanceDetail.Limits = _ctx.StringValue("ListAppInstance.Data["+ i +"].Limits");

				listAppInstanceResponse_data.Add(appInstanceDetail);
			}
			listAppInstanceResponse.Data = listAppInstanceResponse_data;
        
			return listAppInstanceResponse;
        }
    }
}
