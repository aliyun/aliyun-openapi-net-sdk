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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class GetDbProxyInstanceSslResponseUnmarshaller
    {
        public static GetDbProxyInstanceSslResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDbProxyInstanceSslResponse getDbProxyInstanceSslResponse = new GetDbProxyInstanceSslResponse();

			getDbProxyInstanceSslResponse.HttpResponse = _ctx.HttpResponse;
			getDbProxyInstanceSslResponse.RequestId = _ctx.StringValue("GetDbProxyInstanceSsl.RequestId");

			List<GetDbProxyInstanceSslResponse.GetDbProxyInstanceSsl_DbProxyCertListItemsItem> getDbProxyInstanceSslResponse_dbProxyCertListItems = new List<GetDbProxyInstanceSslResponse.GetDbProxyInstanceSsl_DbProxyCertListItemsItem>();
			for (int i = 0; i < _ctx.Length("GetDbProxyInstanceSsl.DbProxyCertListItems.Length"); i++) {
				GetDbProxyInstanceSslResponse.GetDbProxyInstanceSsl_DbProxyCertListItemsItem dbProxyCertListItemsItem = new GetDbProxyInstanceSslResponse.GetDbProxyInstanceSsl_DbProxyCertListItemsItem();
				dbProxyCertListItemsItem.DbInstanceName = _ctx.StringValue("GetDbProxyInstanceSsl.DbProxyCertListItems["+ i +"].DbInstanceName");
				dbProxyCertListItemsItem.EndpointName = _ctx.StringValue("GetDbProxyInstanceSsl.DbProxyCertListItems["+ i +"].EndpointName");
				dbProxyCertListItemsItem.EndpointType = _ctx.StringValue("GetDbProxyInstanceSsl.DbProxyCertListItems["+ i +"].EndpointType");
				dbProxyCertListItemsItem.CertCommonName = _ctx.StringValue("GetDbProxyInstanceSsl.DbProxyCertListItems["+ i +"].CertCommonName");
				dbProxyCertListItemsItem.SslExpiredTime = _ctx.StringValue("GetDbProxyInstanceSsl.DbProxyCertListItems["+ i +"].SslExpiredTime");

				getDbProxyInstanceSslResponse_dbProxyCertListItems.Add(dbProxyCertListItemsItem);
			}
			getDbProxyInstanceSslResponse.DbProxyCertListItems = getDbProxyInstanceSslResponse_dbProxyCertListItems;
        
			return getDbProxyInstanceSslResponse;
        }
    }
}
