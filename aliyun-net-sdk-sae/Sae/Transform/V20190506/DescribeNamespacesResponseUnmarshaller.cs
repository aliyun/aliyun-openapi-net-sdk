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
        public static DescribeNamespacesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNamespacesResponse describeNamespacesResponse = new DescribeNamespacesResponse();

			describeNamespacesResponse.HttpResponse = context.HttpResponse;
			describeNamespacesResponse.RequestId = context.StringValue("DescribeNamespaces.RequestId");
			describeNamespacesResponse.Code = context.StringValue("DescribeNamespaces.Code");
			describeNamespacesResponse.ErrorCode = context.StringValue("DescribeNamespaces.ErrorCode");
			describeNamespacesResponse.Message = context.StringValue("DescribeNamespaces.Message");
			describeNamespacesResponse.Success = context.BooleanValue("DescribeNamespaces.Success");
			describeNamespacesResponse.TraceId = context.StringValue("DescribeNamespaces.TraceId");

			DescribeNamespacesResponse.DescribeNamespaces_Data data = new DescribeNamespacesResponse.DescribeNamespaces_Data();
			data.CurrentPage = context.IntegerValue("DescribeNamespaces.Data.CurrentPage");
			data.PageSize = context.IntegerValue("DescribeNamespaces.Data.PageSize");
			data.TotalSize = context.IntegerValue("DescribeNamespaces.Data.TotalSize");

			List<DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace> data_namespaces = new List<DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace>();
			for (int i = 0; i < context.Length("DescribeNamespaces.Data.Namespaces.Length"); i++) {
				DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace _namespace = new DescribeNamespacesResponse.DescribeNamespaces_Data.DescribeNamespaces__Namespace();
				_namespace.AccessKey = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].AccessKey");
				_namespace.AddressServerHost = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].AddressServerHost");
				_namespace.SecretKey = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].SecretKey");
				_namespace.TenantId = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].TenantId");
				_namespace.RegionId = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].RegionId");
				_namespace.NamespaceId = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceId");
				_namespace.NamespaceName = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceName");
				_namespace.NamespaceDescription = context.StringValue("DescribeNamespaces.Data.Namespaces["+ i +"].NamespaceDescription");

				data_namespaces.Add(_namespace);
			}
			data.Namespaces = data_namespaces;
			describeNamespacesResponse.Data = data;
        
			return describeNamespacesResponse;
        }
    }
}
