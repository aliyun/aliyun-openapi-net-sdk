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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListStatusResponseUnmarshaller
    {
        public static ListStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListStatusResponse listStatusResponse = new ListStatusResponse();

			listStatusResponse.HttpResponse = _ctx.HttpResponse;
			listStatusResponse.Code = _ctx.IntegerValue("ListStatus.Code");
			listStatusResponse.Message = _ctx.StringValue("ListStatus.Message");
			listStatusResponse.Success = _ctx.BooleanValue("ListStatus.Success");
			listStatusResponse.RequestId = _ctx.StringValue("ListStatus.RequestId");

			List<ListStatusResponse.ListStatus_Results> listStatusResponse_data = new List<ListStatusResponse.ListStatus_Results>();
			for (int i = 0; i < _ctx.Length("ListStatus.Data.Length"); i++) {
				ListStatusResponse.ListStatus_Results results = new ListStatusResponse.ListStatus_Results();
				results.Region = _ctx.StringValue("ListStatus.Data["+ i +"].Region");
				results.NamespaceId = _ctx.StringValue("ListStatus.Data["+ i +"].NamespaceId");
				results.TenantId = _ctx.StringValue("ListStatus.Data["+ i +"].TenantId");
				results.Source = _ctx.StringValue("ListStatus.Data["+ i +"].Source");
				results.AccountId = _ctx.StringValue("ListStatus.Data["+ i +"].AccountId");
				results.AppId = _ctx.StringValue("ListStatus.Data["+ i +"].AppId");
				results.Ip = _ctx.StringValue("ListStatus.Data["+ i +"].Ip");
				results.PodName = _ctx.StringValue("ListStatus.Data["+ i +"].PodName");
				results.Status = _ctx.StringValue("ListStatus.Data["+ i +"].Status");

				listStatusResponse_data.Add(results);
			}
			listStatusResponse.Data = listStatusResponse_data;
        
			return listStatusResponse;
        }
    }
}
