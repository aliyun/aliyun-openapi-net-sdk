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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeImageUploadInfoResponseUnmarshaller
    {
        public static DescribeImageUploadInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageUploadInfoResponse describeImageUploadInfoResponse = new DescribeImageUploadInfoResponse();

			describeImageUploadInfoResponse.HttpResponse = _ctx.HttpResponse;
			describeImageUploadInfoResponse.RequestId = _ctx.StringValue("DescribeImageUploadInfo.RequestId");
			describeImageUploadInfoResponse.Accessid = _ctx.StringValue("DescribeImageUploadInfo.Accessid");
			describeImageUploadInfoResponse.Policy = _ctx.StringValue("DescribeImageUploadInfo.Policy");
			describeImageUploadInfoResponse.Signature = _ctx.StringValue("DescribeImageUploadInfo.Signature");
			describeImageUploadInfoResponse.Folder = _ctx.StringValue("DescribeImageUploadInfo.Folder");
			describeImageUploadInfoResponse.Host = _ctx.StringValue("DescribeImageUploadInfo.Host");
			describeImageUploadInfoResponse.Expire = _ctx.IntegerValue("DescribeImageUploadInfo.Expire");
        
			return describeImageUploadInfoResponse;
        }
    }
}
