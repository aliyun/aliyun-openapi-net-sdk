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
using Aliyun.Acs.sophonsoar.Model.V20220728;

namespace Aliyun.Acs.sophonsoar.Transform.V20220728
{
    public class DescribeDistinctReleasesResponseUnmarshaller
    {
        public static DescribeDistinctReleasesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDistinctReleasesResponse describeDistinctReleasesResponse = new DescribeDistinctReleasesResponse();

			describeDistinctReleasesResponse.HttpResponse = _ctx.HttpResponse;
			describeDistinctReleasesResponse.RequestId = _ctx.StringValue("DescribeDistinctReleases.RequestId");

			List<DescribeDistinctReleasesResponse.DescribeDistinctReleases_RecordsItem> describeDistinctReleasesResponse_records = new List<DescribeDistinctReleasesResponse.DescribeDistinctReleases_RecordsItem>();
			for (int i = 0; i < _ctx.Length("DescribeDistinctReleases.Records.Length"); i++) {
				DescribeDistinctReleasesResponse.DescribeDistinctReleases_RecordsItem recordsItem = new DescribeDistinctReleasesResponse.DescribeDistinctReleases_RecordsItem();
				recordsItem.Description = _ctx.StringValue("DescribeDistinctReleases.Records["+ i +"].Description");
				recordsItem.TaskflowMd5 = _ctx.StringValue("DescribeDistinctReleases.Records["+ i +"].TaskflowMd5");
				recordsItem.FlowFlag = _ctx.IntegerValue("DescribeDistinctReleases.Records["+ i +"].FlowFlag");
				recordsItem.FlowTag = _ctx.IntegerValue("DescribeDistinctReleases.Records["+ i +"].FlowTag");
				recordsItem.TaskflowType = _ctx.StringValue("DescribeDistinctReleases.Records["+ i +"].TaskflowType");

				describeDistinctReleasesResponse_records.Add(recordsItem);
			}
			describeDistinctReleasesResponse.Records = describeDistinctReleasesResponse_records;
        
			return describeDistinctReleasesResponse;
        }
    }
}
