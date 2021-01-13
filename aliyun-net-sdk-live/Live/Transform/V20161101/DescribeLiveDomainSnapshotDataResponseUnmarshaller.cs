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
    public class DescribeLiveDomainSnapshotDataResponseUnmarshaller
    {
        public static DescribeLiveDomainSnapshotDataResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveDomainSnapshotDataResponse describeLiveDomainSnapshotDataResponse = new DescribeLiveDomainSnapshotDataResponse();

			describeLiveDomainSnapshotDataResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveDomainSnapshotDataResponse.RequestId = _ctx.StringValue("DescribeLiveDomainSnapshotData.RequestId");

			List<DescribeLiveDomainSnapshotDataResponse.DescribeLiveDomainSnapshotData_SnapshotDataInfo> describeLiveDomainSnapshotDataResponse_snapshotDataInfos = new List<DescribeLiveDomainSnapshotDataResponse.DescribeLiveDomainSnapshotData_SnapshotDataInfo>();
			for (int i = 0; i < _ctx.Length("DescribeLiveDomainSnapshotData.SnapshotDataInfos.Length"); i++) {
				DescribeLiveDomainSnapshotDataResponse.DescribeLiveDomainSnapshotData_SnapshotDataInfo snapshotDataInfo = new DescribeLiveDomainSnapshotDataResponse.DescribeLiveDomainSnapshotData_SnapshotDataInfo();
				snapshotDataInfo.Date = _ctx.StringValue("DescribeLiveDomainSnapshotData.SnapshotDataInfos["+ i +"].Date");
				snapshotDataInfo.Total = _ctx.IntegerValue("DescribeLiveDomainSnapshotData.SnapshotDataInfos["+ i +"].Total");

				describeLiveDomainSnapshotDataResponse_snapshotDataInfos.Add(snapshotDataInfo);
			}
			describeLiveDomainSnapshotDataResponse.SnapshotDataInfos = describeLiveDomainSnapshotDataResponse_snapshotDataInfos;
        
			return describeLiveDomainSnapshotDataResponse;
        }
    }
}
