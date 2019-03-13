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
using Aliyun.Acs.jarvis.Model.V20180206;

namespace Aliyun.Acs.jarvis.Transform.V20180206
{
    public class DescribeResetRecordQueryCountResponseUnmarshaller
    {
        public static DescribeResetRecordQueryCountResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeResetRecordQueryCountResponse describeResetRecordQueryCountResponse = new DescribeResetRecordQueryCountResponse();

			describeResetRecordQueryCountResponse.HttpResponse = context.HttpResponse;
			describeResetRecordQueryCountResponse.RequestId = context.StringValue("DescribeResetRecordQueryCount.RequestId");
			describeResetRecordQueryCountResponse.TotalCount = context.IntegerValue("DescribeResetRecordQueryCount.TotalCount");
			describeResetRecordQueryCountResponse.QueryCount = context.IntegerValue("DescribeResetRecordQueryCount.QueryCount");
			describeResetRecordQueryCountResponse.Module = context.StringValue("DescribeResetRecordQueryCount.Module");
        
			return describeResetRecordQueryCountResponse;
        }
    }
}
