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
    public class DescribeRestoreFullDetailsResponseUnmarshaller
    {
        public static DescribeRestoreFullDetailsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreFullDetailsResponse describeRestoreFullDetailsResponse = new DescribeRestoreFullDetailsResponse();

			describeRestoreFullDetailsResponse.HttpResponse = context.HttpResponse;
			describeRestoreFullDetailsResponse.RequestId = context.StringValue("DescribeRestoreFullDetails.RequestId");

			DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull restoreFull = new DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull();
			restoreFull.Succeed = context.IntegerValue("DescribeRestoreFullDetails.RestoreFull.Succeed");
			restoreFull.Fail = context.IntegerValue("DescribeRestoreFullDetails.RestoreFull.Fail");
			restoreFull.DataSize = context.StringValue("DescribeRestoreFullDetails.RestoreFull.DataSize");
			restoreFull.Speed = context.StringValue("DescribeRestoreFullDetails.RestoreFull.Speed");
			restoreFull.Total = context.LongValue("DescribeRestoreFullDetails.RestoreFull.Total");
			restoreFull.PageNumber = context.IntegerValue("DescribeRestoreFullDetails.RestoreFull.PageNumber");
			restoreFull.PageSize = context.IntegerValue("DescribeRestoreFullDetails.RestoreFull.PageSize");

			List<DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull.DescribeRestoreFullDetails_RestoreFullDetail> restoreFull_restoreFullDetails = new List<DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull.DescribeRestoreFullDetails_RestoreFullDetail>();
			for (int i = 0; i < context.Length("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails.Length"); i++) {
				DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull.DescribeRestoreFullDetails_RestoreFullDetail restoreFullDetail = new DescribeRestoreFullDetailsResponse.DescribeRestoreFullDetails_RestoreFull.DescribeRestoreFullDetails_RestoreFullDetail();
				restoreFullDetail.Table = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].Table");
				restoreFullDetail.State = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].State");
				restoreFullDetail.StartTime = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].StartTime");
				restoreFullDetail.EndTime = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].EndTime");
				restoreFullDetail.Process = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].Process");
				restoreFullDetail.DataSize = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].DataSize");
				restoreFullDetail.Speed = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].Speed");
				restoreFullDetail.Message = context.StringValue("DescribeRestoreFullDetails.RestoreFull.RestoreFullDetails["+ i +"].Message");

				restoreFull_restoreFullDetails.Add(restoreFullDetail);
			}
			restoreFull.RestoreFullDetails = restoreFull_restoreFullDetails;
			describeRestoreFullDetailsResponse.RestoreFull = restoreFull;
        
			return describeRestoreFullDetailsResponse;
        }
    }
}
