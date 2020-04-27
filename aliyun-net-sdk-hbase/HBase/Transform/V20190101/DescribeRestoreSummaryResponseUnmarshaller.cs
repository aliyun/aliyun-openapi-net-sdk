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
    public class DescribeRestoreSummaryResponseUnmarshaller
    {
        public static DescribeRestoreSummaryResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeRestoreSummaryResponse describeRestoreSummaryResponse = new DescribeRestoreSummaryResponse();

			describeRestoreSummaryResponse.HttpResponse = context.HttpResponse;
			describeRestoreSummaryResponse.RequestId = context.StringValue("DescribeRestoreSummary.RequestId");
			describeRestoreSummaryResponse.RestoreRecordSize = context.IntegerValue("DescribeRestoreSummary.RestoreRecordSize");
			describeRestoreSummaryResponse.HasMoreRestoreRecord = context.IntegerValue("DescribeRestoreSummary.HasMoreRestoreRecord");

			List<DescribeRestoreSummaryResponse.DescribeRestoreSummary_Rescord> describeRestoreSummaryResponse_rescords = new List<DescribeRestoreSummaryResponse.DescribeRestoreSummary_Rescord>();
			for (int i = 0; i < context.Length("DescribeRestoreSummary.Rescords.Length"); i++) {
				DescribeRestoreSummaryResponse.DescribeRestoreSummary_Rescord rescord = new DescribeRestoreSummaryResponse.DescribeRestoreSummary_Rescord();
				rescord.RecordId = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].RecordId");
				rescord.FinishTime = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].FinishTime");
				rescord.SchemaProcess = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].SchemaProcess");
				rescord.HfileRestoreProcess = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].HfileRestoreProcess");
				rescord.CreateTime = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].CreateTime");
				rescord.BulkLoadProcess = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].BulkLoadProcess");
				rescord.Status = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].Status");
				rescord.LogProcess = context.StringValue("DescribeRestoreSummary.Rescords["+ i +"].LogProcess");

				describeRestoreSummaryResponse_rescords.Add(rescord);
			}
			describeRestoreSummaryResponse.Rescords = describeRestoreSummaryResponse_rescords;
        
			return describeRestoreSummaryResponse;
        }
    }
}
