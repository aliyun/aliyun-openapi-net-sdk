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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.LinkFace.Model.V20180720;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.LinkFace.Transform.V20180720
{
    public class QueryAuthenticationResponseUnmarshaller
    {
        public static QueryAuthenticationResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAuthenticationResponse queryAuthenticationResponse = new QueryAuthenticationResponse();

			queryAuthenticationResponse.HttpResponse = context.HttpResponse;
			queryAuthenticationResponse.RequestId = context.StringValue("QueryAuthentication.RequestId");
			queryAuthenticationResponse.Code = context.IntegerValue("QueryAuthentication.Code");
			queryAuthenticationResponse.Message = context.StringValue("QueryAuthentication.Message");
			queryAuthenticationResponse.PageCount = context.IntegerValue("QueryAuthentication.PageCount");
			queryAuthenticationResponse.PageSize = context.IntegerValue("QueryAuthentication.PageSize");
			queryAuthenticationResponse.Page = context.IntegerValue("QueryAuthentication.Page");
			queryAuthenticationResponse.Total = context.IntegerValue("QueryAuthentication.Total");
			queryAuthenticationResponse.Success = context.BooleanValue("QueryAuthentication.Success");

			List<QueryAuthenticationResponse.QueryAuthentication_DataItem> queryAuthenticationResponse_data = new List<QueryAuthenticationResponse.QueryAuthentication_DataItem>();
			for (int i = 0; i < context.Length("QueryAuthentication.Data.Length"); i++) {
				QueryAuthenticationResponse.QueryAuthentication_DataItem dataItem = new QueryAuthenticationResponse.QueryAuthentication_DataItem();
				dataItem.LicenseType = context.IntegerValue("QueryAuthentication.Data["+ i +"].LicenseType");
				dataItem.IotId = context.StringValue("QueryAuthentication.Data["+ i +"].IotId");
				dataItem.BeginTime = context.StringValue("QueryAuthentication.Data["+ i +"].BeginTime");
				dataItem.ExpiredTime = context.StringValue("QueryAuthentication.Data["+ i +"].ExpiredTime");
				dataItem.ApkPubkey = context.StringValue("QueryAuthentication.Data["+ i +"].ApkPubkey");
				dataItem.PackageName = context.StringValue("QueryAuthentication.Data["+ i +"].PackageName");
				dataItem.ClientId = context.StringValue("QueryAuthentication.Data["+ i +"].ClientId");
				dataItem.ProductKey = context.StringValue("QueryAuthentication.Data["+ i +"].ProductKey");
				dataItem.DeviceName = context.StringValue("QueryAuthentication.Data["+ i +"].DeviceName");

				queryAuthenticationResponse_data.Add(dataItem);
			}
			queryAuthenticationResponse.Data = queryAuthenticationResponse_data;
        
			return queryAuthenticationResponse;
        }
    }
}