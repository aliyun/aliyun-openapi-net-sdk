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
using Aliyun.Acs.ddoscoo.Model.V20200101;

namespace Aliyun.Acs.ddoscoo.Transform.V20200101
{
    public class DescribeSlsLogstoreInfoResponseUnmarshaller
    {
        public static DescribeSlsLogstoreInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSlsLogstoreInfoResponse describeSlsLogstoreInfoResponse = new DescribeSlsLogstoreInfoResponse();

			describeSlsLogstoreInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeSlsLogstoreInfoResponse.Ttl = _ctx.IntegerValue("DescribeSlsLogstoreInfo.Ttl");
			describeSlsLogstoreInfoResponse.RequestId = _ctx.StringValue("DescribeSlsLogstoreInfo.RequestId");
			describeSlsLogstoreInfoResponse.Quota = _ctx.LongValue("DescribeSlsLogstoreInfo.Quota");
			describeSlsLogstoreInfoResponse.LogStore = _ctx.StringValue("DescribeSlsLogstoreInfo.LogStore");
			describeSlsLogstoreInfoResponse.Used = _ctx.LongValue("DescribeSlsLogstoreInfo.Used");
			describeSlsLogstoreInfoResponse.Project = _ctx.StringValue("DescribeSlsLogstoreInfo.Project");
        
			return describeSlsLogstoreInfoResponse;
        }
    }
}
