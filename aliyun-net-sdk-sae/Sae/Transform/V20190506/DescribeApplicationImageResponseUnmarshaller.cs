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
    public class DescribeApplicationImageResponseUnmarshaller
    {
        public static DescribeApplicationImageResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeApplicationImageResponse describeApplicationImageResponse = new DescribeApplicationImageResponse();

			describeApplicationImageResponse.HttpResponse = _ctx.HttpResponse;
			describeApplicationImageResponse.RequestId = _ctx.StringValue("DescribeApplicationImage.RequestId");
			describeApplicationImageResponse.Code = _ctx.StringValue("DescribeApplicationImage.Code");
			describeApplicationImageResponse.Message = _ctx.StringValue("DescribeApplicationImage.Message");
			describeApplicationImageResponse.Success = _ctx.BooleanValue("DescribeApplicationImage.Success");
			describeApplicationImageResponse.ErrorCode = _ctx.StringValue("DescribeApplicationImage.ErrorCode");
			describeApplicationImageResponse.TraceId = _ctx.StringValue("DescribeApplicationImage.TraceId");

			DescribeApplicationImageResponse.DescribeApplicationImage_Data data = new DescribeApplicationImageResponse.DescribeApplicationImage_Data();
			data.CrUrl = _ctx.StringValue("DescribeApplicationImage.Data.CrUrl");
			data.Logo = _ctx.StringValue("DescribeApplicationImage.Data.Logo");
			data.RegionId = _ctx.StringValue("DescribeApplicationImage.Data.RegionId");
			data.RepoId = _ctx.IntegerValue("DescribeApplicationImage.Data.RepoId");
			data.RepoName = _ctx.StringValue("DescribeApplicationImage.Data.RepoName");
			data.RepoNamespace = _ctx.StringValue("DescribeApplicationImage.Data.RepoNamespace");
			data.RepoOriginType = _ctx.StringValue("DescribeApplicationImage.Data.RepoOriginType");
			data.RepoType = _ctx.StringValue("DescribeApplicationImage.Data.RepoType");
			data.RepoTag = _ctx.StringValue("DescribeApplicationImage.Data.RepoTag");
			describeApplicationImageResponse.Data = data;
        
			return describeApplicationImageResponse;
        }
    }
}
