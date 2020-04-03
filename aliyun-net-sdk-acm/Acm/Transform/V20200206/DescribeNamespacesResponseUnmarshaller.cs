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
using Aliyun.Acs.acm.Model.V20200206;

namespace Aliyun.Acs.acm.Transform.V20200206
{
    public class DescribeNamespacesResponseUnmarshaller
    {
        public static DescribeNamespacesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNamespacesResponse describeNamespacesResponse = new DescribeNamespacesResponse();

			describeNamespacesResponse.HttpResponse = context.HttpResponse;
			describeNamespacesResponse.RequestId = context.StringValue("DescribeNamespaces.RequestId");
			describeNamespacesResponse.Code = context.StringValue("DescribeNamespaces.Code");
			describeNamespacesResponse.Message = context.StringValue("DescribeNamespaces.Message");

			List<DescribeNamespacesResponse.DescribeNamespaces__Namespace> describeNamespacesResponse_namespaces = new List<DescribeNamespacesResponse.DescribeNamespaces__Namespace>();
			for (int i = 0; i < context.Length("DescribeNamespaces.Namespaces.Length"); i++) {
				DescribeNamespacesResponse.DescribeNamespaces__Namespace _namespace = new DescribeNamespacesResponse.DescribeNamespaces__Namespace();
				_namespace.ConfigCount = context.IntegerValue("DescribeNamespaces.Namespaces["+ i +"].ConfigCount");
				_namespace.NamespaceId = context.StringValue("DescribeNamespaces.Namespaces["+ i +"].NamespaceId");
				_namespace.NamespaceName = context.StringValue("DescribeNamespaces.Namespaces["+ i +"].NamespaceName");
				_namespace.Quota = context.IntegerValue("DescribeNamespaces.Namespaces["+ i +"].Quota");
				_namespace.Type = context.IntegerValue("DescribeNamespaces.Namespaces["+ i +"].Type");

				describeNamespacesResponse_namespaces.Add(_namespace);
			}
			describeNamespacesResponse.Namespaces = describeNamespacesResponse_namespaces;
        
			return describeNamespacesResponse;
        }
    }
}
