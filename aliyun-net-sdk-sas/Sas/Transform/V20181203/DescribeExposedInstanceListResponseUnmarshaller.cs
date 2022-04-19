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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeExposedInstanceListResponseUnmarshaller
    {
        public static DescribeExposedInstanceListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeExposedInstanceListResponse describeExposedInstanceListResponse = new DescribeExposedInstanceListResponse();

			describeExposedInstanceListResponse.HttpResponse = _ctx.HttpResponse;
			describeExposedInstanceListResponse.RequestId = _ctx.StringValue("DescribeExposedInstanceList.RequestId");

			DescribeExposedInstanceListResponse.DescribeExposedInstanceList_PageInfo pageInfo = new DescribeExposedInstanceListResponse.DescribeExposedInstanceList_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeExposedInstanceList.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeExposedInstanceList.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeExposedInstanceList.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeExposedInstanceList.PageInfo.Count");
			describeExposedInstanceListResponse.PageInfo = pageInfo;

			List<DescribeExposedInstanceListResponse.DescribeExposedInstanceList_ExposedInstance> describeExposedInstanceListResponse_exposedInstances = new List<DescribeExposedInstanceListResponse.DescribeExposedInstanceList_ExposedInstance>();
			for (int i = 0; i < _ctx.Length("DescribeExposedInstanceList.ExposedInstances.Length"); i++) {
				DescribeExposedInstanceListResponse.DescribeExposedInstanceList_ExposedInstance exposedInstance = new DescribeExposedInstanceListResponse.DescribeExposedInstanceList_ExposedInstance();
				exposedInstance.ExposureIp = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExposureIp");
				exposedInstance.TotalVulCount = _ctx.IntegerValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].TotalVulCount");
				exposedInstance.InternetIp = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].InternetIp");
				exposedInstance.NntfVulCount = _ctx.IntegerValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].NntfVulCount");
				exposedInstance.InstanceId = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].InstanceId");
				exposedInstance.ExposureType = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExposureType");
				exposedInstance.IntranetIp = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].IntranetIp");
				exposedInstance.RegionId = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].RegionId");
				exposedInstance.ExposureTypeId = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExposureTypeId");
				exposedInstance.AsapVulCount = _ctx.IntegerValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].AsapVulCount");
				exposedInstance.ExposurePort = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExposurePort");
				exposedInstance.Uuid = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].Uuid");
				exposedInstance.GroupName = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].GroupName");
				exposedInstance.GroupId = _ctx.LongValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].GroupId");
				exposedInstance.ExploitHealthCount = _ctx.IntegerValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExploitHealthCount");
				exposedInstance.InstanceName = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].InstanceName");
				exposedInstance.ExposureComponent = _ctx.StringValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].ExposureComponent");
				exposedInstance.LaterVulCount = _ctx.IntegerValue("DescribeExposedInstanceList.ExposedInstances["+ i +"].LaterVulCount");

				describeExposedInstanceListResponse_exposedInstances.Add(exposedInstance);
			}
			describeExposedInstanceListResponse.ExposedInstances = describeExposedInstanceListResponse_exposedInstances;
        
			return describeExposedInstanceListResponse;
        }
    }
}
