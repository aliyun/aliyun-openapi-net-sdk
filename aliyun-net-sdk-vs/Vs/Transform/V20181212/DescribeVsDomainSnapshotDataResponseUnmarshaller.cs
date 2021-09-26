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
using Aliyun.Acs.vs.Model.V20181212;

namespace Aliyun.Acs.vs.Transform.V20181212
{
    public class DescribeVsDomainSnapshotDataResponseUnmarshaller
    {
        public static DescribeVsDomainSnapshotDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVsDomainSnapshotDataResponse describeVsDomainSnapshotDataResponse = new DescribeVsDomainSnapshotDataResponse();

			describeVsDomainSnapshotDataResponse.HttpResponse = _ctx.HttpResponse;
			describeVsDomainSnapshotDataResponse.RequestId = _ctx.StringValue("DescribeVsDomainSnapshotData.RequestId");
			describeVsDomainSnapshotDataResponse.DomainName = _ctx.StringValue("DescribeVsDomainSnapshotData.DomainName");
			describeVsDomainSnapshotDataResponse.StartTime = _ctx.StringValue("DescribeVsDomainSnapshotData.StartTime");
			describeVsDomainSnapshotDataResponse.EndTime = _ctx.StringValue("DescribeVsDomainSnapshotData.EndTime");

			List<DescribeVsDomainSnapshotDataResponse.DescribeVsDomainSnapshotData_DataModule> describeVsDomainSnapshotDataResponse_snapshotDataPerInterval = new List<DescribeVsDomainSnapshotDataResponse.DescribeVsDomainSnapshotData_DataModule>();
			for (int i = 0; i < _ctx.Length("DescribeVsDomainSnapshotData.SnapshotDataPerInterval.Length"); i++) {
				DescribeVsDomainSnapshotDataResponse.DescribeVsDomainSnapshotData_DataModule dataModule = new DescribeVsDomainSnapshotDataResponse.DescribeVsDomainSnapshotData_DataModule();
				dataModule.TimeStamp = _ctx.StringValue("DescribeVsDomainSnapshotData.SnapshotDataPerInterval["+ i +"].TimeStamp");
				dataModule.SnapshotValue = _ctx.StringValue("DescribeVsDomainSnapshotData.SnapshotDataPerInterval["+ i +"].SnapshotValue");

				describeVsDomainSnapshotDataResponse_snapshotDataPerInterval.Add(dataModule);
			}
			describeVsDomainSnapshotDataResponse.SnapshotDataPerInterval = describeVsDomainSnapshotDataResponse_snapshotDataPerInterval;
        
			return describeVsDomainSnapshotDataResponse;
        }
    }
}
