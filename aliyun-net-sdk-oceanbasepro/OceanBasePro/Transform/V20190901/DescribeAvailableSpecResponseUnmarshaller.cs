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
using Aliyun.Acs.OceanBasePro.Model.V20190901;

namespace Aliyun.Acs.OceanBasePro.Transform.V20190901
{
    public class DescribeAvailableSpecResponseUnmarshaller
    {
        public static DescribeAvailableSpecResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAvailableSpecResponse describeAvailableSpecResponse = new DescribeAvailableSpecResponse();

			describeAvailableSpecResponse.HttpResponse = _ctx.HttpResponse;
			describeAvailableSpecResponse.RequestId = _ctx.StringValue("DescribeAvailableSpec.RequestId");

			DescribeAvailableSpecResponse.DescribeAvailableSpec_Data data = new DescribeAvailableSpecResponse.DescribeAvailableSpec_Data();

			List<DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem> data_availableSpecifications = new List<DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem>();
			for (int i = 0; i < _ctx.Length("DescribeAvailableSpec.Data.AvailableSpecifications.Length"); i++) {
				DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem availableSpecificationsItem = new DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem();
				availableSpecificationsItem.Spec = _ctx.StringValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].Spec");
				availableSpecificationsItem.InstanceClass = _ctx.StringValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].InstanceClass");

				List<string> availableSpecificationsItem_nodeNum = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].NodeNum.Length"); j++) {
					availableSpecificationsItem_nodeNum.Add(_ctx.StringValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].NodeNum["+ j +"]"));
				}
				availableSpecificationsItem.NodeNum = availableSpecificationsItem_nodeNum;

				DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem.DescribeAvailableSpec_DiskSizeRange diskSizeRange = new DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem.DescribeAvailableSpec_DiskSizeRange();
				diskSizeRange.Step = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].DiskSizeRange.Step");
				diskSizeRange.Max = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].DiskSizeRange.Max");
				diskSizeRange.Min = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].DiskSizeRange.Min");
				availableSpecificationsItem.DiskSizeRange = diskSizeRange;

				DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem.DescribeAvailableSpec_LogDiskSizeRange logDiskSizeRange = new DescribeAvailableSpecResponse.DescribeAvailableSpec_Data.DescribeAvailableSpec_AvailableSpecificationsItem.DescribeAvailableSpec_LogDiskSizeRange();
				logDiskSizeRange.Step = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].LogDiskSizeRange.Step");
				logDiskSizeRange.Max = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].LogDiskSizeRange.Max");
				logDiskSizeRange.Min = _ctx.LongValue("DescribeAvailableSpec.Data.AvailableSpecifications["+ i +"].LogDiskSizeRange.Min");
				availableSpecificationsItem.LogDiskSizeRange = logDiskSizeRange;

				data_availableSpecifications.Add(availableSpecificationsItem);
			}
			data.AvailableSpecifications = data_availableSpecifications;
			describeAvailableSpecResponse.Data = data;
        
			return describeAvailableSpecResponse;
        }
    }
}
