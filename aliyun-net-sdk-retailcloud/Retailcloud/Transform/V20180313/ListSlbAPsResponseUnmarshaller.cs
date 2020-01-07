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
    public class ListSlbAPsResponseUnmarshaller
    {
        public static ListSlbAPsResponse Unmarshall(UnmarshallerContext context)
        {
			ListSlbAPsResponse listSlbAPsResponse = new ListSlbAPsResponse();

			listSlbAPsResponse.HttpResponse = context.HttpResponse;
			listSlbAPsResponse.Code = context.IntegerValue("ListSlbAPs.Code");
			listSlbAPsResponse.ErrorMsg = context.StringValue("ListSlbAPs.ErrorMsg");
			listSlbAPsResponse.PageNumber = context.IntegerValue("ListSlbAPs.PageNumber");
			listSlbAPsResponse.PageSize = context.IntegerValue("ListSlbAPs.PageSize");
			listSlbAPsResponse.RequestId = context.StringValue("ListSlbAPs.RequestId");
			listSlbAPsResponse.TotalCount = context.LongValue("ListSlbAPs.TotalCount");

			List<ListSlbAPsResponse.ListSlbAPs_SlbAPInstance> listSlbAPsResponse_data = new List<ListSlbAPsResponse.ListSlbAPs_SlbAPInstance>();
			for (int i = 0; i < context.Length("ListSlbAPs.Data.Length"); i++) {
				ListSlbAPsResponse.ListSlbAPs_SlbAPInstance slbAPInstance = new ListSlbAPsResponse.ListSlbAPs_SlbAPInstance();
				slbAPInstance.AppId = context.LongValue("ListSlbAPs.Data["+ i +"].AppId");
				slbAPInstance.CookieTimeout = context.IntegerValue("ListSlbAPs.Data["+ i +"].CookieTimeout");
				slbAPInstance.EnvId = context.LongValue("ListSlbAPs.Data["+ i +"].EnvId");
				slbAPInstance.EstablishedTimeout = context.IntegerValue("ListSlbAPs.Data["+ i +"].EstablishedTimeout");
				slbAPInstance.ListenerPort = context.IntegerValue("ListSlbAPs.Data["+ i +"].ListenerPort");
				slbAPInstance.Name = context.StringValue("ListSlbAPs.Data["+ i +"].Name");
				slbAPInstance.NetworkMode = context.StringValue("ListSlbAPs.Data["+ i +"].NetworkMode");
				slbAPInstance.Protocol = context.StringValue("ListSlbAPs.Data["+ i +"].Protocol");
				slbAPInstance.RealServerPort = context.IntegerValue("ListSlbAPs.Data["+ i +"].RealServerPort");
				slbAPInstance.SlbAPId = context.LongValue("ListSlbAPs.Data["+ i +"].SlbAPId");
				slbAPInstance.SlbId = context.StringValue("ListSlbAPs.Data["+ i +"].SlbId");
				slbAPInstance.SlbIp = context.StringValue("ListSlbAPs.Data["+ i +"].SlbIp");
				slbAPInstance.SslCertId = context.StringValue("ListSlbAPs.Data["+ i +"].SslCertId");
				slbAPInstance.StickySession = context.IntegerValue("ListSlbAPs.Data["+ i +"].StickySession");

				listSlbAPsResponse_data.Add(slbAPInstance);
			}
			listSlbAPsResponse.Data = listSlbAPsResponse_data;
        
			return listSlbAPsResponse;
        }
    }
}
