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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeGadInstancesResponseUnmarshaller
    {
        public static DescribeGadInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeGadInstancesResponse describeGadInstancesResponse = new DescribeGadInstancesResponse();

			describeGadInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeGadInstancesResponse.RequestId = _ctx.StringValue("DescribeGadInstances.RequestId");

			List<DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem> describeGadInstancesResponse_gadInstances = new List<DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem>();
			for (int i = 0; i < _ctx.Length("DescribeGadInstances.GadInstances.Length"); i++) {
				DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem gadInstancesItem = new DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem();
				gadInstancesItem.GadInstanceName = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceName");
				gadInstancesItem.Description = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].Description");
				gadInstancesItem.Status = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].Status");
				gadInstancesItem.CreationTime = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].CreationTime");
				gadInstancesItem.ModificationTime = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].ModificationTime");
				gadInstancesItem.Service = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].Service");

				List<DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem.DescribeGadInstances_GadInstanceMembersItem> gadInstancesItem_gadInstanceMembers = new List<DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem.DescribeGadInstances_GadInstanceMembersItem>();
				for (int j = 0; j < _ctx.Length("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers.Length"); j++) {
					DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem.DescribeGadInstances_GadInstanceMembersItem gadInstanceMembersItem = new DescribeGadInstancesResponse.DescribeGadInstances_GadInstancesItem.DescribeGadInstances_GadInstanceMembersItem();
					gadInstanceMembersItem.DBInstanceID = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].DBInstanceID");
					gadInstanceMembersItem.Engine = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].Engine");
					gadInstanceMembersItem.EngineVersion = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].EngineVersion");
					gadInstanceMembersItem.RegionId = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].RegionId");
					gadInstanceMembersItem.Role = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].Role");
					gadInstanceMembersItem.Status = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].Status");
					gadInstanceMembersItem.DtsInstance = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].DtsInstance");
					gadInstanceMembersItem.ResourceGroupId = _ctx.StringValue("DescribeGadInstances.GadInstances["+ i +"].GadInstanceMembers["+ j +"].ResourceGroupId");

					gadInstancesItem_gadInstanceMembers.Add(gadInstanceMembersItem);
				}
				gadInstancesItem.GadInstanceMembers = gadInstancesItem_gadInstanceMembers;

				describeGadInstancesResponse_gadInstances.Add(gadInstancesItem);
			}
			describeGadInstancesResponse.GadInstances = describeGadInstancesResponse_gadInstances;
        
			return describeGadInstancesResponse;
        }
    }
}
