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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class DescribeOssPropertiesResponseUnmarshaller
    {
        public static DescribeOssPropertiesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssPropertiesResponse describeOssPropertiesResponse = new DescribeOssPropertiesResponse();

			describeOssPropertiesResponse.HttpResponse = context.HttpResponse;
			describeOssPropertiesResponse.RequestId = context.StringValue("DescribeOssProperties.RequestId");

			DescribeOssPropertiesResponse.DescribeOssProperties_Result result = new DescribeOssPropertiesResponse.DescribeOssProperties_Result();
			result.Endpoint = context.StringValue("DescribeOssProperties.Result.Endpoint");
			result.AccessKeyId = context.StringValue("DescribeOssProperties.Result.AccessKeyId");
			result.AccessKeySecret = context.StringValue("DescribeOssProperties.Result.AccessKeySecret");
			result.BucketName = context.StringValue("DescribeOssProperties.Result.BucketName");
			result.FolderName = context.StringValue("DescribeOssProperties.Result.FolderName");
			describeOssPropertiesResponse.Result = result;
        
			return describeOssPropertiesResponse;
        }
    }
}