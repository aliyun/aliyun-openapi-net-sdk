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
using Aliyun.Acs.sae.Model.V20190506;

namespace Aliyun.Acs.sae.Transform.V20190506
{
    public class DescribeNamespacesResponseUnmarshaller
    {
        public static DescribeNamespacesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNamespacesResponse describeNamespacesResponse = new DescribeNamespacesResponse();

			describeNamespacesResponse.HttpResponse = _ctx.HttpResponse;
			describeNamespacesResponse.RequestId = _ctx.StringValue("DescribeNamespaces.RequestId");
			describeNamespacesResponse.Code = _ctx.StringValue("DescribeNamespaces.Code");
			describeNamespacesResponse.ErrorCode = _ctx.StringValue("DescribeNamespaces.ErrorCode");
			describeNamespacesResponse.Message = _ctx.StringValue("DescribeNamespaces.Message");
			describeNamespacesResponse.Success = _ctx.BooleanValue("DescribeNamespaces.Success");
			describeNamespacesResponse.TraceId = _ctx.StringValue("DescribeNamespaces.TraceId");

			DescribeNamespacesResponse.DescribeNamespaces_Data data = new DescribeNamespacesResponse.DescribeNamespaces_Data();
			data.CurrentPage = _ctx.IntegerValue("DescribeNamespaces.Data.CurrentPage");
			data.PageSize = _ctx.IntegerValue("DescribeNamespaces.Data.PageSize");
			data.TotalSize = _ctx.IntegerValue("DescribeNamespaces.Data.TotalSize");

			List<DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace> data_namespaces = new List<DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace>();
			for (int i = 0; i < _ctx.Length("DescribeNamespaces.Data.Namespaces.Length"); i++) {
				DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace _namespace = new DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace();
				_namespace.AccessKey = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].AccessKey");
				_namespace.AddressServerHost = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].AddressServerHost");
				_namespace.SecretKey = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].SecretKey");
				_namespace.TenantId = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].TenantId");
				_namespace.RegionId = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].RegionId");
				_namespace.NamespaceId = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceId");
				_namespace.NamespaceName = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceName");
				_namespace.NamespaceDescription = _ctx.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceDescription");

				data_namespaces.Add(_namespace);
			}
			data.Namespaces = data_namespaces;
			describeNamespacesResponse.Data = data;
        
			return describeNamespacesResponse;
        }
    }
}
