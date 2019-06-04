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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeRecordResponseUnmarshaller
    {
        public static DescribeRecordResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRecordResponse describeRecordResponse = new DescribeRecordResponse();

			describeRecordResponse.HttpResponse = context.HttpResponse;
			describeRecordResponse.RequestId = context.StringValue("DescribeRecord.RequestId");
			describeRecordResponse.RecordId = context.StringValue("DescribeRecord.RecordId");
			describeRecordResponse.AppId = context.StringValue("DescribeRecord.AppId");
			describeRecordResponse.BoardId = context.IntegerValue("DescribeRecord.BoardId");
			describeRecordResponse.RecordStartTime = context.LongValue("DescribeRecord.RecordStartTime");
			describeRecordResponse.StartTime = context.LongValue("DescribeRecord.StartTime");
			describeRecordResponse.EndTime = context.LongValue("DescribeRecord.EndTime");
			describeRecordResponse.State = context.IntegerValue("DescribeRecord.State");
			describeRecordResponse.OssPath = context.StringValue("DescribeRecord.OssPath");
			describeRecordResponse.OssBucket = context.StringValue("DescribeRecord.OssBucket");
			describeRecordResponse.OssEndpoint = context.StringValue("DescribeRecord.OssEndpoint");
        
			return describeRecordResponse;
        }
    }
}
