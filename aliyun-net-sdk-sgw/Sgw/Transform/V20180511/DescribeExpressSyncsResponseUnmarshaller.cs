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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeExpressSyncsResponseUnmarshaller
    {
        public static DescribeExpressSyncsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExpressSyncsResponse describeExpressSyncsResponse = new DescribeExpressSyncsResponse();

			describeExpressSyncsResponse.HttpResponse = _ctx.HttpResponse;
			describeExpressSyncsResponse.RequestId = _ctx.StringValue("DescribeExpressSyncs.RequestId");
			describeExpressSyncsResponse.Success = _ctx.BooleanValue("DescribeExpressSyncs.Success");
			describeExpressSyncsResponse.Code = _ctx.StringValue("DescribeExpressSyncs.Code");
			describeExpressSyncsResponse.Message = _ctx.StringValue("DescribeExpressSyncs.Message");

			List<DescribeExpressSyncsResponse.DescribeExpressSyncs_ExpressSync> describeExpressSyncsResponse_expressSyncs = new List<DescribeExpressSyncsResponse.DescribeExpressSyncs_ExpressSync>();
			for (int i = 0; i < _ctx.Length("DescribeExpressSyncs.ExpressSyncs.Length"); i++) {
				DescribeExpressSyncsResponse.DescribeExpressSyncs_ExpressSync expressSync = new DescribeExpressSyncsResponse.DescribeExpressSyncs_ExpressSync();
				expressSync.ExpressSyncId = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].ExpressSyncId");
				expressSync.Name = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].Name");
				expressSync.Description = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].Description");
				expressSync.BucketRegion = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].BucketRegion");
				expressSync.BucketName = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].BucketName");
				expressSync.BucketPrefix = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].BucketPrefix");
				expressSync.MnsTopic = _ctx.StringValue("DescribeExpressSyncs.ExpressSyncs["+ i +"].MnsTopic");

				describeExpressSyncsResponse_expressSyncs.Add(expressSync);
			}
			describeExpressSyncsResponse.ExpressSyncs = describeExpressSyncsResponse_expressSyncs;
        
			return describeExpressSyncsResponse;
        }
    }
}
