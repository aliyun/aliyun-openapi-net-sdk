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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnCrossAccountAuthorizationsResponseUnmarshaller
    {
        public static DescribeVpnCrossAccountAuthorizationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnCrossAccountAuthorizationsResponse describeVpnCrossAccountAuthorizationsResponse = new DescribeVpnCrossAccountAuthorizationsResponse();

			describeVpnCrossAccountAuthorizationsResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnCrossAccountAuthorizationsResponse.RequestId = _ctx.StringValue("DescribeVpnCrossAccountAuthorizations.RequestId");
			describeVpnCrossAccountAuthorizationsResponse.TotalCount = _ctx.IntegerValue("DescribeVpnCrossAccountAuthorizations.TotalCount");
			describeVpnCrossAccountAuthorizationsResponse.PageNumber = _ctx.IntegerValue("DescribeVpnCrossAccountAuthorizations.PageNumber");
			describeVpnCrossAccountAuthorizationsResponse.PageSize = _ctx.IntegerValue("DescribeVpnCrossAccountAuthorizations.PageSize");

			List<DescribeVpnCrossAccountAuthorizationsResponse.DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization> describeVpnCrossAccountAuthorizationsResponse_crossAccountAuthorizations = new List<DescribeVpnCrossAccountAuthorizationsResponse.DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization>();
			for (int i = 0; i < _ctx.Length("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations.Length"); i++) {
				DescribeVpnCrossAccountAuthorizationsResponse.DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization crossAccountAuthorization = new DescribeVpnCrossAccountAuthorizationsResponse.DescribeVpnCrossAccountAuthorizations_CrossAccountAuthorization();
				crossAccountAuthorization.VpnConnectionId = _ctx.StringValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].VpnConnectionId");
				crossAccountAuthorization.BindUid = _ctx.LongValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].BindUid");
				crossAccountAuthorization.BindProduct = _ctx.StringValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].BindProduct");
				crossAccountAuthorization.BindInstance = _ctx.StringValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].BindInstance");
				crossAccountAuthorization.AliUid = _ctx.LongValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].AliUid");
				crossAccountAuthorization.CreationTime = _ctx.LongValue("DescribeVpnCrossAccountAuthorizations.CrossAccountAuthorizations["+ i +"].CreationTime");

				describeVpnCrossAccountAuthorizationsResponse_crossAccountAuthorizations.Add(crossAccountAuthorization);
			}
			describeVpnCrossAccountAuthorizationsResponse.CrossAccountAuthorizations = describeVpnCrossAccountAuthorizationsResponse_crossAccountAuthorizations;
        
			return describeVpnCrossAccountAuthorizationsResponse;
        }
    }
}
