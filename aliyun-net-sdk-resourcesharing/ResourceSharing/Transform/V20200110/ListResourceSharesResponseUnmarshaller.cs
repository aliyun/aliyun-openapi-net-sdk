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
using Aliyun.Acs.ResourceSharing.Model.V20200110;

namespace Aliyun.Acs.ResourceSharing.Transform.V20200110
{
    public class ListResourceSharesResponseUnmarshaller
    {
        public static ListResourceSharesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListResourceSharesResponse listResourceSharesResponse = new ListResourceSharesResponse();

			listResourceSharesResponse.HttpResponse = _ctx.HttpResponse;
			listResourceSharesResponse.NextToken = _ctx.StringValue("ListResourceShares.NextToken");
			listResourceSharesResponse.RequestId = _ctx.StringValue("ListResourceShares.RequestId");

			List<ListResourceSharesResponse.ListResourceShares_ResourceShare> listResourceSharesResponse_resourceShares = new List<ListResourceSharesResponse.ListResourceShares_ResourceShare>();
			for (int i = 0; i < _ctx.Length("ListResourceShares.ResourceShares.Length"); i++) {
				ListResourceSharesResponse.ListResourceShares_ResourceShare resourceShare = new ListResourceSharesResponse.ListResourceShares_ResourceShare();
				resourceShare.UpdateTime = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].UpdateTime");
				resourceShare.ResourceShareName = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].ResourceShareName");
				resourceShare.ResourceShareOwner = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].ResourceShareOwner");
				resourceShare.CreateTime = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].CreateTime");
				resourceShare.ResourceShareId = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].ResourceShareId");
				resourceShare.ResourceShareStatus = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].ResourceShareStatus");
				resourceShare.AllowExternalTargets = _ctx.BooleanValue("ListResourceShares.ResourceShares["+ i +"].AllowExternalTargets");
				resourceShare.ResourceGroupId = _ctx.StringValue("ListResourceShares.ResourceShares["+ i +"].ResourceGroupId");

				listResourceSharesResponse_resourceShares.Add(resourceShare);
			}
			listResourceSharesResponse.ResourceShares = listResourceSharesResponse_resourceShares;
        
			return listResourceSharesResponse;
        }
    }
}
