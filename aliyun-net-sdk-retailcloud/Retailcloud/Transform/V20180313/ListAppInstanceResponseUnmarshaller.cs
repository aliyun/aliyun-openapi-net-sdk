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
        public static ListAppInstanceResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppInstanceResponse listAppInstanceResponse = new ListAppInstanceResponse();

			listAppInstanceResponse.HttpResponse = context.HttpResponse;
			listAppInstanceResponse.RequestId = context.StringValue("ListAppInstance.RequestId");
			listAppInstanceResponse.Code = context.IntegerValue("ListAppInstance.Code");
			listAppInstanceResponse.PageSize = context.IntegerValue("ListAppInstance.PageSize");
			listAppInstanceResponse.PageNumber = context.IntegerValue("ListAppInstance.PageNumber");
			listAppInstanceResponse.TotalCount = context.LongValue("ListAppInstance.TotalCount");
			listAppInstanceResponse.ErrMsg = context.StringValue("ListAppInstance.ErrMsg");

			List<ListAppInstanceResponse.ListAppInstance_ListAppInstanceResponse1> listAppInstanceResponse_data = new List<ListAppInstanceResponse.ListAppInstance_ListAppInstanceResponse1>();
			for (int i = 0; i < context.Length("ListAppInstance.Data.Length"); i++) {
				ListAppInstanceResponse.ListAppInstance_ListAppInstanceResponse1 listAppInstanceResponse1 = new ListAppInstanceResponse.ListAppInstance_ListAppInstanceResponse1();
				listAppInstanceResponse1.AppInstanceId = context.StringValue("ListAppInstance.Data["+ i +"].AppInstanceId");
				listAppInstanceResponse1.CreateTime = context.StringValue("ListAppInstance.Data["+ i +"].CreateTime");
				listAppInstanceResponse1.Spec = context.StringValue("ListAppInstance.Data["+ i +"].Spec");
				listAppInstanceResponse1.RestartCount = context.IntegerValue("ListAppInstance.Data["+ i +"].RestartCount");
				listAppInstanceResponse1.HostIp = context.StringValue("ListAppInstance.Data["+ i +"].HostIp");
				listAppInstanceResponse1.PodIp = context.StringValue("ListAppInstance.Data["+ i +"].PodIp");
				listAppInstanceResponse1.Health = context.StringValue("ListAppInstance.Data["+ i +"].Health");

				listAppInstanceResponse_data.Add(listAppInstanceResponse1);
			}
			listAppInstanceResponse.Data = listAppInstanceResponse_data;
        
			return listAppInstanceResponse;
        }
    }
}
