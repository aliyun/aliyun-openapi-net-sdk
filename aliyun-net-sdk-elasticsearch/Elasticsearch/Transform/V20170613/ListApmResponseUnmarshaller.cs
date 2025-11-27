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
using Aliyun.Acs.elasticsearch.Model.V20170613;

namespace Aliyun.Acs.elasticsearch.Transform.V20170613
{
    public class ListApmResponseUnmarshaller
    {
        public static ListApmResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListApmResponse listApmResponse = new ListApmResponse();

			listApmResponse.HttpResponse = _ctx.HttpResponse;
			listApmResponse.RequestId = _ctx.StringValue("ListApm.RequestId");

			ListApmResponse.ListApm_Headers headers = new ListApmResponse.ListApm_Headers();
			headers.XTotalCount = _ctx.LongValue("ListApm.Headers.X-Total-Count");
			listApmResponse.Headers = headers;

			List<ListApmResponse.ListApm__Object> listApmResponse_result = new List<ListApmResponse.ListApm__Object>();
			for (int i = 0; i < _ctx.Length("ListApm.Result.Length"); i++) {
				ListApmResponse.ListApm__Object _object = new ListApmResponse.ListApm__Object();
				_object.CreatedAt = _ctx.StringValue("ListApm.Result["+ i +"].createdAt");
				_object.DeployedReplica = _ctx.LongValue("ListApm.Result["+ i +"].deployedReplica");
				_object.Description = _ctx.StringValue("ListApm.Result["+ i +"].description");
				_object.InstanceId = _ctx.StringValue("ListApm.Result["+ i +"].instanceId");
				_object.NodeAmount = _ctx.LongValue("ListApm.Result["+ i +"].nodeAmount");
				_object.OutputES = _ctx.StringValue("ListApm.Result["+ i +"].outputES");
				_object.OutputESUserName = _ctx.StringValue("ListApm.Result["+ i +"].outputESUserName");
				_object.OwnerId = _ctx.StringValue("ListApm.Result["+ i +"].ownerId");
				_object.PaymentType = _ctx.StringValue("ListApm.Result["+ i +"].paymentType");
				_object.Region = _ctx.StringValue("ListApm.Result["+ i +"].region");
				_object.Replica = _ctx.LongValue("ListApm.Result["+ i +"].replica");
				_object.ResourceSpec = _ctx.StringValue("ListApm.Result["+ i +"].resourceSpec");
				_object.Status = _ctx.StringValue("ListApm.Result["+ i +"].status");
				_object.Version = _ctx.StringValue("ListApm.Result["+ i +"].version");
				_object.VpcId = _ctx.StringValue("ListApm.Result["+ i +"].vpcId");
				_object.VsArea = _ctx.StringValue("ListApm.Result["+ i +"].vsArea");
				_object.VswitchId = _ctx.StringValue("ListApm.Result["+ i +"].vswitchId");

				listApmResponse_result.Add(_object);
			}
			listApmResponse.Result = listApmResponse_result;
        
			return listApmResponse;
        }
    }
}
