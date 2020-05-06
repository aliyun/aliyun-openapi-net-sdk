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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeRestoreIncrDetailResponseUnmarshaller
    {
        public static DescribeRestoreIncrDetailResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreIncrDetailResponse describeRestoreIncrDetailResponse = new DescribeRestoreIncrDetailResponse();

			describeRestoreIncrDetailResponse.HttpResponse = context.HttpResponse;
			describeRestoreIncrDetailResponse.RequestId = context.StringValue("DescribeRestoreIncrDetail.RequestId");

			DescribeRestoreIncrDetailResponse.DescribeRestoreIncrDetail_RestoreIncrDetail restoreIncrDetail = new DescribeRestoreIncrDetailResponse.DescribeRestoreIncrDetail_RestoreIncrDetail();
			restoreIncrDetail.State = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.State");
			restoreIncrDetail.StartTime = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.StartTime");
			restoreIncrDetail.EndTime = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.EndTime");
			restoreIncrDetail.RestoreStartTs = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.RestoreStartTs");
			restoreIncrDetail.RestoredTs = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.RestoredTs");
			restoreIncrDetail.RestoreDelay = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.RestoreDelay");
			restoreIncrDetail.Process = context.StringValue("DescribeRestoreIncrDetail.RestoreIncrDetail.Process");
			describeRestoreIncrDetailResponse.RestoreIncrDetail = restoreIncrDetail;
        
			return describeRestoreIncrDetailResponse;
        }
    }
}
