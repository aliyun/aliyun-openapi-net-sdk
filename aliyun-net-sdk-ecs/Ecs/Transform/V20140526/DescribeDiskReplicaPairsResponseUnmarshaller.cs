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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeDiskReplicaPairsResponseUnmarshaller
    {
        public static DescribeDiskReplicaPairsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDiskReplicaPairsResponse describeDiskReplicaPairsResponse = new DescribeDiskReplicaPairsResponse();

			describeDiskReplicaPairsResponse.HttpResponse = _ctx.HttpResponse;
			describeDiskReplicaPairsResponse.NextToken = _ctx.StringValue("DescribeDiskReplicaPairs.NextToken");
			describeDiskReplicaPairsResponse.RequestId = _ctx.StringValue("DescribeDiskReplicaPairs.RequestId");

			List<DescribeDiskReplicaPairsResponse.DescribeDiskReplicaPairs_DiskReplicaPair> describeDiskReplicaPairsResponse_diskReplicaPairs = new List<DescribeDiskReplicaPairsResponse.DescribeDiskReplicaPairs_DiskReplicaPair>();
			for (int i = 0; i < _ctx.Length("DescribeDiskReplicaPairs.DiskReplicaPairs.Length"); i++) {
				DescribeDiskReplicaPairsResponse.DescribeDiskReplicaPairs_DiskReplicaPair diskReplicaPair = new DescribeDiskReplicaPairsResponse.DescribeDiskReplicaPairs_DiskReplicaPair();
				diskReplicaPair.Status = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].Status");
				diskReplicaPair.SourceDiskId = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].SourceDiskId");
				diskReplicaPair.ReplicaPairId = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].ReplicaPairId");
				diskReplicaPair.Description = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].Description");
				diskReplicaPair.DestinationRegion = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].DestinationRegion");
				diskReplicaPair.PairName = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].PairName");
				diskReplicaPair.SourceRegion = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].SourceRegion");
				diskReplicaPair.DestinationDiskId = _ctx.StringValue("DescribeDiskReplicaPairs.DiskReplicaPairs["+ i +"].DestinationDiskId");

				describeDiskReplicaPairsResponse_diskReplicaPairs.Add(diskReplicaPair);
			}
			describeDiskReplicaPairsResponse.DiskReplicaPairs = describeDiskReplicaPairsResponse_diskReplicaPairs;
        
			return describeDiskReplicaPairsResponse;
        }
    }
}
