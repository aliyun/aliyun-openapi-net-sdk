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
    public class ListAppResponseUnmarshaller
    {
        public static ListAppResponse Unmarshall(UnmarshallerContext context)
        {
			ListAppResponse listAppResponse = new ListAppResponse();

			listAppResponse.HttpResponse = context.HttpResponse;
			listAppResponse.RequestId = context.StringValue("ListApp.RequestId");
			listAppResponse.Code = context.IntegerValue("ListApp.Code");
			listAppResponse.ErrorMsg = context.StringValue("ListApp.ErrorMsg");
			listAppResponse.TotalCount = context.IntegerValue("ListApp.TotalCount");

			List<ListAppResponse.ListApp_ListAppResponse1> listAppResponse_data = new List<ListAppResponse.ListApp_ListAppResponse1>();
			for (int i = 0; i < context.Length("ListApp.Data.Length"); i++) {
				ListAppResponse.ListApp_ListAppResponse1 listAppResponse1 = new ListAppResponse.ListApp_ListAppResponse1();
				listAppResponse1.AppId = context.LongValue("ListApp.Data["+ i +"].AppId");
				listAppResponse1.Title = context.StringValue("ListApp.Data["+ i +"].Title");
				listAppResponse1.Description = context.StringValue("ListApp.Data["+ i +"].Description");
				listAppResponse1.Language = context.StringValue("ListApp.Data["+ i +"].Language");
				listAppResponse1.OperatingSystem = context.StringValue("ListApp.Data["+ i +"].OperatingSystem");
				listAppResponse1.BizName = context.StringValue("ListApp.Data["+ i +"].BizName");
				listAppResponse1.ServiceType = context.StringValue("ListApp.Data["+ i +"].ServiceType");
				listAppResponse1.DeployType = context.StringValue("ListApp.Data["+ i +"].DeployType");
				listAppResponse1.BizTitle = context.StringValue("ListApp.Data["+ i +"].BizTitle");

				listAppResponse_data.Add(listAppResponse1);
			}
			listAppResponse.Data = listAppResponse_data;
        
			return listAppResponse;
        }
    }
}
