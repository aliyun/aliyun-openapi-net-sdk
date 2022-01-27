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
        public static ListSlbAPsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSlbAPsResponse listSlbAPsResponse = new ListSlbAPsResponse();

			listSlbAPsResponse.HttpResponse = _ctx.HttpResponse;
			listSlbAPsResponse.Code = _ctx.IntegerValue("ListSlbAPs.Code");
			listSlbAPsResponse.ErrorMsg = _ctx.StringValue("ListSlbAPs.ErrorMsg");
			listSlbAPsResponse.PageNumber = _ctx.IntegerValue("ListSlbAPs.PageNumber");
			listSlbAPsResponse.PageSize = _ctx.IntegerValue("ListSlbAPs.PageSize");
			listSlbAPsResponse.RequestId = _ctx.StringValue("ListSlbAPs.RequestId");
			listSlbAPsResponse.TotalCount = _ctx.LongValue("ListSlbAPs.TotalCount");

			List<ListSlbAPsResponse.ListSlbAPs_SlbAPInstance> listSlbAPsResponse_data = new List<ListSlbAPsResponse.ListSlbAPs_SlbAPInstance>();
			for (int i = 0; i < _ctx.Length("ListSlbAPs.Data.Length"); i++) {
				ListSlbAPsResponse.ListSlbAPs_SlbAPInstance slbAPInstance = new ListSlbAPsResponse.ListSlbAPs_SlbAPInstance();
				slbAPInstance.AppId = _ctx.LongValue("ListSlbAPs.Data["+ i +"].AppId");
				slbAPInstance.CookieTimeout = _ctx.IntegerValue("ListSlbAPs.Data["+ i +"].CookieTimeout");
				slbAPInstance.EnvId = _ctx.LongValue("ListSlbAPs.Data["+ i +"].EnvId");
				slbAPInstance.EstablishedTimeout = _ctx.IntegerValue("ListSlbAPs.Data["+ i +"].EstablishedTimeout");
				slbAPInstance.ListenerPort = _ctx.IntegerValue("ListSlbAPs.Data["+ i +"].ListenerPort");
				slbAPInstance.Name = _ctx.StringValue("ListSlbAPs.Data["+ i +"].Name");
				slbAPInstance.NetworkMode = _ctx.StringValue("ListSlbAPs.Data["+ i +"].NetworkMode");
				slbAPInstance.Protocol = _ctx.StringValue("ListSlbAPs.Data["+ i +"].Protocol");
				slbAPInstance.RealServerPort = _ctx.IntegerValue("ListSlbAPs.Data["+ i +"].RealServerPort");
				slbAPInstance.SlbAPId = _ctx.LongValue("ListSlbAPs.Data["+ i +"].SlbAPId");
				slbAPInstance.SlbId = _ctx.StringValue("ListSlbAPs.Data["+ i +"].SlbId");
				slbAPInstance.SlbIp = _ctx.StringValue("ListSlbAPs.Data["+ i +"].SlbIp");
				slbAPInstance.SslCertId = _ctx.StringValue("ListSlbAPs.Data["+ i +"].SslCertId");
				slbAPInstance.StickySession = _ctx.IntegerValue("ListSlbAPs.Data["+ i +"].StickySession");

				listSlbAPsResponse_data.Add(slbAPInstance);
			}
			listSlbAPsResponse.Data = listSlbAPsResponse_data;
        
			return listSlbAPsResponse;
        }
    }
}
