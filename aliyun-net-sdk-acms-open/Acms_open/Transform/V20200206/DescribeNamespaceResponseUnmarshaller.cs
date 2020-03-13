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
using Aliyun.Acs.acms_open.Model.V20200206;

namespace Aliyun.Acs.acms_open.Transform.V20200206
{
    public class DescribeNamespaceResponseUnmarshaller
    {
        public static DescribeNamespaceResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeNamespaceResponse describeNamespaceResponse = new DescribeNamespaceResponse();

			describeNamespaceResponse.HttpResponse = context.HttpResponse;
			describeNamespaceResponse.RequestId = context.StringValue("DescribeNamespace.RequestId");
			describeNamespaceResponse.Code = context.StringValue("DescribeNamespace.Code");
			describeNamespaceResponse.Message = context.StringValue("DescribeNamespace.Message");

			DescribeNamespaceResponse.DescribeNamespace__Namespace _namespace = new DescribeNamespaceResponse.DescribeNamespace__Namespace();
			_namespace.RegionId = context.StringValue("DescribeNamespace.Namespace.RegionId");
			_namespace.Endpoint = context.StringValue("DescribeNamespace.Namespace.Endpoint");
			_namespace.AccessKey = context.StringValue("DescribeNamespace.Namespace.AccessKey");
			_namespace.SecretKey = context.StringValue("DescribeNamespace.Namespace.SecretKey");
			_namespace.Name = context.StringValue("DescribeNamespace.Namespace.Name");
			describeNamespaceResponse._Namespace = _namespace;
        
			return describeNamespaceResponse;
        }
    }
}
