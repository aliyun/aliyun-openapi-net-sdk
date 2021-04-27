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
    public class DescribePropertySoftwareDetailResponseUnmarshaller
    {
        public static DescribePropertySoftwareDetailResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribePropertySoftwareDetailResponse describePropertySoftwareDetailResponse = new DescribePropertySoftwareDetailResponse();

			describePropertySoftwareDetailResponse.HttpResponse = _ctx.HttpResponse;
			describePropertySoftwareDetailResponse.RequestId = _ctx.StringValue("DescribePropertySoftwareDetail.RequestId");

			DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PageInfo pageInfo = new DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribePropertySoftwareDetail.PageInfo.Count");
			pageInfo.PageSize = _ctx.IntegerValue("DescribePropertySoftwareDetail.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribePropertySoftwareDetail.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribePropertySoftwareDetail.PageInfo.CurrentPage");
			describePropertySoftwareDetailResponse.PageInfo = pageInfo;

			List<DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware> describePropertySoftwareDetailResponse_propertys = new List<DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware>();
			for (int i = 0; i < _ctx.Length("DescribePropertySoftwareDetail.Propertys.Length"); i++) {
				DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware propertySoftware = new DescribePropertySoftwareDetailResponse.DescribePropertySoftwareDetail_PropertySoftware();
				propertySoftware.Name = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Name");
				propertySoftware.Path = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Path");
				propertySoftware.InstanceName = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstanceName");
				propertySoftware.Ip = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Ip");
				propertySoftware.Create = _ctx.LongValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Create");
				propertySoftware.CreateTimestamp = _ctx.LongValue("DescribePropertySoftwareDetail.Propertys["+ i +"].CreateTimestamp");
				propertySoftware.InstallTime = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstallTime");
				propertySoftware.Version = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Version");
				propertySoftware.Uuid = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].Uuid");
				propertySoftware.InstanceId = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InstanceId");
				propertySoftware.IntranetIp = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].IntranetIp");
				propertySoftware.InternetIp = _ctx.StringValue("DescribePropertySoftwareDetail.Propertys["+ i +"].InternetIp");

				describePropertySoftwareDetailResponse_propertys.Add(propertySoftware);
			}
			describePropertySoftwareDetailResponse.Propertys = describePropertySoftwareDetailResponse_propertys;
        
			return describePropertySoftwareDetailResponse;
        }
    }
}
