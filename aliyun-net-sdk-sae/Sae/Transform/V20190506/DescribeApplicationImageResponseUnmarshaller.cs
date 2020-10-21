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
        public static DescribeApplicationImageResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeApplicationImageResponse describeApplicationImageResponse = new DescribeApplicationImageResponse();

			describeApplicationImageResponse.HttpResponse = context.HttpResponse;
			describeApplicationImageResponse.RequestId = context.StringValue("DescribeApplicationImage.RequestId");
			describeApplicationImageResponse.Code = context.StringValue("DescribeApplicationImage.Code");
			describeApplicationImageResponse.Message = context.StringValue("DescribeApplicationImage.Message");
			describeApplicationImageResponse.Success = context.BooleanValue("DescribeApplicationImage.Success");
			describeApplicationImageResponse.ErrorCode = context.StringValue("DescribeApplicationImage.ErrorCode");
			describeApplicationImageResponse.TraceId = context.StringValue("DescribeApplicationImage.TraceId");

			DescribeApplicationImageResponse.DescribeApplicationImage_Data data = new DescribeApplicationImageResponse.DescribeApplicationImage_Data();
			data.CrUrl = context.StringValue("DescribeApplicationImage.Data.CrUrl");
			data.Logo = context.StringValue("DescribeApplicationImage.Data.Logo");
			data.RegionId = context.StringValue("DescribeApplicationImage.Data.RegionId");
			data.RepoId = context.IntegerValue("DescribeApplicationImage.Data.RepoId");
			data.RepoName = context.StringValue("DescribeApplicationImage.Data.RepoName");
			data.RepoNamespace = context.StringValue("DescribeApplicationImage.Data.RepoNamespace");
			data.RepoOriginType = context.StringValue("DescribeApplicationImage.Data.RepoOriginType");
			data.RepoType = context.StringValue("DescribeApplicationImage.Data.RepoType");
			data.RepoTag = context.StringValue("DescribeApplicationImage.Data.RepoTag");
			describeApplicationImageResponse.Data = data;
        
			return describeApplicationImageResponse;
        }
    }
}
