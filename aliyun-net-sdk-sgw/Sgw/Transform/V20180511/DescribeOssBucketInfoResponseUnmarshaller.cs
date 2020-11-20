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
    public class DescribeOssBucketInfoResponseUnmarshaller
    {
        public static DescribeOssBucketInfoResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOssBucketInfoResponse describeOssBucketInfoResponse = new DescribeOssBucketInfoResponse();

			describeOssBucketInfoResponse.HttpResponse = context.HttpResponse;
			describeOssBucketInfoResponse.RequestId = context.StringValue("DescribeOssBucketInfo.RequestId");
			describeOssBucketInfoResponse.Success = context.BooleanValue("DescribeOssBucketInfo.Success");
			describeOssBucketInfoResponse.Code = context.StringValue("DescribeOssBucketInfo.Code");
			describeOssBucketInfoResponse.Message = context.StringValue("DescribeOssBucketInfo.Message");
			describeOssBucketInfoResponse.IsArchive = context.BooleanValue("DescribeOssBucketInfo.IsArchive");
			describeOssBucketInfoResponse.IsBackToResource = context.BooleanValue("DescribeOssBucketInfo.IsBackToResource");
			describeOssBucketInfoResponse.PollingInterval = context.IntegerValue("DescribeOssBucketInfo.PollingInterval");
			describeOssBucketInfoResponse.IsSupportServerSideEncryption = context.BooleanValue("DescribeOssBucketInfo.IsSupportServerSideEncryption");
			describeOssBucketInfoResponse.IsFresh = context.BooleanValue("DescribeOssBucketInfo.IsFresh");
			describeOssBucketInfoResponse.StorageSize = context.LongValue("DescribeOssBucketInfo.StorageSize");
        
			return describeOssBucketInfoResponse;
        }
    }
}
