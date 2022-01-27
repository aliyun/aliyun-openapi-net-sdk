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
    public class DescribeNamespaceResponseUnmarshaller
    {
        public static DescribeNamespaceResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeNamespaceResponse describeNamespaceResponse = new DescribeNamespaceResponse();

			describeNamespaceResponse.HttpResponse = _ctx.HttpResponse;
			describeNamespaceResponse.RequestId = _ctx.StringValue("DescribeNamespace.RequestId");
			describeNamespaceResponse.Code = _ctx.StringValue("DescribeNamespace.Code");
			describeNamespaceResponse.ErrorCode = _ctx.StringValue("DescribeNamespace.ErrorCode");
			describeNamespaceResponse.Message = _ctx.StringValue("DescribeNamespace.Message");
			describeNamespaceResponse.Success = _ctx.BooleanValue("DescribeNamespace.Success");
			describeNamespaceResponse.TraceId = _ctx.StringValue("DescribeNamespace.TraceId");

			DescribeNamespaceResponse.DescribeNamespace_Data data = new DescribeNamespaceResponse.DescribeNamespace_Data();
			data.RegionId = _ctx.StringValue("DescribeNamespace.Data.RegionId");
			data.NamespaceId = _ctx.StringValue("DescribeNamespace.Data.NamespaceId");
			data.NamespaceName = _ctx.StringValue("DescribeNamespace.Data.NamespaceName");
			data.NamespaceDescription = _ctx.StringValue("DescribeNamespace.Data.NamespaceDescription");
			describeNamespaceResponse.Data = data;
        
			return describeNamespaceResponse;
        }
    }
}
