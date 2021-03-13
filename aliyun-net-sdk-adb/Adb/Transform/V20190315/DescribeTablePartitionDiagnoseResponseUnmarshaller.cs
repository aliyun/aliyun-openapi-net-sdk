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
using Aliyun.Acs.adb.Model.V20190315;

namespace Aliyun.Acs.adb.Transform.V20190315
{
    public class DescribeTablePartitionDiagnoseResponseUnmarshaller
    {
        public static DescribeTablePartitionDiagnoseResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTablePartitionDiagnoseResponse describeTablePartitionDiagnoseResponse = new DescribeTablePartitionDiagnoseResponse();

			describeTablePartitionDiagnoseResponse.HttpResponse = _ctx.HttpResponse;
			describeTablePartitionDiagnoseResponse.TotalCount = _ctx.IntegerValue("DescribeTablePartitionDiagnose.TotalCount");
			describeTablePartitionDiagnoseResponse.PageSize = _ctx.IntegerValue("DescribeTablePartitionDiagnose.PageSize");
			describeTablePartitionDiagnoseResponse.RequestId = _ctx.StringValue("DescribeTablePartitionDiagnose.RequestId");
			describeTablePartitionDiagnoseResponse.PageNumber = _ctx.IntegerValue("DescribeTablePartitionDiagnose.PageNumber");
			describeTablePartitionDiagnoseResponse.DBClusterId = _ctx.StringValue("DescribeTablePartitionDiagnose.DBClusterId");
			describeTablePartitionDiagnoseResponse.SuggestMaxRecordsPerPartition = _ctx.LongValue("DescribeTablePartitionDiagnose.SuggestMaxRecordsPerPartition");
			describeTablePartitionDiagnoseResponse.SuggestMinRecordsPerPartition = _ctx.LongValue("DescribeTablePartitionDiagnose.SuggestMinRecordsPerPartition");

			List<DescribeTablePartitionDiagnoseResponse.DescribeTablePartitionDiagnose_TablePartitionDiagnose> describeTablePartitionDiagnoseResponse_items = new List<DescribeTablePartitionDiagnoseResponse.DescribeTablePartitionDiagnose_TablePartitionDiagnose>();
			for (int i = 0; i < _ctx.Length("DescribeTablePartitionDiagnose.Items.Length"); i++) {
				DescribeTablePartitionDiagnoseResponse.DescribeTablePartitionDiagnose_TablePartitionDiagnose tablePartitionDiagnose = new DescribeTablePartitionDiagnoseResponse.DescribeTablePartitionDiagnose_TablePartitionDiagnose();
				tablePartitionDiagnose.TableName = _ctx.StringValue("DescribeTablePartitionDiagnose.Items["+ i +"].TableName");
				tablePartitionDiagnose.PartitionNumber = _ctx.IntegerValue("DescribeTablePartitionDiagnose.Items["+ i +"].PartitionNumber");
				tablePartitionDiagnose.PartitionDetail = _ctx.StringValue("DescribeTablePartitionDiagnose.Items["+ i +"].PartitionDetail");
				tablePartitionDiagnose.SchemaName = _ctx.StringValue("DescribeTablePartitionDiagnose.Items["+ i +"].SchemaName");

				describeTablePartitionDiagnoseResponse_items.Add(tablePartitionDiagnose);
			}
			describeTablePartitionDiagnoseResponse.Items = describeTablePartitionDiagnoseResponse_items;
        
			return describeTablePartitionDiagnoseResponse;
        }
    }
}
